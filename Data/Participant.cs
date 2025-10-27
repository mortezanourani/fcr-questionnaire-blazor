namespace FCR.Data;

public class Participant
{
    public Guid Id { get; set; }

    public DateTime SubmissionTime { get; set; } = DateTime.UtcNow;

    public ICollection<Response> Responses { get; set; } = new List<Response>();
}
