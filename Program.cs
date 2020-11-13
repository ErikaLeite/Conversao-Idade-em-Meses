using System;

namespace Conversao_Idade_em_Meses
{
    class Program
    {
        static void Main(string[] args)
        {
             //Faça um programa que receba a idade de uma pessoa em anos e exiba essa idade em: Meses, Dias, Horas e Minutos

           Console.WriteLine("Informe sua idade: ");
           int idade = int.Parse(Console.ReadLine()); 

           int meses = idade * 12;
           int dias = idade * 365;
           int horas = dias * 24;
           int minutos = horas * 60;

           System.Console.WriteLine("Idade em meses: "+meses);
           System.Console.WriteLine("Idade em dias: "+dias);
           System.Console.WriteLine("Idade em horas: "+horas);
           System.Console.WriteLine("Idade em minutos: "+minutos);

        
        }
    }
}
