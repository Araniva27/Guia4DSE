using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Common
{
    public class AppSettings
    {
        public string connectionString { get; set; } = "Server=localhost;DataBase=biblioteca;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=False";
    }
}
