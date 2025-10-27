namespace FCR.Data;

public class Question
{
    public Guid Id { get; set; }

    public int Position { get; set; }

    public string Text { get; set; } = null!;

    public Guid QiestionnaireId { get; set; }
    public Questionnaire Questionnaire { get; set; } = null!;
}
