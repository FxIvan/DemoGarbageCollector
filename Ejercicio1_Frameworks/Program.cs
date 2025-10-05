using System;

class Program
{
    /*
        Al crear muchas instancias, la memoria utilizada aumenta.
        Luego de llamar a GC.Collect(), el GC elimina los objetos sin referencia y la memoria disponible disminuye.
     */
    static void Main()
    {
        // Mostrar memoria inicial
        Console.WriteLine("Memoria inicial: " + GC.GetTotalMemory(false) + " bytes");

        // Crear muchas instancias (objetos)
        for (int i = 0; i < 100000; i++)
        {
            var obj = new object();
        }

        // Mostrar memoria después de crear objetos
        Console.WriteLine("Memoria tras crear objetos: " + GC.GetTotalMemory(false) + " bytes");

        // Forzar recolección de basura
        GC.Collect();
        GC.WaitForPendingFinalizers();

        // Mostrar memoria después del GC
        Console.WriteLine("Memoria después del GC: " + GC.GetTotalMemory(false) + " bytes");

        Console.ReadKey();
    }
}