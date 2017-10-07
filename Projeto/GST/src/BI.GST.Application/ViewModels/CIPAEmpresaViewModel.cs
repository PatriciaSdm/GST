﻿using BI.GST.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BI.GST.Application.ViewModels
{
    public class CIPAEmpresaViewModel
    {
        public CIPAEmpresaViewModel()
        {
            CIPAEmpresaFuncionarios = new List<CIPAEmpresaFuncionarioViewModel>();
        }

        public int CipaEmpresaID { get; set; }

        [Required(ErrorMessage = "Prencher Ano")]
        [DisplayName("Ano")]
        public int Ano { get; set; }

        [DisplayName("Número de Funcionários")]
        public int NumeroFuncionarios { get; set; }

        [Required(ErrorMessage = "Prencher campo Empresa")]
        [DisplayName("Empresa")]
        public int EmpresaId { get; set; }

        public virtual Empresa Empresa { get; set; }
        [DisplayName("Ativo")]
        public bool Delete { get; set; }

        public virtual List<CIPAEmpresaFuncionarioViewModel> CIPAEmpresaFuncionarios { get; set; }
    }
}
