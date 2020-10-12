namespace DoItLess.DevKit.SystemInfo.Windows.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var osInfo             = SystemInfoCollector.GetOSInfo();
            var cpuList            = SystemInfoCollector.GetCpuList();
            var biosList           = SystemInfoCollector.GetBIOSList();
            var memoryList         = SystemInfoCollector.GetMemoryList();
            var motherboardList = SystemInfoCollector.GetMotherboardList();
        }
    }
}