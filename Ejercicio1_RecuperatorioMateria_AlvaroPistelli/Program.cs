using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Ejercicio1_RecuperatorioMateria_AlvaroPistelli
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream miArchivo = new FileStream(@".\archivo.txt", FileMode.Append, FileAccess.Write);

            FileStream backup = new FileStream(@".\archivo.fecha.bak", FileMode.Append, FileAccess.Write);

            StreamWriter archivo = new StreamWriter(miArchivo);

            StreamWriter backuparchivo = new StreamWriter(backup);

            Console.WriteLine("Ingrese el texto que desea agregar al archivo");

            string texto = Console.ReadLine().ToString();

            archivo.WriteLine(texto);

            archivo.Close();

            backuparchivo.WriteLine(texto);

            backuparchivo.Close();


        }
    }
}