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

    // Nota: La versión educativa de BubbleSort fue retirada. Use QuickSort para eficiencia.

    // QuickSort público: ordenamiento in-place, promedio O(n log n)
    public void QuickSort(int[] arr)
    {
        if (arr == null || arr.Length < 2) return;
        QuickSortInPlace(arr, 0, arr.Length - 1);
    }

    private void QuickSortInPlace(int[] arr, int left, int right)
    {
        while (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            // Recurrir en la partición más pequeña para limitar la profundidad de pila
            if (pivotIndex - left < right - pivotIndex)
            {
                QuickSortInPlace(arr, left, pivotIndex - 1);
                left = pivotIndex + 1;
            }
            else
            {
                QuickSortInPlace(arr, pivotIndex + 1, right);
                right = pivotIndex - 1;
            }
        }
    }

    private int Partition(int[] arr, int left, int right)
    {
        // Mediana de tres para elegir pivote
        int mid = left + ((right - left) >> 1);
        int pivotIndex = MedianOfThree(arr, left, mid, right);
        int pivotValue = arr[pivotIndex];
        // mover pivote al final
        Swap(arr, pivotIndex, right);
        int store = left;
        for (int i = left; i < right; i++)
        {
            if (arr[i] < pivotValue)
            {
                Swap(arr, i, store);
                store++;
            }
        }
        Swap(arr, store, right);
        return store;
    }

    private int MedianOfThree(int[] arr, int a, int b, int c)
    {
        int va = arr[a], vb = arr[b], vc = arr[c];
        if (va < vb)
        {
            if (vb < vc) return b;
            return va < vc ? c : a;
        }
        else
        {
            if (va < vc) return a;
            return vb < vc ? c : b;
        }
    }

    private void Swap(int[] arr, int i, int j)
    {
        if (i == j) return;
        int t = arr[i]; arr[i] = arr[j]; arr[j] = t;
    }

    // MergeSort retirado; QuickSort es la implementación activa para ordenamiento eficiente.
}
