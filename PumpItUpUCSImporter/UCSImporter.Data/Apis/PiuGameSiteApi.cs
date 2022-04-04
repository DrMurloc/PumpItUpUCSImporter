using UCSImporter.Data.Apis.Contracts;

namespace UCSImporter.Data.Apis;

public sealed class PiuGameSiteApi : IPiuGameSiteApi
{
    private readonly HttpClient _httpClient;

    public PiuGameSiteApi(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetUcsPage(int page, CancellationToken cancellationToken = default)
    {
        return await _httpClient.GetStringAsync(
            $"/bbs/board.php?bo_table=ucs&sop=and&sst=wr_datetime&sod=desc&sfl=&stx=&page={page}",
            cancellationToken);
    }
}