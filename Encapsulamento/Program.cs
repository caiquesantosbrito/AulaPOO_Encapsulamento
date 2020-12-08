using System;
using Encapsulamento.Classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            m.NomeTitular = "Caique Santos Brito";
            m.Numero = "23112003";
            m.Bandeira = "Visa";

            Console.WriteLine($"O Titular {m.NomeTitular} - Tem o Token: {m.Token} - e sua Bandeira é : {m.Bandeira}");
        }
    }
}
