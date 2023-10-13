using System.Diagnostics;
using System.Runtime.InteropServices;
using static TaskManager.ResourceManager;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        #region #1 Thang
        private void CreateNewProcess()
        {
            STARTUPINFO startupInfo = new STARTUPINFO();
            PROCESS_INFORMATION processInfo = new PROCESS_INFORMATION();

            string applicationName = txtName.Text;
            //string commandLine = null;

            bool success = CreateProcess(
                applicationName,
                null,
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
                MessageBox.Show($"Create Success ({processInfo.hProcess})");
            }
            else
            {
                MessageBox.Show("Fail!!!");
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

                MessageBox.Show($"CPU Usage: {cpuUsage}%", "CPU");
            }
            else
            {
                MessageBox.Show("Failed to retrieve CPU usage.");
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
                dataGridView1.Rows.Add(process.Id, process.ProcessName);
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
                        MessageBox.Show("Tiến trình kết thúc thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết thúc tiến trình.");
                    }
                }
                else
                {
                    MessageBox.Show("Không thể mở tiến trình.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void GetMemoryStatus()
        {
            MEMORYSTATUSEX memoryStatus = new MEMORYSTATUSEX();
            /* trường dwLength số nguyên ko dấu,(uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX)) xác định kthuoc cấu trúc dạng số nguyên */
            memoryStatus.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));

            if (GlobalMemoryStatusEx(ref memoryStatus)) //dwLength đã được thiết lập, biến memoryStatus sẵn sàng để được truyền vào hàm GlobalMemoryStatusEx để lấy thông tin về hiệu suất RAM
            {
                string message = $"Total Physical Memory: {memoryStatus.ullTotalPhys / (1024 * 1024)} MB\n" +
                 $"Available Physical Memory: {memoryStatus.ullAvailPhys / (1024 * 1024)} MB\n" +
                 $"Total Page File: {memoryStatus.ullTotalPageFile / (1024 * 1024)} MB\n" +
                 $"Available Page File: {memoryStatus.ullAvailPageFile / (1024 * 1024)} MB\n" +
                 $"Total Virtual Memory: {memoryStatus.ullTotalVirtual / (1024 * 1024)} MB\n" +
                 $"Available Virtual Memory: {memoryStatus.ullAvailVirtual / (1024 * 1024)} MB\n" +
                 $"Available Extended Virtual Memory: {memoryStatus.ullAvailExtendedVirtual / (1024 * 1024)} MB";

                MessageBox.Show(message, "Memory");

            }
            else
            {
                MessageBox.Show("Failed to retrieve memory status.");
            }
        }
        #endregion

        #region #4 Toan
        private string ShowDiskInfo(string driveName)
        {
            ulong freeBytesAvailable;
            ulong totalNumberOfBytes;
            ulong totalNumberOfFreeBytes;

            bool success = GetDiskFreeSpaceEx(driveName,
                out freeBytesAvailable,
                out totalNumberOfBytes,
                out totalNumberOfFreeBytes);

            if (success)
            {
                return string.Format("Dung lượng tổng của ổ {0}: {1} bytes\nDung lượng trống của ổ {0}: {2} bytes\nDung lượng sử dụng của ổ {0}: {3} bytes",
                    driveName, totalNumberOfBytes, totalNumberOfFreeBytes, totalNumberOfBytes - totalNumberOfFreeBytes);
            }
            else
            {
                return string.Format("Không thể lấy thông số Disk của ổ {0}", driveName);
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Process> processList = EnumProcessesList();
                foreach (Process process in processList)
                {
                    dataGridView1.Rows.Add(process.Id, process.ProcessName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            };
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int processId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    IntPtr processHandle = OpenProcess(PROCESS_TERMINATE, false, processId);
                    if (processHandle != IntPtr.Zero)
                    {
                        comboBox1.SelectedItem = Process.GetProcessById(processId).PriorityClass.ToString();
                    }
                }
            }
            catch (Exception) { }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            STARTUPINFOA si = new STARTUPINFOA();
            si.cb = Marshal.SizeOf(si);
            PROCESS_INFORMATION pi;
            CreateProcessA(null, txtName.Text, IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref si, out pi);
            dataGridView1.Rows.Add(pi.dwProcessId, txtName.Text);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int processId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                TerminateProcessById(processId);
                dataGridView1.Rows.Clear();
                loadProcessList();
            }
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int processId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                IntPtr processHandle = OpenProcess(PROCESS_TERMINATE, false, processId);
                if (processHandle != IntPtr.Zero)
                {
                    bool success = setProcessPriority(processHandle, comboBox1.Text);
                    if (!success)
                    {
                        // Lấy mã lỗi từ GetLastError
                        int errorCode = Marshal.GetLastWin32Error();
                        MessageBox.Show($"Không thể thay đổi priority. Mã lỗi: {errorCode}");
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        loadProcessList();
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Process[] processes;
            dataGridView1.Rows.Clear();
            processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.Id.ToString().Contains(txtSearch.Text) || process.ProcessName.Contains(txtSearch.Text))
                {
                    dataGridView1.Rows.Add(process.Id, process.ProcessName);
                }
            }
            if (txtSearch.Text == "")
            {
                dataGridView1.Rows.Clear();
                loadProcessList();
            }
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            DisplayPerformanceCPU();
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            GetMemoryStatus();
        }

        private void btnDisk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ShowDiskInfo("C:\\"), "Thông số Disk");
        }
    }
}