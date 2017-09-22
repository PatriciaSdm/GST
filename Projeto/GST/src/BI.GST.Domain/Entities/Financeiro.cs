﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Domain.Entities
{
  public class Financeiro
  {
    public int FinanceiroId { get; set; }

    public string Titulo { get; set; }

    public int Operacao { get; set; }

    public string Descricao { get; set; }

    public virtual Colaborador Colaborador { get; set; }

    public string DataOperacao { get; set; }

    public int NumeroParcelas { get; set; }

    public string DataVencimento { get; set; }

    public string DataQuitacao { get; set; }

    public double Valor { get; set; }

    public string Instituicao { get; set; }

    public string Status { get; set; }

    public bool Delete { get; set; }
  }
}