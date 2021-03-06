﻿using AutoMapper;
using BI.GST.Application.Interface;
using BI.GST.Application.ViewModels;
using BI.GST.Domain.Interface.IService;
using BI.GST.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BI.GST.Application.AppService
{
    public class CertificadoAppService : BaseAppService, ICertificadoAppService
    {
        private readonly ICertificadoService _certificadoService;

        public CertificadoAppService(ICertificadoService certificadoService)
        {
            _certificadoService = certificadoService;
        }
        public bool Adicionar(CertificadoViewModel certificadoViewModel)
        {
            var certificado = Mapper.Map<CertificadoViewModel, Certificado>(certificadoViewModel);

            BeginTransaction();
            _certificadoService.Adicionar(certificado);
            Commit();
            return true;
        }


        public bool Atualizar(CertificadoViewModel cursoViewModel)
        {
            var Curso = Mapper.Map<CertificadoViewModel, Certificado>(cursoViewModel);

            BeginTransaction();
            _certificadoService.Atualizar(Curso);
            Commit();
            return true;
        }


        public void Dispose()
        {
            _certificadoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Excluir(int id)
        {
            bool existente = _certificadoService.Find(e => e.CursoId == id).Any();
            if (existente)
            {
                BeginTransaction();
                var tipoCurso = _certificadoService.ObterPorId(id);
                tipoCurso.Delete = true;
                _certificadoService.Atualizar(tipoCurso);
                Commit();
                return true;
            }
            return false;
        }

        public IEnumerable<CertificadoViewModel> ObterGrid(int page, string pesquisa)
        {
            return Mapper.Map<IEnumerable<Certificado>, IEnumerable<CertificadoViewModel>>(_certificadoService.ObterGrid(page, pesquisa));
        }

        public CertificadoViewModel ObterPorId(int id)
        {
            return Mapper.Map<Certificado, CertificadoViewModel>(_certificadoService.ObterPorId(id));
        }

        public IEnumerable<CertificadoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Certificado>, IEnumerable<CertificadoViewModel>>(_certificadoService.ObterTodos());
        }

        public int ObterTotalRegistros(string pesquisa)
        {
            return _certificadoService.ObterTotalRegistros(pesquisa);
        }
    }
}
