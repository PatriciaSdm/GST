﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Application.ViewModels
{
    public class TipoSetorViewModel
    {
        public int TipoSetorId { get; set; }

        [Required]
        [DisplayName("Nome do Tipo Setor")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Prencher campo Descrição")]
        [MaxLength(200, ErrorMessage = "Máximo de 200")]
        public string Descricao { get; set; }

        public bool Delete { get; set; }
    }
}
