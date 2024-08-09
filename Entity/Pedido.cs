
using Business.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class Pedido
    {
        public int Numero {  get; set; }
        public string ClienteName { get; set; }

        public Estado estado;

        public Pedido(int num, string nameClient)
        {
            Numero = num;
            ClienteName = nameClient;

            estado = new Nuevo();
        }

        

        
    }
}
