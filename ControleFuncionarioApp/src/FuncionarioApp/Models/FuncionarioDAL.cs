using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FuncionarioApp.Models
{
    public class FuncionarioDAL
    {
        FuncionarioDBContext db = new FuncionarioDBContext();

        // Método para Retornar Todos os Funcionários (SELECTALL)
        public IEnumerable<Funcionario> ObterTodosFuncionarios()
        {
            try
            {
                return db.Funcionario.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao retornar os Funcionários " + ex.Message);
                throw;
            }
        }

        // Método para Criar um Novo Funcionário (CREATE)
        public int AdicionarFuncionario(Funcionario funcionario)
        {
            try
            {
                db.Funcionario.Add(funcionario);
                db.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Adicionar Funcionário " + ex.Message);
                throw;
            }
        }

        // Método para Retornar Funcionário por ID (GETBYID)
        public Funcionario ObterFuncionarioPorId(int funcionarioId)
        {
            try
            {
                var funcionario = db.Funcionario.Find(funcionarioId);

                return funcionario;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Selecionar o Funcionário Por Id " + ex.Message);
                throw;
            }
        }

        // Método para Atualizar Funcionário (UPDATE)
        public int AtualizarFuncionario(Funcionario funcionario)
        {
            try
            {
                db.Entry(funcionario).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar o Funcionário " + ex.Message);
                throw;
            }
        }

        // Método para Excluir Funcionário (DELETE)
        public int ExcluirFuncionario(Funcionario funcionarioId)
        {
            try
            {
                var funcionario = db.Funcionario.Find(funcionarioId);
                db.Funcionario.Remove(funcionario);
                db.SaveChanges();

                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Excluir Funcionário " + ex.Message);
                throw;
            }
        }

        // Método para Retornar todas as Cidades(SELECT ALL)
        public List<Cidades> RetornarCidades()
        {
            try
            {
                // Select * from db.Cidades
                var listarCidades = (from listaCidades in db.Cidades select listaCidades).ToList();

                return listarCidades;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao Selecionar Todas as Cidades " + ex.Message);
                throw;
            }
        }
    }
}
