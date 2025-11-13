using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.Models
{
    public class Avsnitt
    {
        public string Titel { get; set; } // Avsnittets titel 
        public string Beskrivning { get; set; } // Avsnittets beskrivning/innehåll 
        public DateTime Publiceringsdatum { get; set; } // Avsnittets publiceringsdatum 
    }
}
