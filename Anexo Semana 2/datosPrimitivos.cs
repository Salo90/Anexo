// Clase para representar un Círculo
 public class Circulo
 {
    // Propiedad para el radio del círculo
    public double Radio { get; set; }
    // Constructor
    public Circulo(double radio)
    {
    }
        Radio = radio;
    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        return Math.PI * Radio * Radio;
    }
    // Método para calcular el perímetro del círculo
    public double CalcularPerimetro()
    {
    }
 }
        return 2 * Math.PI * Radio;
 // Clase para representar un Cuadrado
 public class Cuadrado
 {
    // Propiedad para el lado del cuadrado
    public double Lado { get; set; }
    // Constructor
    public Cuadrado(double lado)
    {
    }
        Lado = lado;
    // Método para calcular el área del cuadrado
    public double CalcularArea()
    {
    }
        return Lado * Lado;
    // Método para calcular el perímetro del cuadrado
    public double CalcularPerimetro()
    {
 	return 4 * Lado;
    }
}
