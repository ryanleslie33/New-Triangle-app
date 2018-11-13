using System;
using System.Collections.Generic;

namespace TriangleTracker{

public class Program{
  static void Main()
  {
    Console.WriteLine("enter the length of your first side of your triangle");
    string input = Console.ReadLine();
    int sideOne = int.Parse(input);

    Console.WriteLine("enter the length of your second side of your triangle");
    string input1 = Console.ReadLine();
    int sideTwo = int.Parse(input1);

    Console.WriteLine("enter the length of your third side of your triangle");
    string input2 = Console.ReadLine();
    int sideThree = int.Parse(input2);

    Triangle newTriangle = new Triangle(sideOne, sideTwo, sideThree);
    newTriangle.DefineTriangle(sideOne, sideTwo, sideThree);
  }
}
}
