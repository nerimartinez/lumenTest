using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesLayer.Models
{
    public class Model
    {
        public int Id { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Name { get; set; }
    }
}
