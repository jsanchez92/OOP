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

        }
    }
}
