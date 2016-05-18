using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxWebApplication.Models
{
    public class Rabit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AngerLevel { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Grudge> Grudges{ get; set; }

    }
}
