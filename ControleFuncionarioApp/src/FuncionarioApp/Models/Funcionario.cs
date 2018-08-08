using System;
using System.Collections.Generic;

namespace FuncionarioApp.Models
{
    public partial class Funcionario
    {
        public int FuncionarioId { get; set; }

        public string Nome { get; set; }

        public string Cidade { get; set; }

        public string Departamento { get; set; }

        public string Genero { get; set; }
    }
}
