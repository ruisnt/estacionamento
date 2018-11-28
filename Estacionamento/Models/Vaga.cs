using System;

namespace Estacionamento.Models
{
    public class Vaga
    {
        public int id { get; set; }
        public int idCarro { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Termino { get; set; }
        public Carro Carro { get; internal set; }
    }
}
