using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.States
{
    public class Nuevo : Estado
    {
        public override string Name => "Nuevo";

        public override void CambiarEstado(Pedido pedido)
        {
            pedido.estado = new Procesando();
            
        }

        public override void DescribirEstado()
        {
            Console.WriteLine("Estado de Pedido: Procesando");
        }
    }
}
