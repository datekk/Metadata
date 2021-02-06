using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata.Data
{
    public partial class Kunden
    {
        public int Id { get; set; }
        public string Vorname { get; set; }
        public string Nachnamme { get; set; }
        public string Email { get; set; }
    }
}
