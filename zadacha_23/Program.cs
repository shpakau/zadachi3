// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Задача 23");
Console.Write("Введите число из условия задачи: ");
int kyb = Convert.ToInt32(Console.ReadLine());

void KybNumber(int[] kyb)
{
  int counter = 0;
  int length = kyb.Length;
  while (counter <  length)
  {
    kyb[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[kyb+1];
KybNumber(arry);
PrintArry(arry);