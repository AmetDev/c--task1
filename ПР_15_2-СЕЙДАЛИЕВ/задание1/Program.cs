using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_15_2_2ИСП_2_Сейдалиев1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементы массива:");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            HeapSort(arr);

            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }

        static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            // Построение кучи (перестановка элементов)
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Извлечение элементов из кучи по одному
            for (int i = n - 1; i >= 0; i--)
            {
                // Перемещение текущего корня в конец
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Вызов max heapify на уменьшенной куче
                Heapify(arr, i, 0);
            }
        }

        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;  // Инициализация наибольшего значения как корня
            int l = 2 * i + 1;  // left = 2*i + 1
            int r = 2 * i + 2;  // right = 2*i + 2

            // Если левый потомок больше корня
            if (l < n && arr[l] < arr[largest])
            {
                largest = l;
            }

            // Если правый потомок больше корня, чем наибольший до этого
            if (r < n && arr[r] < arr[largest])
            {
                largest = r;
            }

            // Если наибольшее значение не является корнем
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Рекурсивное построение кучи для поддерева
                Heapify(arr, n, largest);
            }
        }

    }
}
