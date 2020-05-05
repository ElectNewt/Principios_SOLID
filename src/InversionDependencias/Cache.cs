using System.Collections.Generic;

namespace InversionDependencias
{
    public class Cache
    {
        private readonly Dictionary<string, string> CacheDicctionary;
        public Cache()
        {
            CacheDicctionary = new Dictionary<string, string>();
        }

        public void Add(string titulo, string contenido)
        {
            if (!CacheDicctionary.TryAdd(titulo, contenido))
            {
                CacheDicctionary[titulo] = contenido;
            }
        }

        public string Get(string titulo)
        {
            CacheDicctionary.TryGetValue(titulo, out string contenido);
            return contenido;
        }

    }
}
