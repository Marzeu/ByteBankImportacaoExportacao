﻿using ByteBankImportacaoExportacao.Modelos;
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
            CriarArquivoComWriter();
            Console.WriteLine("Arquivo gravado com sucesso, finalizando aplicação...");

            Console.ReadLine();
        }
    }
}
