// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
using static Metods;
public class Ex002
{
public static void ex002_z36()
{
// создание массива
int[] array = CreateArray(Input("Введите размер масива: "));
// заполнение массива рандомно
FillArrayRandom(array);
// вывод созданного массива
WriteArray(array);
// подсчет и вывод элементов, стоящих на нечётных позициях.
SummNumberNechotPosInArray(array);
}
}