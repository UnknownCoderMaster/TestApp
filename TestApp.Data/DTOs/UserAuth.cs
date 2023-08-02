namespace TestApp.Data.DTOs;

public class UserAuth
{
    public int? Id { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool IsAuth { get; set; }
}
