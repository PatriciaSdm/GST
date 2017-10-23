﻿using BI.GST.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace BI.GST.Application.Interface
{
    public interface IFuncionarioAppService : IDisposable
    {
        IEnumerable<FuncionarioViewModel> ObterTodos();

        FuncionarioViewModel ObterPorId(int id);

        bool Adicionar(FuncionarioViewModel funcionarioViewModel);

        bool Atualizar(FuncionarioViewModel funcionarioViewModel);

        bool Excluir(int id);

        IEnumerable<FuncionarioViewModel> ObterGrid(int page, string pesquisa);

        int ObterTotalRegistros(string pesquisa);

        IEnumerable<FuncionarioViewModel> ObterPorEmpresa(int empresaId);
    }
}
