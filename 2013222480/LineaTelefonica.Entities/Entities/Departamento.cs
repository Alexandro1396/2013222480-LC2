﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities.Entities
{
    public class Departamento
    {
        public List<Provincia> ListProvincia { set; get; }
        public int DepartamentoId { get; set; }
        public List<Ubigeo> ListUbigeo { set; get; }
        

        
    }
}
