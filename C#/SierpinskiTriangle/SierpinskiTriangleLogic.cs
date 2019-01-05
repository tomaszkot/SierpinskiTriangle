using System;
using System.Collections.Generic;
using System.Drawing;

namespace SierpinskiTriangle
{
  /// <summary>
  /// Draws Sierpinski Triangle. Length of triangle side: 800px
  /// //based on https://en.wikipedia.org/wiki/Sierpinski_triangle
  //1. Take three points in a plane to form a triangle, you need not draw it.
  //2. Randomly select any point inside the triangle and consider that your current position.
  //3. Randomly select any one of the three vertex points.
  //4. Move half the distance from your current position to the selected vertex.
  //5. Plot the current position.
  //6. Repeat from step 3.
  /// </summary>
  class SierpinskiTriangleLogic
  {
    Point[] referencePoints;
    List<Point> allPoints = new List<Point>();
    Random rand;
    Point nextPt;
    const int TriangleSide = 800;

    public List<Point> AllPoints { get => allPoints; set => allPoints = value; }

    public SierpinskiTriangleLogic()
    {
      //1. Take three points in a plane to form a triangle, you need not draw it.
      referencePoints = new Point[] {
                new Point(0, TriangleSide),//left bottom corner of the triangle
                new Point(TriangleSide, TriangleSide),//right bottom corner of the triangle
                new Point(TriangleSide/2, TriangleSide-CalcTopPositionOfCVerticleInRightTriangle(TriangleSide/2, TriangleSide))
            };
      rand = new Random();


      //2.Randomly select any point inside the triangle and consider that your current position.
      nextPt = new Point(rand.Next(TriangleSide), rand.Next(TriangleSide));//gent random numbers in 0-TriangleSide limits
    }

    int CalcTopPositionOfCVerticleInRightTriangle(int RightTriangleSideALength, int RightTriangleSideSideCLength)
    {
      return (int)Math.Sqrt(Math.Pow(RightTriangleSideSideCLength, 2.0) - Math.Pow(RightTriangleSideALength, 2.0));
    }

    public void GeneratePointsSet(int setSize)
    {
      //3. Randomly select any one of the three vertex points.
      //4. Move half the distance from your current position to the selected vertex.
      //5. Plot the current position.
      //6. Repeat from step 3.
      for (int count = 0; count < setSize; count++)
      {
        int refPointIndex = rand.Next(3);//get a random reference point index
        nextPt.X = (nextPt.X + referencePoints[refPointIndex].X) / 2;
        nextPt.Y = (nextPt.Y + referencePoints[refPointIndex].Y) / 2;

        AllPoints.Add(nextPt);
      }
    }
  }
}
