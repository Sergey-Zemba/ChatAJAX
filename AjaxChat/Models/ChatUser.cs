using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxChat.Models
{
    public class ChatUser
    {
        public string Name { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime LastPing { get; set; }
    }
}