public abstract class Perro
{
    public virtual string ladrar()
    {
        return "Perro Ladrando";
    }

    public abstract string Dormir();
}
public class Bulldog : Perro 
{
    public override string ladrar()
    {
        return "Bulldog Ladrandando"();
    }

    public override string Dormir()
    {
        return "Bulldog Durmiendo";
    }
}
public class Chichihua : Perro 
{
    public override string ladrar()
    {
        return "Chihuahua Ladrandando";
    }

    public override string Dormir()
    {
        return "Chihuahua Durmiendo";
    }
}
