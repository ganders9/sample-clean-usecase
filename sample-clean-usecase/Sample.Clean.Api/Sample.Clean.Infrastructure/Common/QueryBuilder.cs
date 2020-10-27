using System.Collections.Generic;
using System.Net;

namespace Sample.Clean.Infrastructure.Common
{
    internal class QueryBuilder
    {
        private readonly Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private readonly string _path = "";

        public QueryBuilder() { }

        public QueryBuilder(string path)
        {
            _path = path;
        }

        public QueryBuilder Add(string name, string value)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(value))
            {
                return this;
            }

            _parameters.Add(name, value);

            return this;
        }

        public string Build()
        {
            if (_parameters.Count == 0)
            {
                return _path;
            }

            var items = new List<string>();
            foreach (KeyValuePair<string, string> kvp in _parameters)
            {
                items.Add(string.Concat(kvp.Key, "=", WebUtility.UrlEncode(kvp.Value)));
            }

            var query = string.Join("&", items);

            return string.IsNullOrEmpty(_path) ? query : $"{_path}?{query}";
        }
    }
}