namespace MassTransitConsumer;

public class SigningRequestCompletionMessageModel
{
    public string SigningRequestId { get; set; }
    public string AppId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    public string DocumentName { get; set; }
    public string DocumentStatus { get; set; }
    public List<RecipientsActions> RecipientsActions { get; set; }
    public string SharedDocumentUrl { get; set; }
}
public class RecipientsActions
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DateActioned { get; set; }
    public string ActionTaken { get; set; }
}

