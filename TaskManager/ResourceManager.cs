using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    internal class ResourceManager
    {
        #region EnumProcess
        [DllImport("psapi.dll")]
        static extern bool EnumProcesses(int[] processIds, int size, out int bytesReturned);

        public void loadProcessList()
        {
            Process[] processes;
            processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                Console.WriteLine("ID: {0} - Name: {1}", process.Id, process.ProcessName);
            }
        }

        public List<Process> EnumProcesses()
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

        #region SetProcessPriority
        [DllImport("kernel32.dll")]
        static extern bool SetPriorityClass(IntPtr hProcess, uint dwPriorityClass);

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
        #region Create Process

        // Import hàm Process từ thư viện kernel32.dll
        [DllImport("kernel32.dll")]
        public static extern bool CreateProcess(
            string lpApplicationName,   // Tên tệp chạy (path)
            string lpCommandLine,       // Dòng lệnh muốn truyền vào khi thực thi
            IntPtr lpProcessAttributes, // Chỉ định thuộc tính tiến trình
            IntPtr lpThreadAttributes,  // Chỉ định thuộc tính luồng
            bool bInheritHandles,       // (Cờ) chỉ định xem tiến trình con có nên kế thừa các handles từ tiến trình cha không
            uint dwCreationFlags,       // Tập hợp cờ để chỉ cách tiến trình con được tạo ra (VD: mở trên cửa sổ mới)
            IntPtr lpEnvironment,       // Cho phép chuyển đổi môi trường cho tiến tình con
            string lpCurrentDirectory,  // Đường dẫn thư mục cho tiến trình con
            ref STARTUPINFO lpStartupInfo, // Trỏ tới thông tin về cách tiến trình con khởi đội (giao diện, kích thước, ...)
            out PROCESS_INFORMATION lpProcessInformation);  // Trỏ tới thông tin tiến trình con sau khi đã được tạo (PID, TID, ...)
            /*
            * ref : Nếu muốn thay đổi giá trị của biến đã có dữ liệu trước
            * out : Không quan tâm tới giá trị ban đầu
            */


        // Xác định cách dữ liệu được tổ chức
        [StructLayout(LayoutKind.Sequential)]
        public struct STARTUPINFO
        {
            public int cb;              // Số lượng byte cần cấp phát
            public string lpReserved;   // 
            public string lpDesktop;    // Tên desktop (Env)
            public string lpTitle;      // Tên tiêu đề cửa sổ
            public uint dwX;            // Tọa độ của cửa sổ
            public uint dwY;
            public uint dwXSize;        // Kích thước cửa sổ
            public uint dwYSize;
            public uint dwXCountChars;  // Số kí tự môi hàng , số hàng
            public uint dwYCountChars;
            public uint dwFillAttribute;// Thuộc tính fill cho cửa sổ
            public uint dwFlags;        // Cờ đanh dấu tùy chọn
            public short wShowWindow;   // Trạng thái hiển thị ( minimizes, normal, maximized )
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;    // Handle đầu vào
            public IntPtr hStdOutput;   // Handle đầu ra
            public IntPtr hStdError;    // Handle lỗi
            /*
             * Handle là một số đặc biệt để nhận diện và quản lý các dối tượng hoặc tài nguyên trong hệ thống máy tính
             */
        }

        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess; // Con trỏ trỏ tới tiến trình
            public IntPtr hThread;  // Con trỏ trỏ tới luồng
            public uint dwProcessId;// PID
            public uint dwThreadId; // TID
        }
        #endregion

        #region Display Performance CPU

        /*
         *  Hàm GetSystemTimes trả về thông tin về thời gian của CPU
         */
        [DllImport("kernel32.dll")]
        public static extern bool GetSystemTimes(
            out FILETIME lpIdleTime,    // Con trỏ đại diện cho khoảng thời gian CPU không hoạt động
            out FILETIME lpKernelTime,  // Con trỏ chứa thời gian CPU đã sử dụng cho các tác vụ hạt nhân
            out FILETIME lpUserTime);   // Con trỏ chứa thười gian cho tác vụ người dùng

        [StructLayout(LayoutKind.Sequential)]
        public struct FILETIME
        {
            public uint dwLowDateTime;  // Lưu phần thấp
            public uint dwHighDateTime; // Lưu phần cao
            /*
             * Phần thấp và phần cao (low-order và high-order) là các khái niệm được sử dụng trong ngữ cảnh lưu trữ số nguyên dài (long integers) hoặc số nguyên lớn hơn 32-bit (ví dụ: số 64-bit) khi chúng ta lưu trữ hoặc xử lý số lớn hơn mà không thể chứa trong một biến 32-bit.
             */
        }
        #endregion
    }
}
