namespace UCSImporter.Data.Apis.Contracts;

public interface IPiuGameSiteApi
{
    Task<string> GetUcsPage(int page, CancellationToken cancellationToken = default);
}