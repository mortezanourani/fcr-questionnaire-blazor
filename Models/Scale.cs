namespace FCR.Models;

public class Scale
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public ScaleType Type { get; set; } = 0;

    public ICollection<Option>? Options { get; set; }
}

public enum ScaleType
{
    Options = 0,
    Number = 1,
    Text = 2,
    Checks = 3
}