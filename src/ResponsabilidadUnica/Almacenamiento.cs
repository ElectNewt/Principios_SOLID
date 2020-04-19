using System.IO;

namespace ResponsabilidadUnica
{
    public class Almacenamiento
    {
        readonly string path = "C:/temp";
        public void EscribirFichero(string titulo, string contenido)
        {
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
        }

        public string LeerFichero(string titulo)
        {
            return File.ReadAllText($"{path}/{titulo}.txt");
        }
    }
}
