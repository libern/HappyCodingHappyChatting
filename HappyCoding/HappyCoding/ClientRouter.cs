using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HappyCoding
{
    class ClientRouter
    {

        private static ClientRouter router = new ClientRouter();
        //        private List<Chat> chats;
        private Chat chat;

        private ClientRouter()
        {
        }

        public static ClientRouter getInstance()
        {
            return router;
        }

        public void route(String data)
        {
            Console.WriteLine(data);
            data = data.Replace("\u0004", "");
            // deserialisation
            SomelineResponseJson responseJson = JsonConvert.DeserializeObject<SomelineResponseJson>(data);
            if (responseJson.SomelineResponseCode == "120101")
            {
                String sender = responseJson.data["sender"];
                String message = responseJson.data["message"];
                chat.newMessageReceived(sender, message);
            }
        }

        public void addChat(Chat chat)
        {
            //            chats.Add(chat);
            this.chat = chat;
        }

    }
}
