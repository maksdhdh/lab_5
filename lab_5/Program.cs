using System;

class Program
{


    static void Main(string[] args)
    {

        double distance = 500; 

        Carrier plane = new Plane(800, 5); 
        plane.CalculateCostTime("Kyiv", "Lviv", distance);

        Carrier train = new Train(120, 1.5); 
        train.CalculateCostTime("Kyiv", "Lviv", distance);

        Carrier automobile = new Automobile(60, 3); 
        automobile.CalculateCostTime("Kyiv", "Lviv", distance);

        Carrier bus = new Bus(50, 2); 
        bus.CalculateCostTime("Kyiv", "Lviv", distance);

        Carrier trolleybus = new Trolleybus(40, 1.5); 
        trolleybus.CalculateCostTime("Kyiv", "Lviv", distance);

        Carrier passengerCarrier = new PassengerCarrier(70, 4); 
        passengerCarrier.CalculateCostTime("Kyiv", "Lviv", distance);

  
    }



}
