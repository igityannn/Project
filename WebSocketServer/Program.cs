﻿
using WebSocketServer.WebSocketServer;

(string host, int port) = ReadConnection();

var server = new Server($"http://{host}:{port}/");

server.Start();

Console.WriteLine("Press Enter to stop the server...");
Console.ReadLine();

server.Stop();

static (string host, int port) ReadConnection()
{
    Console.Write("Host: ");
    var host = Console.ReadLine();
    while (host == null)
    {
        Console.Write("Please enter host: ");
        host = Console.ReadLine();
    }

    Console.Write("Port: ");

    int port;

    while (!int.TryParse(Console.ReadLine(), out port))
    {
        Console.Write("Please enter correct number: ");
    }

    return (host, port);
}