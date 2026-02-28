using System; //nos da chance de

const int CANTIDAD_ELEMENTOS = 10000;
Algoritmo ordenador = new Algoritmo();

// 1. Generar datos (Semilla 42 para que todos tengan el mismo desorden)
int[] datos = ordenador.GenerarNumeros(CANTIDAD_ELEMENTOS);

Console.WriteLine($"--- Auditoría de Algoritmos .NET 10 ---");
Console.WriteLine($"Procesando: {CANTIDAD_ELEMENTOS:N0} números.");

// 2. El alumno implementa esto en la clase Algoritmo
// Usar QuickSort por rendimiento. Si prefieres MergeSort o BubbleSort,
// cambia la llamada a ordenador.MergeSort(datos) o ordenador.BubbleSort(datos).
ordenador.QuickSort(datos);

// 3. Validación de integridad
if (ordenador.EstaOrdenado(datos))
{
    Console.WriteLine("VALIDATION: SUCCESS");
}
else
{
    Console.WriteLine("VALIDATION: FAILED");
    Environment.Exit(1); // Crucial para el Autograding de GitHub
}//

// La clase `Algoritmo` se implementa en el archivo `Algoritmo.cs`.
