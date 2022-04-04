using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using UCSImporter.Application.Commands;

namespace UCSImporter.AzureFunction;

public sealed class ManualImportEndpoint
{
    private readonly IMediator _mediator;

    public ManualImportEndpoint(IMediator mediator)
    {
        _mediator = mediator;
    }

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
    }
}