using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Pack:Producto
    {
        int cantidad;

        public int pCantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Pack() : base()
        {
            cantidad = 0;
        }
        public Pack(int cantidad, int codigo, string nombre, string marca, double precio)
            : base(codigo, nombre, marca, precio)
        {
            this.cantidad = cantidad;
        }
        public override double calcularImporte()
        {
            //throw new NotImplementedException();
            return cantidad * precio;
        }

        //--------------------OJO QUE TO STRING SOBRECARGAMOS EN CADA OVERRIDE----------------------
        public override string toString()
        {
            return "Pack: " + cantidad + base.toString();
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
