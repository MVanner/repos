using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sender
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ensure that we only start the client after the server has created the pipe
            //ManualResetEvent SyncClientServer = (ManualResetEvent)obj;
            Console.WriteLine("Please enter the process ID to connect to");
            string processIDToCall = Console.ReadLine();

            //Only continue after the server is created
            using (NamedPipeClientStream pipeStream = new NamedPipeClientStream("PipeTo" + processIDToCall))
            {
                //The connect function will indefinately wait for the pipe to become available
                //If that is not acceptable specify a maximum waiting time (ms)
                pipeStream.Connect();

                Console.WriteLine("[Client] Pipe Connection established");
                using (StreamWriter sw = new StreamWriter(pipeStream))
                {
                    sw.AutoFlush = true;
                    string message;
                    Console.WriteLine("Please type a message and press [ENTER], or type 'quit' to exit the program");
                    while ((message = Console.ReadLine()) != null)
                    {
                        if (message == "quit")
                            break;
                        sw.WriteLine(message);
                    }
                }
            }

        }
    }
}
