using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {


            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.ReadLine();

            Console.WriteLine("Digite o seu nome:");
            var nome = Console.ReadLine();

            Console.WriteLine(nome);

            UsarStreamDeEntrada();
            Console.WriteLine("Finalizando aplicação...");

            Console.ReadLine();
        }
    }
}
