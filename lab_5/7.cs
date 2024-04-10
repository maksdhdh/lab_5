public abstract class Carrier
{

    protected double TransportTime { get; set; }
    protected double TransportCost { get; set; }


    public Carrier(double time, double cost)
    {
        TransportTime = time;
        TransportCost = cost;
    }


    public abstract void CalculateCostTime(string startCity, string endCity, double distance);

}


