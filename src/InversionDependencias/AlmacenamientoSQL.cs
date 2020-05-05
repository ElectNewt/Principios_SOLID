using System;
using System.IO;

namespace InversionDependencias
{
    public class AlmacenamientoSQL : IAlmacenamiento
    {
        private DBRepository _dBRepository;
        public AlmacenamientoSQL(DBRepository dBRepository)
        {
            _dBRepository = dBRepository;
        }

        public void Guardar(string titulo, string contenido)
        {
            _dBRepository.Guardar(titulo, contenido);
        }

        public string Leer(string titulo)
        {
            return _dBRepository.Leer(titulo);
        }
    }
}
