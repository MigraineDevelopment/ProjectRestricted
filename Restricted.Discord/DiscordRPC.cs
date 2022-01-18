using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;

namespace Restricted.Discord {
    public class DiscordRPC {
        public DiscordRpcClient client;

		public void Initialize() {
			client = new DiscordRpcClient("924718701780017193");

			client.Initialize();

			client.SetPresence(new RichPresence() {
				Details = "ProjectRestricted",
				State = "Xbox 360 Modding",
				Assets = new Assets() {
					LargeImageKey = "logo",
					LargeImageText = "Just a damn icon",
					SmallImageKey = "logo"
				},
				Buttons = new Button[] {
					new Button() { Label = "Discord Server", Url = "https://Discord.gg/Jh7KeRVfGr" },
				}
			});
		}

		public void Dispose() =>
			client.Dispose();

		public void UpdateState(string Text) =>
			client.UpdateState(Text);

		public void UpdateDetails(string Text) =>
			client.UpdateDetails(Text);
	}
}
