﻿using BI.GST.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BI.GST.Infra.Data.EntityConfig
{
  public class MeioPropagacaoConfiguration : EntityTypeConfiguration<MeioPropagacao>
  {
    public MeioPropagacaoConfiguration()
    {
      HasKey(e => e.MeioPropagacaoId);
    }
  }
}