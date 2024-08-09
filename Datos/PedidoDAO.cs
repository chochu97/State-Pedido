using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PedidoDAO
    {
        List<Pedido> lista = new List<Pedido>();
        public void GuardarPedido(Pedido pedido)
        {
            lista.Add(pedido);
            Console.WriteLine("Pedido Numero: " + pedido.Numero + ", Cliente: " + pedido.ClienteName + ", Guardado Correctamente. Estado Actual: " + pedido.estado.Name);
        }
        public void ProcesarPedido(Pedido pedido)
        {
            pedido.estado.CambiarEstado(pedido);

            Console.WriteLine("Pedido Numero: " + pedido.Numero + ", Cliente: " + pedido.ClienteName + ". Cambio de Estado, ahora: " + pedido.estado.Name);

            if (lista.Contains(pedido))
            {
                var pedExistente = lista.FirstOrDefault(p => p.Numero == pedido.Numero);
                
                lista.Remove(pedExistente);
                lista.Add(pedido);
            }
            else
            {
                lista.Add(pedido);
            }
        }
    }
}
