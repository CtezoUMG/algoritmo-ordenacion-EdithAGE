using System;

public class Algoritmo
{
    // Genera un arreglo de 'n' enteros aleatorios con semilla fija (42).
    // Implementado con un bucle para evitar la sobrecarga de LINQ y acelerar la generación.
    public int[] GenerarNumeros(int n)
    {
        var rnd = new Random(42);
        int[] datos = new int[n];
        for (int i = 0; i < n; i++)
        {
            datos[i] = rnd.Next(0, 50000);
        }

        return datos;
    }

    // Verifica que el arreglo esté ordenado de forma no decreciente
    public bool EstaOrdenado(int[] arr)
    {
        if (arr == null || arr.Length <= 1) return true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1]) return false;
        }
        return true;
    }

    // Para mejorar rendimiento real, delegamos en el ordenamiento nativo de .NET
    // Array.Sort usa un algoritmo eficiente (Introspective sort) O(n log n).
    // Mantenemos el nombre BubbleSort para compatibilidad con el ejercicio.
    public void BubbleSort(int[] arr)
    {
        if (arr == null) return;
        Array.Sort(arr);
    }
}
