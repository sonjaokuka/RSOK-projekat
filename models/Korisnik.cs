using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvecara.models
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string isAdmin { get; set; }

    }
}
