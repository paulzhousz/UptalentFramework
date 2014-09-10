using System;
using System.Text;
using System.Linq;


namespace UptalentFramework.Data
{
    internal static class DataUtil
    {
        internal static string GenerateExecuteStoredProcedureSql(string procedureName, params object[] args)
        {
            var sb = new StringBuilder(";Exec ");
            sb.Append(procedureName);
            for (int i = 0; i < args.Count(); i++)
            {
                sb.Append(String.Format(" @{0}", i));
                if (i < args.Count() - 1)
                {
                    sb.Append(",");
                }
            }
            return sb.ToString();
        }
    }
}