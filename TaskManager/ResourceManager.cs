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
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        #region Performance RAM
        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
        }

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);//hàm lấy thông tin về hiệu suất RAM và
                                                                                    //tính toán tỷ lệ sử dụng RAM dựa trên thông tin thu thập được
                                                                                    // for TerminateProcess
        #endregion

        #region Terminate Process
        public const int PROCESS_TERMINATE = 0x0001;
        [DllImport("kernel32.dll")]
        public static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);//Hàm chấm dứt một quy trình đã tồn tại

        #endregion

        #region EnumProcess
        [DllImport("psapi.dll")]
        public static extern bool EnumProcesses(int[] processIds, int size, out int bytesReturned);
        #endregion

        #region SetProcessPriority
        [DllImport("kernel32.dll")]
        public static extern bool SetPriorityClass(IntPtr hProcess, uint dwPriorityClass);

        #endregion

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

        #endregion

        #region Create Process A
        [DllImport("kernel32.dll")]
        public static extern bool CreateProcessA(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFOA lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct STARTUPINFOA
        {
            public int cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
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

        #region Get Disk Free Space
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
           out ulong lpFreeBytesAvailable,
           out ulong lpTotalNumberOfBytes,
           out ulong lpTotalNumberOfFreeBytes);
        #endregion
    }
}