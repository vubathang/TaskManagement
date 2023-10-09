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
            Console.WriteLine("Nhap process ID : ");
            int x = Convert.ToInt32(Console.ReadLine());
            TerminateProcessById(x);
            GetMemoryStatus();


        }
        #region TerminateProgress
        private void TerminateProcessById(int processId)
        {
            try
            {
                IntPtr processHandle = Process.GetProcessById(processId).Handle;
                if (processHandle != IntPtr.Zero)
                {
                    bool terminated = TerminateProcess(processHandle, 0);
                    if (terminated)
                    {
                        Console.WriteLine("Tien trinh ket thuc thanh cong.");
                    }
                    else
                    {
                        Console.WriteLine("Khong the ket thuc tien trinh.");
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        #endregion

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
        private void Form1_Load(object sender, EventArgs e)
        {
            ResourceManager resourceManager = new ResourceManager();
            resourceManager.loadProcessList();
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