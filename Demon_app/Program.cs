using System;
using System.Numerics;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Demon_app
{
    class Program
    {
        // acesso variaveis
        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_QUERY_INFORMATION = 0x0400;

        static List<Entity> entities = new List<Entity>();

        
        // importar função da api 
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        public static readonly int PositionNormal = 0x7dc;
        public static readonly int MyPlayer = 0x7C;

        static void Main(string[] args)
        {
            string processName = "cs";
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length == 0)
            { return; }

            IntPtr handle = OpenProcess(PROCESS_VM_READ | PROCESS_QUERY_INFORMATION, false, processes[0].Id);
            if (handle != IntPtr.Zero)
            {
                Console.WriteLine("processo aberto");
                CloseHandle(handle);

                List<Entity> entities = Read
                Console.WriteLine("Lendo jogadores");
            }
            else
            {
                Console.WriteLine("processo não está aberto");
            }
        }
        // vamos ler o arquivo .dem do cs 1.6
    }
 }