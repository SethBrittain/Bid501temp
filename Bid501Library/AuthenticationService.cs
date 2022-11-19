using Konscious.Security.Cryptography;
using System.IO;
using System.Text;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Bid501Library
{
    class AuthenticationService : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            string authJSON = e.Data;
            //auth code
        }

        public AuthenticationService()
        {
            File.Create("key.txt");
            StreamReader file = new("key.txt");
            string? encryptionKey = file.ReadLine();
            if (encryptionKey == null) 
                throw new IOException("Encryption Key Not Found");
            
            string pw = "password";
            byte[] byte_arr = Encoding.UTF8.GetString(pw, 0);

            var subject = new Argon2d(byte_arr);

        }
    }
}
