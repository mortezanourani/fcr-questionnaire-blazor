namespace FCR.Models;

public class Scale
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public ICollection<Option> Options { get; set; } = null!;
}
