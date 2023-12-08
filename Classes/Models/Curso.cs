using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Pessoas { get; set; }
        public Curso(){
            this.Pessoas = new List<Pessoa>();
        }
        public Curso(string nome){
            this.Nome = nome;
            this.Pessoas = new List<Pessoa>();
        }

        public void AdicionarPessoa(Pessoa pessoa){
            Pessoas.Add(pessoa);
        }
        public void RemoverPessoa(Pessoa pessoa){
            Pessoas.Remove(pessoa);
        }
        public int ObterQuantidadeDeAlunosMatriculados(){
            return Pessoas.Count;
        }
        public void ListarPessoas(){
            Console.WriteLine($"Pessoas do curso de {Nome}:");
            foreach(Pessoa pessoa in Pessoas){
                Console.WriteLine($"Nome: {pessoa.GetNome()}");
            }
        }
    }
}