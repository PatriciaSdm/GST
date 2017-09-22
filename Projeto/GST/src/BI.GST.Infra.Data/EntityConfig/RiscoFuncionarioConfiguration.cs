﻿using BI.GST.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BI.GST.Infra.Data.EntityConfig
{
  public class RiscoFuncionarioConfiguration : EntityTypeConfiguration<RiscoFuncionario>
  {
    public RiscoFuncionarioConfiguration()
    {
      HasKey(e => e.RiscoFuncionarioId);
    }
  }
}