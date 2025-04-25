using Microsoft.IdentityModel.Tokens;
using System.Data.SqlClient;
using System.Text;
using System.Web;

namespace Gestin.LocalFiles
{
    public class LocalConnection
    {
        private static string? connectionString;

        public static string? ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(connectionString))
                {
                    connectionString = LocalGestinSettings.Instance.readFileDataBySection("ConnectionString")[0];
                }
                return connectionString;
            }
            set { connectionString = value; }
        }

        public static List<SqlConnectionStringBuilder> defaultConnections()
        {
            List<SqlConnectionStringBuilder> staticConnections =
            [
                new($"Server={System.Net.Dns.GetHostName()};Database=DbGestin;Trusted_Connection=True;Connect Timeout=5"),
                new("Server=192.168.128.63,1433;Database=DbGestin;User Id=Preceptoria02;Password=321")
            ];
            return staticConnections;
        }
    }
}