namespace ChatGPT.Model.Services;

public class ChatServiceSettings
{
    public string? Model { get; set; }
    public string? Prompt { get; set; }
    public string? Suffix { get; set; }
    public decimal Temperature { get; set; }
    public int MaxTokens { get; set; }
    public decimal TopP { get; set; }
    public string? Stop { get; set; }
}
