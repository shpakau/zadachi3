// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21");
int x1 = Coordinaty("X", "A");
int y1 = Coordinaty("Y", "A");
int z1 = Coordinaty("Z", "A");
int x2 = Coordinaty("X", "B");
int y2 = Coordinaty("Y", "B");
int z2 = Coordinaty("Z", "B");

int Coordinaty(string coordinatyName, string dotName)
{
    Console.Write($"Введите координаты {coordinatyName} точки {dotName} из условия задачи: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );
Console.WriteLine($"Расстояние между точками: {segmentLength}");