namespace ResponsabilidadUnica
{
    public class ArticulosServicio
    {
        private readonly Cache _cache;
        private readonly Logging _logging;
        private readonly Almacenamiento _almacenamiento;

        public ArticulosServicio()
        {
            _logging = new Logging();
            _almacenamiento = new Almacenamiento();
            _cache = new Cache();
        }

        public void GuardarArticulo(string contenido, string titulo)
        {
            _logging.Info($"vamos a insertar el articulo {titulo}");
            _almacenamiento.EscribirFichero(titulo, contenido);
            _logging.Info($"articulo {titulo} insertado");
            _cache.Add(titulo, contenido);
        }

        public string ConsultarArticulo(string titulo)
        {
            _logging.Info($"Consultar artículo {titulo}");

            string contenido = _cache.Get(titulo);
            if (!string.IsNullOrWhiteSpace(contenido))
            {
                _logging.Info($"Artículo encontrado en la cache {titulo}");
                return contenido;
            }

            _logging.Info($"buscar articulo en el sistema de archivos {titulo}");

            return _almacenamiento.LeerFichero(titulo);
        }
    }
}
