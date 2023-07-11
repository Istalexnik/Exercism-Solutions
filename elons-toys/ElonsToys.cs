using System;

class RemoteControlCar
{
    int distance;
    int batteryLevel = 100;

    public static RemoteControlCar Buy()
    {
       return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        return batteryLevel == 0 ? "Battery empty" : $"Battery at {batteryLevel}%";
    }

    public void Drive()
    {
        if (distance != 2000) {
            batteryLevel -= 1;
            distance += 20;
        }


    }
}
