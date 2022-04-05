using Microsoft.Extensions.Options;
using UCSImporter.Data.Apis.Contracts;
using UCSImporter.Data.Configuration;

namespace UCSImporter.Data.Apis;

public sealed class PiuGameSiteApi : IPiuGameSiteApi
{
    private readonly PiuGameConfiguration _config;
    private readonly HttpClient _httpClient;
    private DateTimeOffset _nextLoginTime = DateTimeOffset.Now;

    public PiuGameSiteApi(HttpClient httpClient, IOptions<PiuGameConfiguration> options)
    {
        _httpClient = httpClient;
        _config = options.Value;
    }

    public async Task<string> GetUcsPage(int page, CancellationToken cancellationToken = default)
    {
        await LogInIfNeeded(cancellationToken);

        return await _httpClient.GetStringAsync(
            $"/bbs/board.php?bo_table=ucs&sop=and&sst=wr_datetime&sod=desc&sfl=&stx=&page={page}",
            cancellationToken);
    }

    public async Task<string> GetChartFile(int chartId, CancellationToken cancellationToken = default)
    {
        await LogInIfNeeded(cancellationToken);

        return await _httpClient.GetStringAsync($"/bbs/download.php?bo_table=ucs&wr_id={chartId}&no=0",
            cancellationToken);
    }

    private async Task LogInIfNeeded(CancellationToken cancellationToken = default)
    {
        if (DateTimeOffset.Now > _nextLoginTime)
        {
            await _httpClient.PostAsync(
                "/bbs/piu.login_check.php",
                new FormUrlEncodedContent(new KeyValuePair<string, string>[]
                {
                    new("mb_id", _config.Email),
                    new("mb_password", _config.Password)
                }),
                cancellationToken);
            _nextLoginTime = DateTimeOffset.Now.AddMinutes(15);
        }
    }
}