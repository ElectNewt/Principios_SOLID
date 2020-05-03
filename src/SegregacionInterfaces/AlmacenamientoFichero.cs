using System.IO;

namespace SegregacionInterfaces
{
    public class AlmacenamientoFichero : IAlmacenamiento
    {
        readonly string path = "C:/temp";
        readonly IFicheroInformacion _ficheroInformacion;

        public AlmacenamientoFichero(IFicheroInformacion ficheroInformacion)
        {
            _ficheroInformacion = ficheroInformacion;
        }

        public void Guardar(string titulo, string contenido)
        {
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
        }

        public string Leer(string titulo)
        {
            if (!LeerFichero(titulo).Exists)
                return null;

            return File.ReadAllText($"{path}/{titulo}.txt");
        }

        private FileInfo LeerFichero(string nombre) {
            return _ficheroInformacion.GetInformacion(nombre);
        }

    }
}
