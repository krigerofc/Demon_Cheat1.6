using System;
using System.Numerics;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Demon_app
{
    class Program
    {
        // acesso variaveis
        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_QUERY_INFORMATION = 0x0400;

        // entity list 
        static List<Entity> EntidadesDaPartida = new List<Entity>();

        // importar função da api 
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);

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
            }
            else
            {
                Console.WriteLine("processo não está aberto");
            }
        }
        // vamos ler o arquivo .dem do cs 1.6
    }
 }