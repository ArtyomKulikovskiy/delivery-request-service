using Delivery.Request.Service.Domain.DeliveryRequests.Enums;
namespace Delivery.Request.Service.Domain.DeliveryRequests;

public sealed class DeliveryRequest
{
    private DeliveryRequest()
    {
    }

    private DeliveryRequest(
        Guid id,
        DeliveryRequestStatus status,
        string name,
        string description,
        Guid? courierId,
        string cancellationReason,
        bool isDeleted)
    {
        Id = id;
        Status = status;
        IsDeleted = isDeleted;
        Name = name;
        Description = description;
        CancellationReason = cancellationReason;
        CourierId = courierId;
    }

    public Guid Id { get; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Guid? CourierId { get; private set; }
    public DeliveryRequestStatus Status { get; private set; }
    public string CancellationReason { get; private set; }
    public bool IsDeleted { get; private set; }

    public static DeliveryRequest Create(string name, string description)
    {
        var id = Guid.NewGuid();
        var status = DeliveryRequestStatus.New;

        var response = new DeliveryRequest(
            id: id,
            status: status,
            name: name,
            description: description,
            courierId: null,
            cancellationReason: string.Empty,
            isDeleted: false);

        return response;
    }

    public void Update(string name, string description)
    {
        if (Status is not DeliveryRequestStatus.New)
        {
            throw new ApplicationException("Can't update delivery request which status is not New");
        }

        Name = name;
        Description = description;
    }

    public void Delete()
    {
        IsDeleted = true;
    }

    public void SubmitForExecution(Guid courierId)
    {
        if (Status is not DeliveryRequestStatus.New)
        {
            throw new ApplicationException("Can't submit for execution, when delivery request status is not New");
        }

        CourierId = courierId;
        Status = DeliveryRequestStatus.SubmittedForExecution;
    }

    public void Cancel(string reason)
    {
        if (Status is not DeliveryRequestStatus.SubmittedForExecution)
        {
            throw new ApplicationException("Can't cancel, when delivery request status is not SubmitForExecution");
        }

        Status = DeliveryRequestStatus.Canceled;
        CancellationReason = reason;
    }

    public void Execute()
    {
        if (Status is not DeliveryRequestStatus.SubmittedForExecution)
        {
            throw new ApplicationException("Can't execute, when delivery request status is not SubmitForExecution");
        }

        Status = DeliveryRequestStatus.Done;
    }
}
