namespace MobileCamoes.Infra
{
    public class AppSettings
    {
        public const string ApiUrl = "https://api.themoviedb.org/3";
        public const string ApiKey = "d789470d38cce2276363d13b4c7ad26c";
        public const string ApiImageBaseUrl = "https://image.tmdb.org/t/p/w500/";

        public static string OfflineDataBaseLiteDBPath { get; set; }
        public static string OfflineDataBaseSQLitePath { get; set; }
        public static string OfflineFileSystemPath { get; set; }
    }
}
