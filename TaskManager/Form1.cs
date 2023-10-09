using System.Diagnostics;
using System.Runtime.InteropServices;
using static TaskManager.ResourceManager;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Console.WriteLine("Nhap process ID : ");
            //int x = Convert.ToInt32(Console.ReadLine());
            loadProcessList();
            int x = Convert.ToInt32(Console.ReadLine());
            TerminateProcessById(x);
            //CreateNewProcess();
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

        #region #2 Hoang
        public bool setProcessPriority(IntPtr processHandle, string priority)
        {
            bool success = false;
            switch (priority)
            {
                case "Realtime":
                    success = SetPriorityClass(processHandle, 0x00000100);
                    break;
                case "High":
                    success = SetPriorityClass(processHandle, 0x00000080);
                    break;
                case "AboveNormal":
                    success = SetPriorityClass(processHandle, 0x00008000);
                    break;
                case "Normal":
                    success = SetPriorityClass(processHandle, 0x00000020);
                    break;
                case "BelowNormal":
                    success = SetPriorityClass(processHandle, 0x00004000);
                    break;
                case "Low":
                    success = SetPriorityClass(processHandle, 0x00000040);
                    break;
                case "Idle":
                    success = SetPriorityClass(processHandle, 0x00000010);
                    break;
            }
            return success;
        }

        public void loadProcessList()
        {
            Process[] processes;
            processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                Console.WriteLine("ID: {0} - Name: {1}", process.Id, process.ProcessName);
            }
        }

        public List<Process> EnumProcessesList()
        {
            List<Process> processList = new List<Process>();
            int[] processIds = new int[1024];
            int bytesReturned;

            if (EnumProcesses(processIds, processIds.Length * 4, out bytesReturned))
            {
                for (int i = 0; i < bytesReturned / 4; i++)
                {
                    try
                    {
                        Process process = Process.GetProcessById(processIds[i]);
                        processList.Add(process);
                    }
                    catch (ArgumentException) { }
                }
            }
            return processList;
        }
        #endregion

        #region #3 Huyen
        private void TerminateProcessById(int processId)
        {
            try
            {
                IntPtr processHandle = OpenProcess(PROCESS_TERMINATE, false, processId);
                if (processHandle != IntPtr.Zero)
                {
                    bool terminated = TerminateProcess(processHandle, 0);
                    if (terminated)
                    {
                        Console.WriteLine("Tiến trình kết thúc thành công.");
                    }
                    else
                    {
                        Console.WriteLine("Không thể kết thúc tiến trình.");
                    }
                }
                else
                {
                    Console.WriteLine("Không thể mở tiến trình.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        private void GetMemoryStatus()
        {
            MEMORYSTATUSEX memoryStatus = new MEMORYSTATUSEX();
            /* trường dwLength số nguyên ko dấu,(uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX)) xác định kthuoc cấu trúc dạng số nguyên */
            memoryStatus.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));

            if (GlobalMemoryStatusEx(ref memoryStatus)) //dwLength đã được thiết lập, biến memoryStatus sẵn sàng để được truyền vào hàm GlobalMemoryStatusEx để lấy thông tin về hiệu suất RAM
            {
                Console.WriteLine($"Total Physical Memory: {memoryStatus.ullTotalPhys / (1024 * 1024)} MB");
                Console.WriteLine($"Available Physical Memory: {memoryStatus.ullAvailPhys / (1024 * 1024)} MB");
                Console.WriteLine($"Total Page File: {memoryStatus.ullTotalPageFile / (1024 * 1024)} MB");
                Console.WriteLine($"Available Page File: {memoryStatus.ullAvailPageFile / (1024 * 1024)} MB");
                Console.WriteLine($"Total Virtual Memory: {memoryStatus.ullTotalVirtual / (1024 * 1024)} MB");
                Console.WriteLine($"Available Virtual Memory: {memoryStatus.ullAvailVirtual / (1024 * 1024)} MB");
                Console.WriteLine($"Available Extended Virtual Memory: {memoryStatus.ullAvailExtendedVirtual / (1024 * 1024)} MB");
            }
            else
            {
                Console.WriteLine("Failed to retrieve memory status.");
            }
        }

        #endregion
    }
}