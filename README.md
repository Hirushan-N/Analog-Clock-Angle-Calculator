# Analog Clock Angle Calculator

This is a C# console application that calculates the lesser angle between the hour and minute hands of a clock based on user input of the hour and minute.

The user is prompted to enter the hour (1-12) and minute (0-59) using the `Console.Write` and `Console.ReadLine` methods. The input is validated to ensure that the values are within the valid range.

If the input is valid, the hour angle and minute angle are calculated using following way

## Certainly! The calculation to find the lesser angle between the hour and minute hands of an analog clock is a bit tricky, but it can be broken down into a few steps

### 01)Calculate the hour angle
The hour hand of an analog clock moves 30 degrees in 1 hour, or 0.5 degrees per minute. However, the hour hand also moves a fraction of a degree based on the position of the minute hand. To account for this, we need to calculate the fractional hour value by taking the remainder of the hour divided by 12, and then adding the minute value divided by 60 multiplied by 0.5. Finally, we multiply this value by 30 to get the angle in degrees.
```csharp
    double hourAngle = (hour % 12 + minute / 60.0) * 30;
```

### 02Calculate the minute angle
The minute hand of an analog clock moves 6 degrees per minute, so we can simply multiply the minute value by 6 to get the angle in degrees.
```csharp 
    double minuteAngle = minute * 6; 
```
    
### 03)Calculate the absolute difference between the hour and minute angles
We subtract the smaller angle from the larger angle to get the absolute difference between the two angles.
```csharp 
    double angle = Math.Abs(hourAngle - minuteAngle);
```


### 04)Normalize the angle to be between 0 and 180 degrees
If the angle is greater than 180 degrees, we subtract it from 360 degrees to get the smaller angle between the hour and minute hands.
```csharp 
    if (angle > 180)
    {
        angle = 360 - angle;
    }
```


Finally, the program prints the time entered by the user, and the lesser angle between the hour and minute hands of the clock.

 
