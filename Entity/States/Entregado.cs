using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.States
{
    public class Entregado : Estado
    {
        public override string Name => "Entregado";

        public override void CambiarEstado(Pedido pedido)
        {
            pedido.estado = new Entregado();
            
        }

        public override void DescribirEstado()
        {
            Console.WriteLine("Pedido Entregado");
        }
    }
}
