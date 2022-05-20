using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaTools
{
    public class RichPresenceClient
    {
        public static DiscordRpcClient Client { get; set; }

        private static RichPresence _currentPresence;

        private static readonly Assets _assets = new Assets
        {
            LargeImageKey = "splash",
            LargeImageText = "Mega Tool (Made by Robin)"
        };

        private static readonly Timestamps _timestamps = new Timestamps
        {
            StartUnixMilliseconds = (ulong)DateTimeOffset.Now.ToUnixTimeSeconds()
        };

        private static readonly Button[] _buttons =
        {
            new Button
            {
                Label = "Twitter",
                Url = "https://twitter.com/lolperoi123"
            },
            new Button
            {
                Label = "Visit my Github",
                Url = "https://github.com/RobinOfiONIZUKA"
            }
        };

        public static void Start()
        {

            Client = new DiscordRpcClient("956042233461743646");

            _currentPresence = new RichPresence
            {
                Details = "Made by @lolperoi123",
                State = "Using MegaTool",
                Buttons = _buttons,
                Timestamps = _timestamps
            };

            Client.SetPresence(_currentPresence);
            Client.Initialize();
        }

        public static void UpdatePresence(string details, string State)
        {

            _currentPresence.Details = details;

            _currentPresence.State = State;

            Client.SetPresence(_currentPresence);
        }
    }
}