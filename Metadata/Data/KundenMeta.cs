using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Metadata.Data
{
    public class KundenMeta
    {
        [Required]
        public string Vorname { get; set; }
        [Required]
        public string Nachname { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Dies ist keine gültige E-Mailadresse")]
        public string Email { get; set; }
    }
}
