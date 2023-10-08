using static TaskManager.ResourceManager;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region #1 Thang
        private void CreateNewProcess()
        {
            STARTUPINFO startupInfo = new STARTUPINFO();
            PROCESS_INFORMATION processInfo = new PROCESS_INFORMATION();

            string applicationName = "C:\\Program Files\\WindowsApps\\Microsoft.WindowsNotepad_11.2307.27.0_x64__8wekyb3d8bbwe\\Notepad\\Notepad.exe";
            string commandLine = null;

            bool success = CreateProcess(
                applicationName,
                commandLine,
                IntPtr.Zero,
                IntPtr.Zero,
                false,
                0,
                IntPtr.Zero,
                null,
                ref startupInfo,
                out processInfo);
            if (success)
            {
                Console.WriteLine($"Create Success ({processInfo.hProcess})");
            }
            else
            {
                Console.WriteLine("Fail!!!");
            }
        }
        private void DisplayPerformanceCPU()
        {
            FILETIME idleTime, kernelTime, userTime;

            if (GetSystemTimes(out idleTime, out kernelTime, out userTime))
            {
                ulong idleTime64 = ((ulong)idleTime.dwHighDateTime << 32) | idleTime.dwLowDateTime;
                ulong kernelTime64 = ((ulong)kernelTime.dwHighDateTime << 32) | kernelTime.dwLowDateTime;
                ulong userTime64 = ((ulong)userTime.dwHighDateTime << 32) | userTime.dwLowDateTime;

                // Tính tỷ lệ thời gian CPU đã sử dụng
                ulong totalTime = kernelTime64 + userTime64;
                double cpuUsage = (1.0 - (double)idleTime64 / totalTime) * 100.0;

                Console.WriteLine($"CPU Usage: {cpuUsage}%");
            }
            else
            {
                Console.WriteLine("Failed to retrieve CPU usage.");
            }
        }
        #endregion

    }
}