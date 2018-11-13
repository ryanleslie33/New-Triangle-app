using System;
namespace TriangleTracker
{
 class Triangle{

   public int sideOne;
   public int sideTwo;
   public int sideThree;

   public Triangle(int sideOnes, int sideTwos, int sideThrees)
   {
     sideOne = sideOnes;
     sideTwo = sideTwos;
     sideThree = sideThrees;
   }

   public  void DefineTriangle(int sideOne, int sideTwo, int sideThree)
   {
     if ( sideOne > sideTwo + sideThree || sideTwo > sideOne + sideThree || sideThree > sideOne + sideTwo)
     {
       Console.WriteLine("this does not make a triangle");
     }else if(sideOne == sideTwo && sideTwo == sideThree)
     {
       Console.WriteLine("The given triangle is Equilateral");
     } else if (sideOne == sideTwo || sideTwo == sideThree || sideThree == sideOne)
     {
       Console.WriteLine("The given triangle is Isoceles");
     } else if (sideOne != sideTwo || sideTwo != sideThree || sideThree != sideOne)
     {
       Console.WriteLine("The given triangle is scalene");
     }
   }
 }
}
