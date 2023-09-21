﻿
//Classe Pai que será herdada - SuperClasse
class Animal
{
    public string cor { get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
    }
}

//Classe Filhas que herdará da classe Animal
class Cachorro : Animal
{
    //Sobrescrevendo o método EmitirSom
    public override void EmitirSom()
    {
        Console.Write($"Cachorro da cor {cor} está latindo! Au au au");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.Write($"Gato da cor {cor} está miando! Miau miau");
    }

    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando!");
    }
}

class Program
{
    public static void Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();

        //meuCachorro.Ronronar();   //Não posso chamar este método pois não existe nessa classe
        Gato meuGato = new Gato();
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}