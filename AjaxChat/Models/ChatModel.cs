using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxChat.Models
{
    public class ChatModel
    {
        public List<ChatUser> Users { get; set; }
        public List<ChatMessage> Messages { get; set; }

        public ChatModel()
        {
            Users = new List<ChatUser>();
            Messages = new List<ChatMessage>();
            Messages.Add(new ChatMessage()
            {
                Text = "Чат запущен "+ DateTime.Now
            });
        }
    }
}