using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PedidoLogic
    {
        PedidoDAO dao = new PedidoDAO();
        public void GuardarPedido(Pedido pedido)
        {
            dao.GuardarPedido(pedido);
        }

        public void ProcesarPedido(Pedido pedido)
        {
            dao.ProcesarPedido(pedido);
        }
    }
}
