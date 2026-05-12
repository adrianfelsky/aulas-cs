namespace aula12
{
    class Carro
    {
        private string _marca;
        private string _modelo;
        private double _speed=0;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public double Speed
        {
            get { return _speed; }
            set { if (value >= 0) _speed = value; }
        }

        public void Acelerar(double incremento)
        {
            if (incremento > 0 && _speed<200)
                _speed += incremento;
        }

        public void Frear(double decremento)
        {
            if (decremento > 0 && decremento <= _speed)
                _speed -= decremento;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {_marca}\nModelo: {_modelo}\nVelocidade: {_speed} km/h");
        }
    }
}
