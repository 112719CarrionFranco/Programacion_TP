﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransporteBack.Servicios
{
    public abstract class AbstractServiceFactory
    {
        public abstract IService CrearService();
    }
}
