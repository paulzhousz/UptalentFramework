using System.Configuration;
using System.Data.SqlClient;

namespace UptalentFramework.Localization
{
    public class LocalizationDbResourceProvider : LocalizationResourceProviderBase
    {
        private string _connectionString;

        public LocalizationDbResourceProvider()
            : this(Constants.CONNSTRING_DEFAULT_NAME)
        {
        }

        public LocalizationDbResourceProvider(string connectionStringName)
            : base()
        {
            _connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
        }

        protected override string OnGetString(string cultureName, string key)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT [Value] FROM [Caspar].[dbo].[Resource] WHERE [Key] = @key AND [Culture] = @culture";
                    cmd.Parameters.AddWithValue("key", key);
                    cmd.Parameters.AddWithValue("culture", cultureName);
                    conn.Open();
                    var value = cmd.ExecuteScalar();
                    return (string)value;
                }
            }
        }
    }
}