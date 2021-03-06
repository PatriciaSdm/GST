﻿using BI.GST.Domain.Interface.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BI.GST.Domain.Entities;
using System.Linq.Expressions;
using BI.GST.Domain.Interface.IRepository;

namespace BI.GST.Domain.Services
{
    public class CipaQuadroService : ICipaQuadroService
    {
        private readonly ICipaQuadroRepository _cipaQuadroRepository;

        public CipaQuadroService(ICipaQuadroRepository cipaQuadroRepository)
        {
            _cipaQuadroRepository = cipaQuadroRepository;
        }

        public void Dispose()
        {
            _cipaQuadroRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public CipaQuadro obterCipaPorGrupo(int numeroFuncionarios, int grupoCipaID)
        {
            return _cipaQuadroRepository.ObterCipaPorGrupo(numeroFuncionarios, grupoCipaID);
        }

        public CipaQuadro ObterPorId(int id)
        {
            return _cipaQuadroRepository.ObterPorId(id);
        }

        public IEnumerable<CipaQuadro> ObterTodos()
        {
            return _cipaQuadroRepository.ObterTodos();
        }
    }
}
