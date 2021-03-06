﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BI.GST.Domain.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public int UFId { get; set; }

        public string Pais { get; set; }

        public string CEP { get; set; }

        public string Complemento { get; set; }

        public bool Delete { get; set; }


        public virtual UF UF { get; set; }
	}
}
