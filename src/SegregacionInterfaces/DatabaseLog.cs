using System;
using System.Collections.Generic;
using System.Text;

namespace SegregacionInterfaces
{
    public interface ILogging
    {
        void Info(string message);
        void Error(string mensaje, Exception e);
        void Fatal(string mensaje, Exception e);
    }

    public class DatabaseLog : ILogging
    {
        public readonly LogRepository _logRepo;
        public readonly Logging _log;

        public DatabaseLog()
        {
            _logRepo = new LogRepository();
            _log = new Logging();

        }

        public void Error(string mensaje, Exception e) =>
            _log.Error(mensaje, e);

        public void Fatal(string mensaje, Exception e)
        {
            _logRepo.AlmacenarError(mensaje, e);
            _log.Fatal(mensaje, e);
        }

        public void Info(string message)
        => _log.Info(message);
    }
}
