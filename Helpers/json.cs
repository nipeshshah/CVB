using System;
using System.Data.SqlTypes;
using Newtonsoft.Json.Linq;

namespace Helpers
{
    public class json
    {
        public string String(JObject pairs, string name)
        {
            if (pairs == null || pairs[name] == null)
                return string.Empty;
            else
                return pairs[name]?.ToString();
        }

        public DateTime Date(JObject pairs, string name)
        {
            if (pairs == null || pairs[name] == null || pairs[name]?.ToString() == "")
                return SqlDateTime.MinValue.Value;
            else
                return Convert.ToDateTime(pairs[name].ToString());
        }

        public int Boolean(JObject pairs, string name)
        {
            if (pairs == null || pairs[name] == null)
                return 0;
            else
                return Convert.ToBoolean(pairs[name]) ? 1 : 0;
        }
    }
}