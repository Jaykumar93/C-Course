using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Start listening for incoming connections on port 1234
        TcpListener server = new TcpListener(IPAddress.Any, 1234);
        server.Start();

        Console.WriteLine("Server started. Waiting for a connection...");

        // Accept incoming client connection
        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("Client connected.");

        // Get a network stream for reading and writing
        NetworkStream stream = client.GetStream();

        // Receive and display messages from the client
        byte[] buffer = new byte[1024];
        int bytesRead;
        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
        {
            string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine($"Client: {message}");
        }

        // Clean up
        stream.Close();
        client.Close();
        server.Stop();
    }
}
