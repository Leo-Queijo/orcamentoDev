

namespace OrcamentoDev.Models
{
    internal class Orcamento
    {
        // Campos privados
        private string _cliente;
        private int _horasEstimadas;
        private decimal _valorHora;


        //propriedades publicas para receber os campos privados

        public string Cliente
        {
            get => _cliente;
            set => _cliente = value;
        }
        public int HoraEstimadas
        {
            get => _horasEstimadas;
            set => _horasEstimadas = value > 0 ? value : 0;
        }

        public decimal ValorHora
        {
            get => _valorHora;
            set => _valorHora = value > 0 ? value : 0;
        }

        //Construtor

        public Orcamento(string cliente, int horasEstimadas, decimal valorHora)
        {
            _cliente = cliente;
            _horasEstimadas = horasEstimadas;
            _valorHora= valorHora;
        }

        //Método virtual para permitir polimorfismo nas classes filhas
        public virtual decimal CalcularTotal()
        {
            return _horasEstimadas * ValorHora;
        }

    }
}
