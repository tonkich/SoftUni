using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileName.GetFileExtension("example"));
            Console.WriteLine(FileName.GetFileExtension("example.pdf"));
            Console.WriteLine(FileName.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileName.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileName.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileName.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                DistanceIn2Dand3DSpace.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                DistanceIn2Dand3DSpace.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            GeometricCalculations.Width = 3;
            GeometricCalculations.Height = 4;
            GeometricCalculations.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", GeometricCalculations.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", GeometricCalculations.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", GeometricCalculations.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", GeometricCalculations.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", GeometricCalculations.CalculateDiagonalYZ());
        }
    }
}
