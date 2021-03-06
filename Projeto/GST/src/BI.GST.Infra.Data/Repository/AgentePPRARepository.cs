﻿using BI.GST.Domain.Entities;
using BI.GST.Domain.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Infra.Data.Repository
{
    public class AgentePPRARepository : BaseRepository<AgentePPRA>, IAgentePPRARepository
    {
        public IEnumerable<AgentePPRA> ObterGrid(int page, string pesquisa, int ppraId)
        {
            return DbSet.Where(x => (x.Delete == false)
                && (x.PPRAId == ppraId))
             .Skip((page) * 10)
             .Take(10);
        }

        public int ObterTotalRegistros(string pesquisa, int ppraId)
        {
            return DbSet.Count(x => (x.Delete == false)
                && (x.PPRAId == ppraId));
        }
    }
}
