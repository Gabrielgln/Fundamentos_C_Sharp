using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Animal
    {
        public Animal(){}
        public Animal(string nome, int idade, string raca){
            this.Nome = nome;
            this.Idade = idade;
            this.Raca = raca;
        }
        private string _nome;
        private int _idade;
        public string Nome{
            get => _nome.ToUpper();

            set{
                if(value == ""){ throw new ArgumentException("O nome não pode ser vázio"); }
                _nome = value;
            }
        }
        public string Raca { get; set; }
        public string RacaIdade => $"Raça: {Raca}, Idade: {Idade}";
        public int Idade{
            get => _idade;

            set{
                if(value < 0){ throw new ArgumentException("A idade não pode ser negativa"); }
                _idade = value;
            }
        }
        public void Apresentar(){
            Console.WriteLine($"Nome do animal: {this.Nome}, {RacaIdade}");
        }
    }
}