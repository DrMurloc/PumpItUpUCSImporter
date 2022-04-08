using System.Threading.Tasks;
using MediatR;
using Microsoft.Azure.WebJobs;
using UCSImporter.Application.Commands;

namespace UCSImporter.AzureFunction;

public sealed class ImportFunctions
{
    private readonly IMediator _mediator;

    public ImportFunctions(IMediator mediator)
    {
        _mediator = mediator;
    }

    [FunctionName("DailyImport")]
    public async Task Run([TimerTrigger("0 0 * * * *")] TimerInfo myTimer)
    {
        await _mediator.Send(new ImportChartsCommand());
    }
    /*
    [FunctionName("ManualImport")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "Import")]
        HttpRequest req)
    {
        await _messageClient.NotifyChartsImported(new[]
        {
            new Chart(1, new Song("Test Song Name"), ChartType.Single, 16, new StepArtist("Step Artist"),
                DateOnly.FromDateTime(DateTime.Now)),
            new Chart(2, new Song("Another Test"), ChartType.Double, 14, new StepArtist("Some Artist"),
                DateOnly.FromDateTime(DateTime.Now))
        }, req.HttpContext.RequestAborted);
        return new JsonResult(new
        {
            Message = "Import completed!"
        });
    }
    */
}