namespace UCSImporter.Data.Configuration;

public sealed class PiuGameConfiguration
{
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsConfigured => !string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password);
}