using exer02.Models;

// Autores a = new Autores();
// a.email = "juca@gmail.com";
// Console.WriteLine($"email: {a.email}");
// Livro l =new Livro();

// l.NomeLivro = "Harry Potter";
// Console.WriteLine($"Livro : {l.NomeLivro}");
// List<String> listaAutores = new List<string>();
// listaAutores.Add("Juca");
// listaAutores.Add("Maria");
// listaAutores.Add("João");
// listaAutores.Add("Mari");
// listaAutores.Add("Elly");

// for (Int32 i=0; i<listaAutores.Count; ++i)
// {
//     Console.WriteLine("Autor: "+listaAutores[i]);
// }
// Console.WriteLine("\n");

List<Autores> listaAutores = new List<Autores>();
listaAutores.Add(new Autores { email = "teste@teste.com" });
listaAutores.Add(new Autores { email = "teste2@tste.com" });

Livro l = new Livro();
l.NomeLivro = "Harry Potter";
l.Autores = listaAutores;

Console.WriteLine($"Livro: {l.NomeLivro}");
Console.WriteLine($"Autores:");
l.Autores.ForEach(x => Console.WriteLine(x.email));
