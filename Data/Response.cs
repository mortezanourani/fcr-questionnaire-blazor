namespace FCR.Data;

public class Response
{
    public Guid Id { get; set; }

    public Guid ParticipantId { get; set; }
    public Participant Participant { get; set; } = null!;

    public Guid QuestionId { get; set; }
    public Question Question { get; set; } = null!;

    public Guid OptionId { get; set; }
    public LikertOption Option { get; set; } = null!;
}
