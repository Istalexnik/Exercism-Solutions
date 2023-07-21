using System;
using System.Data;
using System.Runtime.CompilerServices;

class RemoteControlCar
{
    private int metters = 0;
    private int battery = 100;
    private int speed;
    private int drain;

    public RemoteControlCar(int speed, int drain)
    {
        this.speed = speed;
        this.drain = drain;
    }

    public bool BatteryDrained()
    {
        return battery < drain;
    }

    public int DistanceDriven()
    {
        return metters;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            metters += speed;
            battery -= drain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();

            if (car.DistanceDriven() >= distance)
            {
                return true;
            }
        }

        return false;
    }
}
