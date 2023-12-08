using Classes.Models;

Animal a1 = new Animal();
a1.Nome = "Gato";
a1.Raca = "Viralata";
a1.Idade = 1;
a1.Apresentar();

Animal a2 = new Animal(nome:"Cachorro", idade:2, raca:"Viralata");
a2.Apresentar();

Pessoa p1 = new Pessoa();
p1.SetNome("Gabriel");
p1.SetIdade(20);
p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Verônica", idade: 90);
p2.Apresentar();

Curso c1 = new Curso("Português");
c1.AdicionarPessoa(p1);
c1.AdicionarPessoa(p2);
Console.WriteLine(c1.ObterQuantidadeDeAlunosMatriculados());
c1.ListarPessoas();
