using System.Collections;
using App13092022.Utils;

namespace App13092022.Algorithms; 

public class Tree :Algorithm {

    public Tree() : base("Tercero", "Crea un programa que lea el contenido de un fichero de texto, lo almacene línea por línea en un ArrayList, lo ordene y lo muestre ordenado en pantalla.") {
    }

    protected override void Execute() {
        
        var lines = File.ReadAllLines(@"D:\Escritorio\Work\UCC\App13092022\Algorithms\file.txt");
        var list = new ArrayList(lines);
        
        list.Sort();
        
        foreach (var line in list) {
            Console.WriteLine(line);
        }
        
        
        
        
        
        
        
    }
}