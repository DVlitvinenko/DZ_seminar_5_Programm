using static Metods;
public class ex001
{
  public static void ex001_z34()
  {
// создание массива
int[] array = CreateArray(Input("Введите размер масива: "));
// заполнение массива рандомно
FillArrayRandom(array);
// вывод созданного массива
WriteArray(array);
// подсчет и вывод четных чисел в массиве
SummNumberInArray(array);
}
}