using System.Net.Sockets;
using System.Net;
using System.Text;
class Program
{
    static void Main()
    {
        TcpListener listener = new TcpListener(IPAddress.Any, 8080);
        listener.Start();
        Console.WriteLine("Server started... Waiting for connection.");

    while (true)
        {
            TcpClient client = listener.AcceptTcpClient();
            NetworkStream stream = client.GetStream();

            string message = "Hello from the server!";
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);

            Console.WriteLine("Sent message to client.");
            client.Close();
        }
    }
}
