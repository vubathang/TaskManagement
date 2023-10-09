using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TaskManager
{
    internal class ResourceManager
    {
        [DllImport("kernel32.dll")]
        static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles,
         uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFOA lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);
        // Hàm tạo một quy trình mới

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION //Cấu trúc chứa thông tin về một quy trình
        {
            public IntPtr hProcess;//con tro toi tien trinh
            public IntPtr hThread;
            public int dwProcessId;//ID quy trình
            public int dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct STARTUPINFOA //Cấu trúc chứa thông tin về cách một quy trình mới được khởi động
        {
            public int cb;
            public string lpReserved;
            public string lpDesktop;//môi trường làm việc
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;//kthuoc cửa sổ
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
        public const int PROCESS_TERMINATE = 0x0001;
        [DllImport("kernel32.dll")]
        public static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);//Hàm chấm dứt một quy trình đã tồn tại
    }
}
