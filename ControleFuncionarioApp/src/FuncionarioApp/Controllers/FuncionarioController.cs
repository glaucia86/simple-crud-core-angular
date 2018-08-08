using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FuncionarioApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuncionarioApp.Controllers
{ 
    [Route("api/[controller]")]
    public class FuncionarioController : Controller
    {
        FuncionarioDAL _funcionario = new FuncionarioDAL();

        [HttpGet]
        [Route("api/Funcionario/Index")]
        public IEnumerable<Funcionario> Index()
        {
            return _funcionario.ObterTodosFuncionarios();
        }

        [HttpPost]
        [Route("api/Funcionario/Adicionar")]
        public int AdicionarFuncionario([FromBody]Funcionario funcionario)
        {
            return _funcionario.AdicionarFuncionario(funcionario);
        }

        [HttpGet]
        [Route("api/Funcionario/Retornar/{id}")]
        public Funcionario ObterFuncionarioPorId(int funcionarioId)
        {
            return _funcionario.ObterFuncionarioPorId(funcionarioId);
        }

        [HttpPut("api/Funcionario/Atualizar")]
        public int AtualizarFuncionario([FromBody]Funcionario funcionario)
        {
            return _funcionario.AtualizarFuncionario(funcionario);
        }

        [HttpDelete("api/Funcionario/Excluir/{id}")]
        public int ExcluirFuncionario(Funcionario funcionarioId)
        {
            return _funcionario.ExcluirFuncionario(funcionarioId);
        }

        [HttpGet]
        [Route("api/Funcionario/RetornarListaCidades")]
        public IEnumerable<Cidades> RetornarCidades()
        {
            return _funcionario.RetornarCidades();
        }
    }
}
