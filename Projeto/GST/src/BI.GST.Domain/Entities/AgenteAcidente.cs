﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Domain.Entities
{
  public class AgenteAcidente
  {
    public int AgenteAcidenteId { get; set; }

    public string Nome { get; set; }

    public string Frequencia { get; set; }

    public virtual ClassificacaoEfeito ClassificacaoEfeito { get; set; }

    public string TempoExposicao { get; set; }

    public string Fonte { get; set; }

    public string Efeito { get; set; }

    public string Orientacao { get; set; }

    public string MedidasPropostas { get; set; }

    public string Movimentacao { get; set; }

    public bool Delete { get; set; }
  }
}