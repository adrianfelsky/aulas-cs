namespace aula13
{
    class Circulo : Forma
    {
        public double Raio { get; set; }
        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI* (Raio*Raio);
        }
    }
}
