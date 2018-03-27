using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBotApp.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:433/{0}";

        public static string Name { get; set; } = "SimpleBot";

        public static string Key { get; set; } = "586941656:AAHhAaJBQtpL6I-uOS0RDATKjgmDfk4Y5XM";
    }
}