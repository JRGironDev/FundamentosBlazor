namespace FundamentosBlazor.Data;

public class DatosDemo : IDatosDemo
{
    private int edad;

    public DatosDemo()
    {
        Random numRnd = new Random();

        edad = numRnd.Next(0, 8);
    }

    public int GetEdad()
    {
        return edad;
    }
}