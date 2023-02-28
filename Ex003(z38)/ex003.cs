// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементом массива.
// [3 7 22 2 78] -> 76
using static Metods;
public class ex003
{
  public static void ex003_z38()
  {
    // Создание массива
    double [] array = CreateArray(Input("Введите размер массива: "));
    // Заполнение массива вещественными числами рандомно
    FillArray(array, -1000, 1000);
    // Вывод полученного массива
    WriteArray(array);
    // Нахождение максимального элемента
    double max = MaxInArray(array);
    Console.WriteLine(max);
    // Нахождение минимального элемента
    double min = MinInArray(array);
    Console.WriteLine(min);
    // вывод разницы между максимальным и минимапльным элементом
    PrintMaxMinusMin(MaxInArray(array), MinInArray(array));
  }
}