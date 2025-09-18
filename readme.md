# Light Sensor Reader

This is a simple .NET console application that reads data from the ambient light sensor on a Windows device and displays the illuminance in lux.

## Features

-   Detects if a default ambient light sensor is present on the system.
-   Polls the sensor every second to get the current light intensity reading.
-   Prints the light intensity (in lux) to the console.

## Requirements

-   A Windows device with an ambient light sensor.
-   .NET 9 or later.
-   Windows SDK.

## How to Use


1.  Run the following command to build and start the application:

    ```bash
    dotnet run
    ```

2.  Once the application starts, it will begin printing the current light intensity reading to the console every second.

    ```
    Light intensity: 500.0 lux
    Light intensity: 502.5 lux
    ...
    ```

## Code Overview

The core logic of the application is in the `Program.cs` file. It uses the `LightSensor` class from the `Windows.Devices.Sensors` namespace to interact with the hardware.
