using System;
    class Carro
{
    public void Acelerar()
    {
        Console.WriteLine("O carro está acelerando");
    }

}
class Moto:Carro
    {
    public void Frenar()
    {
        Console.WriteLine("A moto está freando");

    }

}
class Program
{
    static void Main()
    {
        Moto moto = new Moto();
        moto.Acelerar();
        moto.Frenar();
    }
}
