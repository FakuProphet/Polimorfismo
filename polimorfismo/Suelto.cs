using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    class Suelto:Producto
    {

        int medida;

        public int pMedida
        {
            get { return medida; }
            set { medida = value; }
        }
        public Suelto()
            : base()
        {
            medida = 0;
        }
        public Suelto(int medida, int codigo, string nombre, string marca, double precio)
            : base(codigo, nombre, marca, precio)
        {
            this.medida = medida;
        }


        public override double calcularImporte()
        {
            //throw new NotImplementedException();
            return medida * base.pPrecio;
        }



        //--------------------OJO QUE TO STRING SOBRECARGAMOS EN ESTE OVERRIDE----------------------
        public override string toString()
        {
            return "Suelto: " + medida + base.toString();
        }

    }
}
