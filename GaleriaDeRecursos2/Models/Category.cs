using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaDeRecursos2.Models
{
    internal class Category
    {
        public string Name { get; set; }
        public List<Component> Components { get; set; }
    }
}
