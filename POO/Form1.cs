using Controladores;
using Modelos;

namespace POO_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MClientes cliente = new MClientes();

            cliente.Nombre = "Juan";
            cliente.Apelliodos = "perez";
            cliente.OtrosIngresos = 2000;

            int OtrosIngresos = 2000;
            cliente.AumentarOtrosIngresos(OtrosIngresos);


            MEmpleados empleado = new MEmpleados()          // 1
            {
                Nombre="Jose",
                Apelliodos= "Rodriguez",
                Sexo="M"
            };

            MEmpleados m = new MEmpleados("dev");           //2
            MEmpleados mp = new MEmpleados("dev","M");      //3

            //CEmpleados Empleado = new CEmpleados();
            //string respuesta = Empleado.Add(empleado);

            //CClientes Cliente = new CClientes();
            //Cliente.Add(cliente);
            PruebasDeMetodos();


        }

        int valor = 0;
        void PruebasDeMetodos()
        {

            //Métodos con retorno y métodos void.
            //Parámetros: por valor, por referencia y opcionales.
            //existen 2 formas de pasar valores por referencia
            // 1 con la palabra ref
            // 2 es con la palabra out

            int valor1 = 3;
            int valor2;
            alterarValor(valor);
            //MessageBox.Show(valor.ToString());
            alterarValorPorReferencia(ref valor1);
            //MessageBox.Show(valor1.ToString());

            alterarValorPorReferenciaOut(out valor2);
            MessageBox.Show(valor2.ToString());
        }

        void alterarValor(int dinero)
        {
            valor = dinero * 2;
        }
        void alterarValorPorReferencia(ref int valor1)
        {
            valor1 = valor1 * 2;
        }

        void alterarValorPorReferenciaOut(out int valor2)
        {
            int result = 3 * 5;
            valor2 = result;
        }

    }
}
