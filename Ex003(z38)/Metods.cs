using System.Text;
public class Metods
{
  // 1. Создание массива double

public static double []CreateArray (int size)
{
  return new double[size];
}

// 2. Заполнение массива рандомно double

public static void FillArray (double []NameArray, int min, int max)
{
  int index = 0;
  while (index < NameArray.Length)
  {
    NameArray[index] = new Random().Next(min, max) + new Random().NextDouble();
    index++;
  }
}


// 3. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}


// 4. Вывод массива double

public static void WriteArray (double []NameArray)
{
  int index = 0;
  while (index < NameArray.Length)
  {
  Console.Write(NameArray[index] + " ");
  index++;
  }
}
  // Нахождение максимального элемента double

  public static double MaxInArray(double[] NameArray)
  {
    double max = NameArray[0];
    for (int i = 0; i < NameArray.Length; i++)
    {
      if (max < NameArray[i]) max = NameArray[i];
    }
    return max;
  }

  // Нахождение минимального элемента double

  public static double MinInArray(double[] NameArray)
  {
    double min = NameArray[0];
    for (int i = 0; i < NameArray.Length; i++)
    {
      if (min > NameArray[i]) min = NameArray[i];
    }
    return min;
  }

// вывод разницы между максимальным и минимапльным элементом

public static void PrintMaxMinusMin(double max, double min)
{
  double result = max - min;
  Console.WriteLine(result);
}
}


 

 
