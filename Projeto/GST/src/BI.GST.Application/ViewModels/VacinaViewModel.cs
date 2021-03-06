﻿using BI.GST.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Application.ViewModels
{
	public class VacinaViewModel
	{
		public int VacinaId { get; set; }

		[Required]
		[DisplayName("Funcionario")]
		public int FuncionarioId { get; set; }

		[Required]
		[DisplayName("Tipo Vacina")]
		public int TipoVacinaId { get; set; }

		[Required(ErrorMessage = "Prencher campo Data")]
		[MaxLength(150, ErrorMessage = "Máximo de 150")]
		[DisplayName("Data Realização")]
		public string Data { get; set; }

		public bool Renovado { get; set; }

		[ScaffoldColumn(false)]
		public bool Delete { get; set; }

		public virtual Funcionario Funcionario { get; set; }
		public virtual TipoVacina TipoVacina { get; set; }
	}
}
