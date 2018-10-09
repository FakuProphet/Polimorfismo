using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace polimorfismo
{
    public partial class Form1 : Form
    {

        //objeto.metodo() mensaje
        //triangulo recatngulo son polimorficos a la clase
        //clase figura ya tiene el metodo de calcular superficie
        //y en cada clase hija se adecua el metodo para cada tipo de figura
        // el metodo es redefinible.

        //CONSTANTE
        const int tam = 3;

        //SE DECLARA EL VECTOR DE PRODUCTOS 
        Producto[] vectorprod = new Producto[tam];
      
        int contador = 0;


        public Form1()
        {
            InitializeComponent();

           // inicializar el arreglo
            for (int i = 0; i < tam; i++)
            
                vectorprod[i] = null;
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // gpbart.Enabled = false;
            btncalcular.Enabled = false;

            //inicializar el arreglo
            //for (int i = 0; i < tam; i++)
            //{
            //    vectorprod[i] = null;
            //}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //ESTE METODO ES PARA Q CADA VEZ QUE SE SELECCIONE UNO U OTRO COMBO 
            //CAMBIE LA PROPIEDAD TEXT DE LA LABEL
            //EN ESTE CASO ES PARA PRODUCTOS SUELTOS SE PONE MEDIDA
            lblmedidas.Text = "Medida";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            lsttotales.Items.Clear();
            double total = 0;

            //DEBIDO AL POLIMORFISMO EL FOR YA SABE DE QUE PRODUCTO SE TRATA
            //CUAL ES EL Q TIENE Q MOSTRAR SEGUN SEA PACK O SUELTO
            for (int i=0;i<contador;i++)
            {
                //EN ESTE PASO PONEMOS QUE EL VECTOR DEVUELVA EN EL LIST BOX
                //EL tostring q hicimos el override en cada clase
                //EL FOR YA SABE QUE VALOR DEVOLVER... 

                lsttotales.Items.Add(vectorprod[i].toString());
                total +=  vectorprod[i].calcularImporte();
            }

            txttotales.Text = total.ToString();  

        }

        private void btncargar_Click(object sender, EventArgs e)
        {


                //POR MEDIO DE UN IF SELECCIONAMOS SEGUN ESTE CHECKEADO EL RADIO BOTON 

                if (rdbsuelto.Checked)
                {

                    //POR CADA CLICK SE CREA UNA INSTANCIA NUEVA DE UN PRODUCTO SUELTO
                    Suelto ps = new Suelto();
                    
                    ps.pCodigo = Int32.Parse (txtcod.Text);
                    ps.pNombre = txtnombre.Text;
                    ps.pMarca = txtmarca.Text;
                    ps.pPrecio = double.Parse(txtmonto.Text);
                    ps.pMedida = Int32.Parse(txtcantMedi.Text);
                    vectorprod[contador] = ps;
                }

            
                else 
                {

                //POR CADA CLICK SE CREA UNA INSTANCIA NUEVA DE UN PRODUCTO EN PACK
                    Pack pk = new Pack();
                    
                    pk.pCodigo = Int32.Parse(txtcod.Text);
                    pk.pNombre = txtnombre.Text;
                    pk.pMarca = txtmarca.Text;
                    pk.pPrecio = double.Parse(txtmonto.Text);
                    pk.pCantidad = Int32.Parse(txtcantMedi.Text);
                    vectorprod[contador] = pk;
                }

                //DESPUES DE QUE SE HAYA CARGADO UN PRODUCTO SEGUN SEA PACK O SUELTO 
                //RECIEN EMPEZAMOS A CONTAR
                contador++;


            //VERIFICAR SI SE COMPLETO EL VECTOR DE PRODUCTOS 
            if (contador == tam)
            {
                MessageBox.Show("SE COMPLETO EL vector..");
                btncargar.Enabled = false;
                btncalcular.Enabled = true;
            }






        }

        private void rdbpack_CheckedChanged(object sender, EventArgs e)
        {
            //ESTE METODO ES PARA Q CADA VEZ QUE SE SELECCIONE UNO U OTRO COMBO 
            //CAMBIE LA PROPIEDAD TEXT DE LA LABEL
            //EN ESTE CASO ES PARA PRODUCTOS EN PACK SE PONE CANTIDAD
            lblmedidas.Text = "Cantidad";
        }
    }
}