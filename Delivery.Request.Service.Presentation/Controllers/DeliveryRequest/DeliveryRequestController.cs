using System.Threading;
using System.Threading.Tasks;

using Delivery.Request.Service.Application.DeliveryRequests.Commands.Cancel.Contracts;
using Delivery.Request.Service.Application.DeliveryRequests.Commands.Create.Contracts;
using Delivery.Request.Service.Application.DeliveryRequests.Commands.Delete.Contracts;
using Delivery.Request.Service.Application.DeliveryRequests.Commands.Execute.Contracts;
using Delivery.Request.Service.Application.DeliveryRequests.Commands.SubmitForExecution.Contracts;
using Delivery.Request.Service.Application.DeliveryRequests.Commands.Update.Contracts;
using Delivery.Request.Service.Application.DeliveryRequests.Queries.GetById.Contracts;
using Delivery.Request.Service.Application.DeliveryRequests.Queries.Search.Contracts;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Cancel;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Create;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Delete;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Execute;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.GetById;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Search;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.SubmitForExecution;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Contracts.Update;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Cancel;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Create;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Delete;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Execute;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.GetById;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Search;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.SubmitForExecution;
using Delivery.Request.Service.Presentation.Controllers.DeliveryRequest.Converters.Update;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace Delivery.Request.Service.Presentation.Controllers.DeliveryRequest;

[ApiController]
[Route("delivery-request")]
public sealed class DeliveryRequestController : ControllerBase
{
    private readonly IMediator _mediator;

    public DeliveryRequestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [ProducesResponseType(typeof(SearchDeliveryRequestQueryResponse), 200)]
    [HttpPost(nameof(Search))]
    public async Task<IActionResult> Search(
        [FromQuery] SearchDeliveryRequestQuery request,
        CancellationToken cancellationToken)
    {
        SearchDeliveryRequestQueryInternal queryInternal = SearchDeliveryRequestQueryConverter.ToInternal(request);

        SearchDeliveryRequestQueryResponseInternal responseInternal = await _mediator.Send(queryInternal, cancellationToken);

        SearchDeliveryRequestQueryResponse response = SearchDeliveryRequestQueryResponseConverter.FromInternal(responseInternal);

        return Ok(response);
    }

    [ProducesResponseType(typeof(CreateDeliveryRequestCommandResponse), 200)]
    [HttpPost(nameof(Create))]
    public async Task<IActionResult> Create(
        [FromBody] CreateDeliveryRequestCommand request,
        CancellationToken cancellationToken)
    {
        CreateDeliveryRequestCommandInternal commandInternal = CreateDeliveryRequestCommandConverter.ToInternal(request);

        CreateDeliveryRequestCommandResponseInternal responseInternal = await _mediator.Send(commandInternal, cancellationToken);

        var response = new CreateDeliveryRequestCommandResponse { Id = responseInternal.Id };

        return Ok(response);
    }


    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [HttpPost(nameof(Cancel))]
    public async Task<IActionResult> Cancel(
        [FromBody] CancelDeliveryRequestCommand request,
        CancellationToken cancellationToken)
    {
        CancelDeliveryRequestCommandInternal commandInternal = CancelDeliveryRequestCommandConverter.ToInternal(request);

        await _mediator.Send(commandInternal, cancellationToken);

        return NoContent();
    }

    [ProducesResponseType(204)]
    [HttpPost(nameof(Delete))]
    public async Task<IActionResult> Delete(
        [FromBody] DeleteDeliveryRequestCommand request,
        CancellationToken cancellationToken)
    {
        DeleteDeliveryRequestCommandInternal commandInternal = DeleteDeliveryRequestCommandConverter.ToInternal(request);

        await _mediator.Send(commandInternal, cancellationToken);

        return NoContent();
    }

    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [HttpPost(nameof(Execute))]
    public async Task<IActionResult> Execute(
        [FromBody] ExecuteDeliveryRequestCommand request,
        CancellationToken cancellationToken)
    {
        ExecuteDeliveryRequestCommandInternal commandInternal = ExecuteDeliveryRequestCommandConverter.ToInternal(request);

        await _mediator.Send(commandInternal, cancellationToken);

        return NoContent();
    }

    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [HttpPost(nameof(Update))]
    public async Task<IActionResult> Update(
        [FromBody] UpdateDeliveryRequestCommand request,
        CancellationToken cancellationToken)
    {
        UpdateDeliveryRequestCommandInternal commandInternal = UpdateDeliveryRequestCommandConverter.ToInternal(request);

        await _mediator.Send(commandInternal, cancellationToken);

        return NoContent();
    }

    [ProducesResponseType(400)]
    [ProducesResponseType(204)]
    [HttpPost(nameof(SubmitForExecution))]
    public async Task<IActionResult> SubmitForExecution(
        [FromBody] SubmitForExecutionDeliveryRequestCommand request,
        CancellationToken cancellationToken)
    {
        SubmitForExecutionDeliveryRequestCommandInternal commandInternal = SubmitForExecutionDeliveryRequestCommandConverter
            .ToInternal(request);

        await _mediator.Send(commandInternal, cancellationToken);

        return NoContent();
    }
    
    [ProducesResponseType(404)]
    [ProducesResponseType(typeof(GetByIdDeliveryRequestQueryResponse), 200)]
    [HttpPost(nameof(GetById))]
    public async Task<IActionResult> GetById(
        [FromBody] GetByIdDeliveryRequestQuery request,
        CancellationToken cancellationToken)
    {
        GetByIdDeliveryRequestQueryInternal commandInternal = GetByIdDeliveryRequestQueryConverter
            .ToInternal(request);

        GetByIdDeliveryRequestQueryResponseInternal responseInternal = await _mediator.Send(commandInternal, cancellationToken);

        GetByIdDeliveryRequestQueryResponse response = GetByIdDeliveryRequestQueryResponseConverter.FromInternal(responseInternal);
        
        return Ok(response);
    }
}
