using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = 0.0;
            finalPosition = Position(gravity, fallingTime, initialVelocity, initialPosition);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
        static double Position(double grav,double falTime,double iniVel,double initPos)
        {
            double result;
            result = 0.5 * grav * (falTime * falTime) + iniVel * falTime + initPos;
            return  result ;
        }
    }

}
