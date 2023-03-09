namespace GeneralDepartament.Models;

public class ResponceApi
{
    public class ResponseLogin
    {
        public User data { get; set; }
        public Error error { get; set; }
    }
    public class Error
    {
        public int code { get; set; }
        public string msg { get; set; }
    }
    public class User
    {
        public int Id { get; set; }

        public string Code { get; set; } = null!;

        public int IdRole { get; set; }

        public string Name { get; set; } = null!;

        public string? Token { get; set; }
        
    }
}