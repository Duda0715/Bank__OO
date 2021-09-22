using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaMaria = new ContaCorrente("Maria", 1234, 100);
            contaDaBarbara.Conta = 789;

            ContaCorrente contaDoGui = new ContaCorrente("Gui", 1234, 120);
            ContaCorrente contaDoLucas = new ContaCorrente("Lucas", 1234, 150);

            contaDaBarbara.Sacar (100);
           
            Console.WriteLine("O número da conta da Maria é: " + contaDaMaria.Conta);
            Console.WriteLine("O saldo da conta da Maria é: " + contaDaMaria.Saldo);
            Console.WriteLine("O número da conta da Gui é: " + contaDoGui.Conta);
            Console.WriteLine("O saldo da conta do Gui é: " + contaDoGui.Saldo);
        }
    }
}
