﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Domain.Entities
{
  public class RiscoFuncionario
  {
    public int RiscoFuncionarioId { get; set; }

    public virtual AgenteRiscoCBO AgenteRiscoCBO { get; set; }

    public virtual AgenteCausadorCBO AgenteCausadorCBO { get; set; }

    public virtual FonteRiscoCBO FonteRiscoCBO { get; set; }

    public string Consequencias { get; set; }

    public string MedidasPreventivas { get; set; }

    public bool Delete { get; set; }
  }
}