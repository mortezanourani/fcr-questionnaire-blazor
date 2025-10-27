namespace FCR.Data;

public class LikertOption
{
    public Guid Id { get; set; }

    public int Score { get; set; }

    public string Label { get; set; } = null!;

    public bool Reverse { get; set; } = false;
}
