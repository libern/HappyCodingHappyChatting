using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HappyCoding
{
    public partial class Chat : Form
    {
        private Client SomelineClient; // SomelineClient > attribute / instance var. / object var. / field
        public Chat()
        {
            InitializeComponent();

            ClientRouter router = ClientRouter.getInstance();
            router.addChat(this);

            /**
             * Client > Class
             * SomelineClient > Local Var / Instance of Client / Client Object
             * SomelineString > Local Var / Instance of String / String Object
             */
            //            String SomelineString = "Hello";
            //            Client SomelineClient = new Client(); > SomelineClient > Local Var / Instance of Client / Client Object
            SomelineClient = new Client(); // Reference to Instance Var. / Object Var. / Attribute
            SomelineClient.StartClient();
            //            SomelineClient.
            //            Client.StartClient(); //static

            var email = "libern@vip.qq.com";
            var password = "lin12345";

            // sign in
            // Serialization > Convert Obj to Json String
            SomelineRequestJson requestJson = new SomelineRequestJson();
            requestJson.SomelineActionCode = "001001";
            Dictionary<String, String> dataDictionary = new Dictionary<string, string>();
            dataDictionary.Add("email", email);
            dataDictionary.Add("password", password);
            requestJson.data = dataDictionary;
            //            string requestJsonString = JsonConvert.SerializeObject(requestJson);
            string requestJsonString = requestJson.ToString();

            // send to server via client
            SomelineClient.Send(requestJsonString);


        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            // local var.
            String message = MessageTextBox.Text;
            String recipient = RecipientTextBox.Text;

            String ShownMessage = "Send to " + recipient + ": " + message;
            ConversationListBox.Items.Add(ShownMessage);

            // Serialization > Convert Obj to Json String
            SomelineRequestJson requestJson = new SomelineRequestJson();
            requestJson.SomelineActionCode = "002001";
            Dictionary<String, String> dataDictionary = new Dictionary<string, string>();
            dataDictionary.Add("recipient", recipient);
            dataDictionary.Add("message", message);
            requestJson.data = dataDictionary;
            //            string requestJsonString = JsonConvert.SerializeObject(requestJson);
            string requestJsonString = requestJson.ToString();

            // send to server via client
            SomelineClient.Send(requestJsonString);
        }


        public void newMessageReceived(String sender, String message)
        {
            String shownString = "Received from " + sender + ": " + message;
            Invoke(new MethodInvoker(delegate
            {
                // load the control with the appropriate data
                ConversationListBox.Items.Add(shownString);
            }));
        }

    }
}
