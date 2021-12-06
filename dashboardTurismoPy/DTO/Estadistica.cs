using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dashboardTurismoPy.DTO
{
    public class Estadistica
    {
        private int reservaCliente;
        private int reservaPrecio;

        public Estadistica(int reservaCliente)
        {
            this.ReservaCliente = reservaCliente;
        }


        public Estadistica(int reservaCliente, int reservaPrecio)
        {
            this.ReservaCliente = reservaCliente;
            this.ReservaPrecio = reservaPrecio;
        }

        public int ReservaCliente { get => reservaCliente; set => reservaCliente = value; }
        public int ReservaPrecio { get => reservaPrecio; set => reservaPrecio = value; }
    }
}
