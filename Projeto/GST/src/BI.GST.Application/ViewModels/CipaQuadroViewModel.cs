﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Application.ViewModels
{
    public class CipaQuadroViewModel
    {
        public int CipaQuadroId { get; set; }

        public int GrupoCipaId { get; set; }

        public int NumeroEmpregadosInicial { get; set; }

        public int NumeroEmpregadosFinal { get; set; }

        public int QuantidadeEfetivos { get; set; }

        public int QuantidadeSuplentes { get; set; }

        public int AcrescentarAcima10000Efetivo { get; set; }

        public int AcrescentarAcima10000Suplente { get; set; }

        public virtual GrupoCipaViewModel GrupoCipa { get; set; }
    }
}
