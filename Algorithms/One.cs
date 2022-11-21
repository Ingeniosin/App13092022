using System.Collections;
using App13092022.Utils;

namespace App13092022.Algorithms;

public class One : Algorithm {

    public One() : base("Primero", "Crea un programa que lea el contenido de un fichero de texto, lo almacene línea por línea en un ArrayList, y luego pregunte de forma repetitiva al usuario qué línea desea ver. Terminará cuando el usuario introduzca '-1'") {
    }

    protected override void Execute() {
        var lines = File.ReadAllLines(@"D:\Escritorio\Work\UCC\App13092022\Algorithms\file.txt");
        var list = new ArrayList(lines);

        var line = 0;
        while (line != -1) {
            line = InputUtils.GetNumber("Introduce el número de línea que quieres ver (-1 para salir)");
            if (line != -1) 
                Console.WriteLine(list[line - 1]);
        }


    }
}