using System;

public class Circle
{
    private double radius;

    public Circle()
    {
        radius = 0.0;
    }

    public double Radius
    {
        get { return radius; }
    }

    public void SetRadius(double newRadius)
    {
        if (newRadius > 0)
        {
            radius = newRadius;
        }
        else
        {
            throw new InvalidRadiusException(newRadius);
        }
    }

    public override string ToString()
    {
        return $"Circle with radius {radius}";
    }
}

public class InvalidRadiusException : Exception
{
    public InvalidRadiusException() : base("Invalid radius. Radius must be greater than zero.")
    {
    }

    public InvalidRadiusException(double invalidRadius) : base($"Invalid radius: {invalidRadius}. Radius must be greater than zero.")
    {
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        try
        {
            Circle circle1 = new Circle();
            circle1.SetRadius(5.0);
            Console.WriteLine(circle1.ToString());
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine($"Error creating circle 1: {ex.Message}");
        }

        try
        {
            Circle circle2 = new Circle();
            circle2.SetRadius(-2.0); // Invalid radius
            Console.WriteLine(circle2.ToString());
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine($"Error creating circle 2: {ex.Message}");
        }

        try
        {
            Circle circle3 = new Circle();
            circle3.SetRadius(0.0); // Invalid radius
            Console.WriteLine(circle3.ToString());
        }
        catch (InvalidRadiusException ex)
        {
            Console.WriteLine($"Error creating circle 3: {ex.Message}");
        }
    }
}