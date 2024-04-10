using System;

public class Plane : Carrier
{
 
    public Plane(double time, double cost) : base(time, cost) { }


    public override void CalculateCostTime(string startCity, string endCity, double distance)
    {
        double time = distance / TransportTime;
        double cost = distance * TransportCost;

        Console.WriteLine($"Traveling from {startCity} to {endCity} by plane:");
       
        Console.WriteLine($"Time: {time} hours");
    
        Console.WriteLine($"Cost: {cost} $");
    }

  

}
