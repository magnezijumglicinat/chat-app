using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zajednicki
{
    public class JsonNetworkSerializer
    {
        private Socket socket;
        private NetworkStream stream;
        private StreamReader reader;
        private StreamWriter writer;

        public JsonNetworkSerializer(Socket socket)
        {
           this.socket = socket;
            stream = new NetworkStream(socket);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream)
            {
                AutoFlush = true
            };

        }
        public async Task SendAsync(object z, CancellationToken token = default)
        {
            string json = JsonSerializer.Serialize(z);
            token.ThrowIfCancellationRequested();
            await writer.WriteLineAsync(json);
            await writer.FlushAsync();

        }
        public async Task<T> ReceiveAsync<T>(CancellationToken token = default)
        {
            token.ThrowIfCancellationRequested();
            string json = await reader.ReadLineAsync();
            if (json == null)
                throw new IOException("Konekcija je zatvorena.");
            return JsonSerializer.Deserialize<T>(json)!;
        }
       /* public T ReadType<T>(object podaci) where T : class
        {
            return podaci == null ? null : JsonSerializer.Deserialize<T>((JsonElement)podaci);
        }*/
        public void Close()
        {
            stream?.Dispose();
            writer?.Dispose();
            reader?.Dispose();
        }
    }
}
