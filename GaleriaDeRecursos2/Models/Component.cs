using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaDeRecursos2.Models
{
    internal class Component
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Type Page { get; set; }
        //Página que será aberta no Detail
    }
}
