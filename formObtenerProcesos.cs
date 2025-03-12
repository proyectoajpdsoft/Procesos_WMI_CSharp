namespace ProyectoA_Procesos_WMI
{
    public partial class formObtenerProcesosWMI : Form
    {
        public formObtenerProcesosWMI()
        {
            InitializeComponent();
        }

        private void btObtenerProcesos_Click(object sender, EventArgs e)
        {
            string texto = "";

            //Obtenemos la lista de procesos en ejecuci�n del equipo
            Inventario inventario = new Inventario();
            var lsProcesos = inventario.ObtenerProcesos();
            if (lsProcesos != null)
            {
                //Recorremos todos los elementos de la lista de tipo InvProceso 
                foreach (InvProceso proceso in lsProcesos)
                {
                    //Guardamos los datos del adaptador proceso actual en texActual
                    //Separamos cada propiedad con un salto de l�nea
                    string texActual = $"Name: [{proceso.Name}]" +
                        $"\r\n    Process ID: [{proceso.ProcessId}]" +
                        $"\r\n    Command Line: [{proceso.CommandLine}]" +
                        $"\r\n    Executable Path: [{proceso.ExecutablePath}]" +
                        $"\r\n    Page File Usage (Bytes): [{proceso.PageFileUsage}]" +
                        $"\r\n    Thread Count: [{proceso.ThreadCount}]" +
                        $"\r\n    Working Set Size (Bytes): [{proceso.WorkingSetSize}]";
                    //Si es el primer proceso a�adimos el textActual, si es el
                    //segundo o sucesivos, a�adimos un salto de l�nea antes para separarlos
                    texto += texto == "" ? texActual : $"\r\n{texActual}";
                }
            }
            txtProcesos.Text = texto;
        }
    }
}
