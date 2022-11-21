using System.Collections;
using App13092022.Utils;

namespace App13092022.Algorithms; 

public class Two : Algorithm{

    public Two() : base("Segundo", "Crea un programa que lea el contenido de un fichero de texto, lo almacene línea por línea en un ArrayList, y luego pregunte de forma repetitiva al usuario qué texto desea buscar y muestre las líneas que contienen ese texto. Terminará cuando el usuario introduzca una cadena vacía.") {
    }

    protected override void Execute() {
        var lines = File.ReadAllLines(@"D:\Escritorio\Work\UCC\App13092022\Algorithms\file.txt");
        var list = new ArrayList(lines);

        while (true) {
            var search = InputUtils.GetText("Introduce el texto a buscar: ");
            if (string.IsNullOrEmpty(search))
                break;
            Console.WriteLine("");
            var found = false;
            foreach (var line in list) {
                if(!line.ToString()!.Contains(search))
                    continue;
                found = true;
                Console.WriteLine("Texto '"+search+"' en la linea: " + (list.IndexOf(line) + 1));
                Console.WriteLine("");
                Console.WriteLine(line);
                InputUtils.PressToContinue();
                break;
            }
            if(!found) {
                Console.WriteLine("No se ha encontrado el texto '"+search+"'");
            }
        }
    }
}