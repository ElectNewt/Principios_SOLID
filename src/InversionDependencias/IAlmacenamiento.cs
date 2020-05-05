using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InversionDependencias
{

    public interface IFicheroInformacion
    {
        FileInfo GetInformacion(string nombre);
    }
    

    public interface IAlmacenamiento
    {
        void Guardar(string titulo, string contenido);
        string Leer(string titulo);
    }
}
