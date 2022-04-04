using System.Collections.Immutable;
using System.Text.RegularExpressions;
using UCSImporter.Data.Apis.Contracts;
using UCSImporter.Domain.Contracts;
using UCSImporter.Domain.Enums;
using UCSImporter.Domain.Exceptions;
using UCSImporter.Domain.Models;
using UCSImporter.Domain.ValueTypes;

namespace UCSImporter.Data;

public sealed class AndamiroNewChartRepository : INewChartRepository
{
    private static readonly Regex ChartLineRegex =
        new(@"<tr>.*?<\/tr>", RegexOptions.Compiled | RegexOptions.Singleline);

    private static readonly Regex ChartIdRegex = new(@"<td class=""share_no"">.*?([0-9]+).*?<\/td>",
        RegexOptions.Compiled | RegexOptions.Singleline);

    private static readonly Regex SongNameRegex = new(
        @"<span class=""share_song_title""><a href="".*?"">(.*?)<\/a><\/span>",
        RegexOptions.Compiled | RegexOptions.Singleline);

    private static readonly Regex StepMakerRegex =
        new(@"<td class=""share_stepmaker""><img .*?>&nbsp;&nbsp;(.*?)<\/td>",
            RegexOptions.Compiled | RegexOptions.Singleline);

    private static readonly Regex LevelRegex = new(@"lv([0-9]+)", RegexOptions.Compiled);

    private static readonly Regex DifficultyRegex = new(@"<td class=""share_level""><span class=""(.*?)"">",
        RegexOptions.Compiled | RegexOptions.Singleline);

    private static readonly Regex UploadDateRegex = new(@"<td class=""share_upload_date"">(.*?)<\/td>",
        RegexOptions.Compiled | RegexOptions.Singleline);


    private readonly IPiuGameSiteApi _piuGameSiteApi;

    public AndamiroNewChartRepository(IPiuGameSiteApi piuGameSiteApi)
    {
        _piuGameSiteApi = piuGameSiteApi;
    }

    public async Task<IEnumerable<Chart>> GetNewCharts(int page, CancellationToken cancellationToken = default)
    {
        var result = await _piuGameSiteApi.GetUcsPage(page, cancellationToken);
        var chartLines = ChartLineRegex.Matches(result);
        return ParseCharts(chartLines.Skip(1).Select(r => r.Value)).ToImmutableArray();
    }

    private static IEnumerable<Chart> ParseCharts(IEnumerable<string> chartLines)
    {
        foreach (var chartLine in chartLines)
        {
            Chart result;
            try
            {
                result = ParseChart(chartLine);
            }
            catch (Exception)
            {
                continue;
            }

            yield return result;
        }
    }

    private static Chart ParseChart(string chartLine)
    {
        var chartIdMatch = ChartIdRegex.Match(chartLine);
        if (!chartIdMatch.Success || !ChartId.TryParse(chartIdMatch.Groups[1].Value, out var chartId))
            throw new InvalidChartIdException("Could not extract chart Id");

        var songNameMatch = SongNameRegex.Match(chartLine);
        if (!songNameMatch.Success || !Name.TryParse(songNameMatch.Groups[1].Value, out var songName))
            throw new InvalidNameException($"Could not extract song name for chartId {chartId}");

        var artistNameMatch = StepMakerRegex.Match(chartLine);
        if (!artistNameMatch.Success || !Name.TryParse(artistNameMatch.Groups[1].Value, out var stepArtistName))
            throw new InvalidNameException($"Could not extract step artist name for chartId {chartId}");

        var difficultyMatch = DifficultyRegex.Match(chartLine);
        if (!difficultyMatch.Success ||
            !ParseDifficultyClass(difficultyMatch.Groups[1].Value, out var level, out var type))
            throw new Exception($"Could not extract difficulty and chart type for chartId {chartId}");

        var dateMatch = UploadDateRegex.Match(chartLine);
        if (!dateMatch.Success || !TryParseAndamiroWeirdDateFormat(dateMatch.Groups[1].Value, out var uploadDate))
            throw new Exception($"Could not extract upload date for chartId {chartId}");

        return new Chart(chartId, new Song(songName), type, level, new StepArtist(stepArtistName),
            uploadDate);
    }

    private static bool TryParseAndamiroWeirdDateFormat(string dateString, out DateOnly result)
    {
        try
        {
            var split = dateString.Split("-");
            var day = int.Parse(split[2]);
            var month = int.Parse(split[1]);
            var year = 2000 + int.Parse(split[0]);
            result = new DateOnly(year, month, day);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    private static bool ParseDifficultyClass(string classString, out DifficultyLevel difficultyResult,
        out ChartType chartTypeResult)
    {
        difficultyResult = DifficultyLevel.Min;
        var difficultyParsed = false;
        chartTypeResult = ChartType.Single;
        var chartTypeParsed = false;
        var classes = classString.Split(" ").Where(c => !string.IsNullOrWhiteSpace(c)).Select(c => c.Trim());
        foreach (var c in classes)
            switch (c.ToLower())
            {
                case "s_stepball_sinper":
                    chartTypeResult = ChartType.SinglePerformance;
                    chartTypeParsed = true;
                    break;
                case "s_stepball_single":
                    chartTypeResult = ChartType.Single;
                    chartTypeParsed = true;
                    break;
                case "s_stepball_double":
                    chartTypeResult = ChartType.Double;
                    chartTypeParsed = true;
                    break;
                case "s_stepball_douper":
                    chartTypeResult = ChartType.DoublePerformance;
                    chartTypeParsed = true;
                    break;
                case "s_stepball_coop":
                    chartTypeResult = ChartType.CoOp;
                    chartTypeParsed = true;
                    break;
                default:
                    var levelMatch = LevelRegex.Match(c);
                    if (!levelMatch.Success ||
                        !DifficultyLevel.TryParse(levelMatch.Groups[1].Value, out var level)) break;

                    difficultyResult = level;
                    difficultyParsed = true;
                    break;
            }

        return difficultyParsed && chartTypeParsed;
    }
}