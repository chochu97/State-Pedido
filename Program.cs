using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePedido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido p = new Pedido(234, "Ambar");
            Pedido p2 = new Pedido(190, "Flor");

            PedidoLogic logic = new PedidoLogic();

            logic.GuardarPedido(p);
            logic.GuardarPedido(p2);
            Console.ReadKey();

            logic.ProcesarPedido(p);
            logic.ProcesarPedido(p);
            Console.ReadKey();


            logic.ProcesarPedido(p2);
            logic.ProcesarPedido(p2);
            logic.ProcesarPedido(p2);
            logic.ProcesarPedido(p2);

            Console.WriteLine(p.estado.Name);
            Console.ReadKey();
        }
    }
}
