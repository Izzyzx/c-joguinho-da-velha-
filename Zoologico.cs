using System;
using System.Collections.Generic;

public interface IAnimal
{
	void EmitirSom ();
	
}
 public abstract class Animal : IAnimal
 {
 private string nome;
 private string tipo;
 
 public Animal(string nome, string tipo)
 {
 this.nome = nome;
 this.tipo = tipo;
 }
  public string GetNome()
  {
  return nome;
  }
  
  public string GetTipo()
  {
  return tipo;
  }
 
 public abstract void EmitirSom();
 }
 public class Cachorro : Animal
 {
 public Cachorro(string nome) : base(nome, "Cachorro"){}
 public override void EmitirSom()
 {
 Console.WriteLine("Au Au!");
 	}
 
 }
 public class Gato : Animal
 {
 public Gato(string nome) : base(nome,"Gato"){}
 public override void EmitirSom()
 {
 Console.WriteLine("Miauu!");
 }
 }
 public class Leao : Animal
 {
 public Leao(string nome) : base(nome,"Leão"){}
 public override void EmitirSom()
 {
 Console.WriteLine("Rooaaar");
 }
 }
 
class Program
{
	static void Main(string[]args)
	{
		 Dictionary<string, Animal> animais = new Dictionary<string, Animal>()
		 {
			 {"cachorro", new Cachorro("Dog") },
			 {"gato", new Gato("Cat") },
			 {"leão", new Leao("Lion") }
		 };
		Console.WriteLine("Digite o tipo de animal:");
		string tipo = Console.ReadLine().ToLower();
		
		if(animais.ContainsKey(tipo))
		{
			animais[tipo].EmitirSom();
		}
		else
		{
			Console.WriteLine("Animal não cadastrado.");
		}
	}
}
