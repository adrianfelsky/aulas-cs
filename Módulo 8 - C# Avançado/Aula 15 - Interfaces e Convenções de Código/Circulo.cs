namespace Aula15
{
    public class Circulo : IFormaGeometrica
    {
        public double Raio { get; private set; }
        public Circulo(double raio)
        {
            Raio = raio;
        }
        public double CalcularArea()
        {
            return Math.PI * Raio*Raio;
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}
