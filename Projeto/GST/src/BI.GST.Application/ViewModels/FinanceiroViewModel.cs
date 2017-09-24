﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BI.GST.Application.ViewModels
{
    public class FinanceiroViewModel
    {
        public int FinanceiroId { get; set; }

        [Required(ErrorMessage = "Prencher campo Título")]
        [MaxLength(50, ErrorMessage = "Máximo de 50")]
        [DisplayName("Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Prencher Operação do título")]
        [DisplayName("Operação")]
        public int Operacao { get; set; }

        // [Required(ErrorMessage = "Prencher Data do título")]
        [DisplayName("Data da Operação")]
        public string DataOperacao { get; set; }

        //validar para preencher o numero de parcelas
        [Required(ErrorMessage = "Prencher o Número de parcelas do título")]
        [DisplayName("Número de parcelas")]
        public int NumeroParcelas { get; set; }

        // [Required(ErrorMessage = "Preencher a Data de Vencimento do título")]
        [DisplayName("Data de Vencimento")]
        public string DataVencimento { get; set; }

        //validar para preencher o valor maior que zero
        [Required(ErrorMessage = "Prencher o Valor do título")]
        [DisplayName("Valor")]
        public double Valor { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Data Quitação")]
        public string DataQuitacao { get; set; }

        [DisplayName("Instituição")]
        public string Instituicao { get; set; }

        [ScaffoldColumn(false)]
        public bool Delete { get; set; }
    }
}