namespace FCR.Models;

public class Option
{
    public Guid Id { get; set; }

    public int Score { get; set; }

    public string Label { get; set; } = null!;

    public Guid ScaleId { get; set; }
    public Scale Scale { get; set; } = null!;
}
