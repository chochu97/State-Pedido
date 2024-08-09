using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Estado
    {
        public abstract string Name { get;}
        public abstract void CambiarEstado(Pedido pedido);

        public abstract void DescribirEstado();
    }
}
