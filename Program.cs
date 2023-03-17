// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Globalization;
using System.Net.Http.Headers;
using Manipulando_Arquivos.Entities;

Console.Write("Enter file full path: ");
string sourceFilePath = Console.ReadLine();

//
//string targetPath = @"C:\Users\style\OneDrive\Documentos\out\summary.csv";
try {
    //Ler todas as linhas do ARQUIVO
    string [] lines = File.ReadAllLines(sourceFilePath);
    
    string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
    string targetFolderPath = sourceFolderPath + @"\out";
    string targetFilePath = targetFolderPath + @"\summary.csv";


    Directory.CreateDirectory(targetFolderPath);

    using (StreamWriter sw = File.AppendText(targetFilePath)) {
        foreach (string line in lines) {
            string[] fields = line.Split(',');
            string name = fields[0];
            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
            int qt = int.Parse(fields[2]);

            Product prod = new Product(name, price, qt);

            sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
        }
    }

} catch (IOException e) {
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);
}