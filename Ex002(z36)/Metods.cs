using System.Text;
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}

// 2. Заполнение массива рандомно

public static void FillArrayRandom (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
    NameArray[index] = Rundom(-1000, 1000);
    index++;
  }
}

// 3. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}


// 3.2 ввод данных рандомно

public static int Rundom (int min, int max)
{
  int result = 0;
  result = new Random().Next(min, max);
  return result;
}


// 4. Вывод массива

public static void WriteArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
  Console.Write(NameArray[index] + " ");
  index++;
  }
}

// подсчет и вывод нечетных чисел в массиве
public static void SummNumberInArray (int [] Array)
{
  int summ = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] % 2 == 1)
    {
      summ = summ + 1;
    }
  }
  Console.WriteLine();
  Console.WriteLine(summ);
}
// подсчет и вывод стоящих на нечётных позициях.
public static void SummNumberNechotPosInArray (int [] Array)
{
  int summ = 0;
  for (int i = 1; i < Array.Length; i=i+2)
  {
    summ = summ + Array[i];
  }
  Console.WriteLine();
  Console.WriteLine(summ);
}
}


 

 
