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
        }
        #endregion
    }
}
