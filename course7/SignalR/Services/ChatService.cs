using Microsoft.AspNetCore.SignalR.Client;
using Shared.Models;

public class ChatService
{
    private HubConnection _hubConnection;

    public event Action<ChatMessage> OnMessageReceived;

    public ChatService()
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5000/chathub")
            .WithAutomaticReconnect()
            .Build();

        _hubConnection.On<ChatMessage>("ReceiveMessage", (message) =>
        {
            OnMessageReceived?.Invoke(message);
        });
    }

    public async Task StartAsync() => await _hubConnection.StartAsync();

    public async Task SendMessage(ChatMessage message) => await _hubConnection.SendAsync("SendMessage", message);
}