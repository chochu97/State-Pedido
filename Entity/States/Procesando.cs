using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.States
{
    public class Procesando : Estado
    {
        public override string Name => "Procesando";

        public override void CambiarEstado(Pedido pedido)
        {
            pedido.estado = new Enviado();
            
        }

        public override void DescribirEstado()
        {
            Console.WriteLine("Estado de Pedido: Enviado");
        }
    }
}
