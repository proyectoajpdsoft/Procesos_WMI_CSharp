using System.Management;

namespace ProyectoA_Procesos_WMI
{
    class Inventario
    {

        public List<InvProceso>? LProcesos { get; set; }

        //Obtener lista de procesos en ejecución en el equipo
        public List<InvProceso> ObtenerProcesos()
        {
            List<InvProceso> elementos = new List<InvProceso>();

            try
            {
                ManagementObjectSearcher objBusquedaWMI =
                    new ManagementObjectSearcher("Select ProcessId, Name, PageFileUsage, ThreadCount, WorkingSetSize, ExecutablePath, CommandLine FROM Win32_Process");
                foreach (ManagementObject propiedad in objBusquedaWMI.Get().Cast<ManagementObject>())
                {
                    InvProceso elemActual = new InvProceso();

                    try
                    {
                        elemActual.ProcessId = Convert.ToString(propiedad["ProcessId"]);
                    }
                    catch
                    {
                        elemActual.ProcessId = "";
                    }

                    try
                    {
                        elemActual.Name = Convert.ToString(propiedad["Name"]);
                    }
                    catch
                    {
                        elemActual.Name = "";
                    }

                    try
                    {
                        if (!long.TryParse(Convert.ToString(propiedad["PageFileUsage"]), out long tamaño))
                            tamaño = 0;
                        elemActual.PageFileUsage = tamaño;
                    }
                    catch
                    {
                        elemActual.PageFileUsage = 0;
                    }

                    try
                    {
                        if (!long.TryParse(Convert.ToString(propiedad["ThreadCount"]), out long tamaño))
                            tamaño = 0;
                        elemActual.ThreadCount = tamaño;
                    }
                    catch
                    {
                        elemActual.ThreadCount = 0;
                    }

                    try
                    {
                        if (!long.TryParse(Convert.ToString(propiedad["WorkingSetSize"]), out long tamaño))
                            tamaño = 0;
                        elemActual.WorkingSetSize = tamaño;
                    }
                    catch
                    {
                        elemActual.WorkingSetSize = 0;
                    }

                    try
                    {
                        elemActual.ExecutablePath = Convert.ToString(propiedad["ExecutablePath"]);
                    }
                    catch
                    {
                        elemActual.ExecutablePath = "";
                    }

                    try
                    {
                        elemActual.CommandLine = Convert.ToString(propiedad["CommandLine"]);
                    }
                    catch
                    {
                        elemActual.CommandLine = "";
                    }

                    elementos.Add(elemActual);
                }

                LProcesos = elementos;
            }
            catch (Exception error)
            {
                LProcesos = null;
                string texto = $"Error al obtener procesos del equipo con WMI. Error: {error.Message}";
                MessageBox.Show(texto, "Error al obtener procesos...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return elementos;
        }
    }
}
