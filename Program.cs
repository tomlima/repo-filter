namespace Project
{
    class Program {
      public static void Main() {
        Console.WriteLine("Starting my project....");
        string apiToken = _configuration.GetSection("AppSettings:TOKENAPI");
        _service.Authentication(apiToken);
        _service.SendEmail(); 
      }
    }
}
