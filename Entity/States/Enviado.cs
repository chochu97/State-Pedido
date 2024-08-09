using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.States
{
    public class Enviado : Estado
    {
        public override string Name => "Enviado";

        public override void CambiarEstado(Pedido pedido)
        {
            pedido.estado = new Entregado();
            
        }

        public override void DescribirEstado()
        {
            Console.WriteLine("Estado de Pedido: Entregado");
        }
    }
}
