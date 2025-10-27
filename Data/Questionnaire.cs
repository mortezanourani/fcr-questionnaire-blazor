using System.ComponentModel;

namespace FCR.Data;

public class Questionnaire
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public ICollection<Question> Questions { get; set; } = new List<Question>();
}
