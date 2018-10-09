using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
   abstract class Producto
    {

        //con este modificador se puede usar el encapsulamiento extendido a las clases hijas
        //se llama encapsulamiento para q solo los objetos de la misma clase puedan tener acceso a los 
        //datos o contenido de la clase madre
        protected int codigo;

        public int pCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        protected string nombre;

        public string pNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        protected string marca;

        public string pMarca
        {
            get { return marca; }
            set { marca = value; }
        }

        protected double precio;

        public double pPrecio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Producto()
        {
            precio = codigo = 0;
            nombre = marca = "";
        }
        public Producto(int codigo, string nombre, string marca, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
        }

        public abstract double calcularImporte();



        //cuidado con el tostring , aca solo creamos un tostring virtual 
        //como decir personal
        public virtual string toString()
        {
            return codigo + nombre + marca + precio;
        }


        //ToString del sistema q despues podemos tambien sobrecargar
        public override string ToString()
        {
            return codigo + nombre + marca + precio;
        }

    }
}
