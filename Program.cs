using System;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace arquivocsv
{
    class Program
    {
        static void Main(string[] args)
        {
            Application ex = new Application();
            ex.Visible = true;
            ex.Workbooks.Add();

            /*
            string nome,email;
            int idade;
            
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o seu e-mail: ");
            email = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            idade = Int16.Parse(Console.ReadLine()); */

            // FileInfo fi = new FileInfo("dados_cabecalho.csv");
            
            // StreamWriter arquivo; // estou tipando o "arquivo" como bloco de notas/alguém em que posso escrever.
            
            // if(fi.Exists){ //if(!fi.Exists) - ! = negação || if(fi.Exists==false)
            // arquivo = new StreamWriter("dados_cabecalho.csv",true);
            // arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            // }
            // else{
            // arquivo = new StreamWriter("dados_cabecalho.csv",true);
            // arquivo.WriteLine("Nome;E-mail;Idade;Data de cadastro");
            // arquivo.WriteLine(nome+";"+email+";"+idade+";"+DateTime.Now.ToShortDateString());
            // }
            // arquivo.Close();


        }
    }
}
