namespace CV.BE
{
    public interface IAppConfig
    {
        string DbConnectionString { get; set; }
    }

    public class AppConfig : IAppConfig
    {
        public string DbConnectionString { get; set; }
    }
}
