using System.Collections;
using App13092022.Utils;

namespace App13092022.Algorithms; 

public class Four :Algorithm {

    public Four() : base("Cuarto", "Crea un programa que lea el contenido de un fichero de texto, lo almacene línea por línea en un ArrayList, luego muestre en pantalla las líneas impares (primera, tercera, etc.) y finalmente vuelque a otro fichero de texto las líneas pares (segunda, cuarta, etc.)."){ }

    protected override void Execute() {
        var lines = File.ReadAllLines(@"D:\Escritorio\Work\UCC\App13092022\Algorithms\file.txt");
        var list = new ArrayList(lines);
        
        for (var i = 0; i < list.Count; i++) {
            if (i % 2 == 0) {
                Console.WriteLine(list[i]);
            }
        }
        
        for (var i = 0; i < list.Count; i++) {
            if (i % 2 != 0) {
                File.AppendAllText(@"D:\Escritorio\Work\UCC\App13092022\Algorithms\output.txt", list[i] + Environment.NewLine);
            }
        }
    }
}