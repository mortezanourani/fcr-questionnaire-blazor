namespace FCR.Models;

public class Question
{
    public Guid Id { get; set; }

    public int Position { get; set; }

    public string Text { get; set; } = null!;

    public Guid ScaleId { get; set; }
    public Scale Scale { get; set; } = null!;

    public Guid QuestionnaireId { get; set; }
    public Questionnaire Questionnaire { get; set; } = null!;
}
