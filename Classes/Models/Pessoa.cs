using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Pessoa
    {
        private string Nome;
        private int Idade;
        public Pessoa(){}
        public Pessoa(string nome, int idade){
            this.Nome = nome;
            this.Idade = idade;
        }
        public void SetNome(string nome){
            if(nome == ""){ throw new ArgumentException("O nome não pode ser vázio"); }
            this.Nome = nome;
        }
        public string GetNome(){
            return this.Nome;
        }
        public void SetIdade(int idade){
            if(idade < 0){ throw new ArgumentException("A idade não pode ser negativa"); }
            this.Idade = idade;
        }
        public int GetIdade(){
            return this.Idade;
        }
        public void Apresentar(){
            Console.WriteLine($"Nome: {this.Nome}, Idade: {this.Idade}");
        }
    }
}