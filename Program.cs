using System;
using System.Threading;
using Windows.Devices.Sensors;

class Program
{
    static void Main()
    {
        var sensor = LightSensor.GetDefault();
        if (sensor == null)
        {
            Console.WriteLine("Ambient light sensor not found");
            return;
        }

        while (true)
        {
            var reading = sensor.GetCurrentReading();
            Console.WriteLine($"Light intensity: {reading.IlluminanceInLux} lux");
            Thread.Sleep(1000);
        }
    }
}
