namespace W2InClassAssignment;

public class Car
{
    public string Model;
    public Engine Engine;

    public Car(string model, Engine engine)
    {
        Model = model;
        Engine = engine;
    }

    public void Describe()
    {
        Console.WriteLine($"Model: {Model}, HorsePower: {Engine.HorsePower}");
    }
}