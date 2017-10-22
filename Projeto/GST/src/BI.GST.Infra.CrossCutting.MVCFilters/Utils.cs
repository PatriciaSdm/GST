﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Infra.CrossCutting.MVCFilters
{
	public class Utils
	{
		public static bool VerificaVencimento(string DataRealizacao, int MesesValidade)
		{
			DateTime data = Convert.ToDateTime(DataRealizacao);

			if (data.AddMonths(MesesValidade).Date < DateTime.Now.Date)
			{
				//Vencido
				return true;
			}
			else
				//Não vencido
				return false;
		}

		public static DateTime ConverteStringToDate(string DataRealizacao)
		{
			return Convert.ToDateTime(DataRealizacao).Date;
		}
	}
}
