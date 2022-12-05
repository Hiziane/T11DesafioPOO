 using exerc01.Models;

 Cachorro c = new Cachorro();
 Console.WriteLine("\n");
 c.Raca="Pastor Alemão";
 c.Tamanho = "Grande";
 c.ExibirDados();
 c.EmitirSom();

Gato g = new Gato();
Console.WriteLine("\n");
g.Raca = "Siamês";
g.Tamanho = "Mediano";
g.ExibirDados();
g.EmitirSom();

Passaro p =new Passaro();
Console.WriteLine("\n");
p.Raca="Bem-te-vi";
p.Tamanho="Pequeno";
p.ExibirDados();
p.EmitirSom();
Console.WriteLine("\n");