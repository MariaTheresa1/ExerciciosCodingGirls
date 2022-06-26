using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    /****** Aula 09 - Polimorfismo e Modificadores Virtual, Override e Abstract ******/
    // 3. Veículos
    public abstract class Veiculos
    {
        public abstract void Acelerar();
        public abstract void Freiar();
    }
    internal class Carro : Veiculos
    {
        public Carro()
        {
            Acelerar();
            Freiar();
            TrocarOleo();
        }
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando o carro...");
        }
        public override void Freiar()
        {
            Console.WriteLine("Freiando o carro...");
        }
        public void TrocarOleo()
        {
            Console.WriteLine("O óleo do carro foi trocado.");
        }
    }
    internal class Bicicleta : Veiculos
    {
        public Bicicleta()
        {
            Acelerar();
            Freiar();
            AjustarCorreia();
        }
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando a bicicleta...");
        }
        public override void Freiar()
        {
            Console.WriteLine("Freiando a bicicleta...");
        }
        public void AjustarCorreia()
        {
            Console.WriteLine("A correia da bicicleta foi ajustada.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Bicicleta bicicleta = new Bicicleta();

            Console.ReadLine();
        }
    }
}
