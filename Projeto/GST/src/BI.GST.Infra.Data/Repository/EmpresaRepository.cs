﻿using BI.GST.Domain.Entities;
using BI.GST.Domain.Interface.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Infra.Data.Repository
{
	public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
	{
		public int ObterTotalRegistros(string pesquisa)
		{
			return DbSet.Count(x => (pesquisa != null ? x.NomeFantasia.Contains(pesquisa) : x.NomeFantasia != null) && (x.Delete == false));
		}

		public IEnumerable<Empresa> ObterGrid(int page, string pesquisa)
		{
			return DbSet.Where(x => (pesquisa != null ? x.NomeFantasia.Contains(pesquisa) : x.NomeFantasia != null) && (x.Delete == false))
					   .OrderBy(u => u.NomeFantasia)
					   .Skip((page) * 10)
					   .Take(10);
		}

		public override void Adicionar(Empresa obj)
		{
			//Adiciona lista de cnae completa com o cnae Id que foi pego na tela
			List<Cnae> cnaes = new List<Cnae>();
			foreach (var item in obj.CnaeSecundarios)
				cnaes.Add(new CnaeRepository().ObterPorId(item.CnaeId));
			obj.CnaeSecundarios = cnaes;

			//Adiciona lista de setores completa com o setor id que foi pego na tela
			List<Setor> setores = new List<Setor>();
			foreach (var item in obj.Setores)
				setores.Add(new SetorRepository().ObterPorId(item.SetorId));
			obj.Setores = setores;

			base.Adicionar(obj);

			//adiciona telefone cadastrado na tela na tabela telefone
			foreach (var item in obj.Telefones)
				new TelefoneRepository().Adicionar(item);
		}
	}
}
