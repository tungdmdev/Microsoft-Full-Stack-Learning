using System;
using System.Collections.Generic;
using System.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
public class LoadBalancer
{
    private List<Server> servers = new List<Server>();
    private int lastUsedServer = -1;
    public void RegisterServer(Server server)
    {
        servers.Add(server);
    }
    public Server GetServerRoundRobin()
    {
        lastUsedServer = (lastUsedServer + 1) % servers.Count;
        return servers[lastUsedServer];
    }
    public Server GetServerLeastConnections()
    {
        return servers.OrderBy(s => s.RequestCount).First();
    }
    public Server GetServerIpHashing(string ipAddress)
    {
        int index = Math.Abs(ipAddress.GetHashCode()) % servers.Count;
        return servers[index];
    }
}
public class LoadBalancer
{
    private List<Server> servers = new List<Server>();
    private int lastUsedServer = -1;
    public void RegisterServer(Server server)
    {
        servers.Add(server);
    }
    public Server GetServerRoundRobin()
    {
        lastUsedServer = (lastUsedServer + 1) % servers.Count;
        return servers[lastUsedServer];
    }
    public Server GetServerLeastConnections()
    {
        return servers.OrderBy(s => s.RequestCount).First();
    }
    public Server GetServerIpHashing(string ipAddress)
    {
        int index = Math.Abs(ipAddress.GetHashCode()) % servers.Count;
        return servers[index];
    }
}

class Program
{
    static void Main()
    {
        LoadBalancer loadBalancer = new LoadBalancer();
        
        // Register servers
        loadBalancer.RegisterServer(new Server("Server1"));
        loadBalancer.RegisterServer(new Server("Server2"));
        loadBalancer.RegisterServer(new Server("Server3"));
        List<string> clientIPs = new List<string> { "192.168.1.1", "192.168.1.2", "192.168.1.3", "192.168.1.4" };
        Console.WriteLine("Round-Robin Distribution:");
        foreach (var ip in clientIPs)
        {
            var server = loadBalancer.GetServerRoundRobin();
            server.HandleRequest();
            Console.WriteLine($"Request from {ip} → {server.Id}");
        }
        Console.WriteLine("\nLeast Connections Distribution:");
        foreach (var ip in clientIPs)
        {
            var server = loadBalancer.GetServerLeastConnections();
            server.HandleRequest();
            Console.WriteLine($"Request from {ip} → {server.Id}");
        }
        Console.WriteLine("\nIP Hashing Distribution:");
        foreach (var ip in clientIPs)
        {
            var server = loadBalancer.GetServerIpHashing(ip);
            server.HandleRequest();
            Console.WriteLine($"Request from {ip} → {server.Id}");
        }
    }
}