using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfChartDemo.Models
{

    public class User : Base
    {
        public string NrOsob { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string Stanowisko { get; set; }
        public string MiejsceWykonywaniaPracy { get; set; }
        public string NazwiskoPrzełożonego { get; set; }
        public string ImiePrzełożonego { get; set; }
    }
}
