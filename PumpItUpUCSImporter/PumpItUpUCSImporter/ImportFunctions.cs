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
    public async Task Run([TimerTrigger("0 30 9 * * *")] TimerInfo myTimer)
    {
        await _mediator.Send(new ImportChartsCommand());
    }
    /*
    [FunctionName("ManualImport")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "Import")]
        HttpRequest req)
    {
        await _mediator.Send(new ImportChartsCommand(), req.HttpContext.RequestAborted);
        return new JsonResult(new
        {
            Message = "Import completed!"
        });
    }}}*/
}