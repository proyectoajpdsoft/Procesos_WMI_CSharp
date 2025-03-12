namespace ProyectoA_Procesos_WMI
{
    public class InvProceso
    {
        public string Name { get; set; }

        public string ProcessId { get; set; }

        public long PageFileUsage { get; set; }

        public long ThreadCount { get; set; }

        public long WorkingSetSize { get; set; }

        public string ExecutablePath { get; set; }

        public string CommandLine { get; set; }

        public InvProceso()
        {
            Name = string.Empty;
            ProcessId = string.Empty;
            PageFileUsage = 0;
            ThreadCount = 0;
            WorkingSetSize = 0;
            ExecutablePath = string.Empty;
            CommandLine = string.Empty;
        }
    }
}