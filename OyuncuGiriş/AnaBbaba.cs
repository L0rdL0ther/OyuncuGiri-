using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API.Collections;
using Rocket.Unturned.Chat;
using Rocket.Unturned;
using Rocket.Unturned.Player;

namespace OyuncuGiriş
{
    public class AnaBbaba : RocketPlugin<AnaBabaAyarlar>
    {
        public static AnaBbaba Instance { get; private set; } 
        
        protected override void Load()
        {
            var c = Configuration.Instance;
            Instance = this;
            U.Events.OnPlayerConnected += Girdi;
            U.Events.OnPlayerDisconnected += Cikti;
            Logger.Log("***************************************");
            Logger.Log("                                       ");
            Logger.Log("     Babanenizin en sevdiği plugin     ");
            Logger.Log("                                       ");
            Logger.Log("                                       ");
            Logger.Log("                                       ");
            Logger.Log($"{name}{Assembly.GetName().Version} oyuncu Giriş Çıkış Plugini |Anancılık plugin");
            Logger.Log("                                       ");
            Logger.Log("               Vidanjör                ");
            Logger.Log("                                       ");
            Logger.Log("                                       ");
            Logger.Log(" Dikkat Babennize Bağımlılık yapabilir ");
            Logger.Log("                                       ");
            Logger.Log("***************************************");
        }

        private void Cikti(UnturnedPlayer player)
        {
            var c = Configuration.Instance;
            UnturnedChat.Say( player , $" {player.DisplayName} | {Configuration.Instance.OyuncuÇıkışMesaj}");
            UnturnedChat.Say( $" {player.DisplayName} | {c.ServerÇıkışMesaj}");

        }

        private void Girdi(UnturnedPlayer player)
        {
            var c = Configuration.Instance;
            UnturnedChat.Say(player, $" {player.DisplayName} | {Configuration.Instance.OyuncuGirişMesaj}");
            UnturnedChat.Say( $" {player.DisplayName} | {c.ServerGirişMesaj}");

        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Girdi;
            U.Events.OnPlayerDisconnected -= Cikti;
            Instance = null;
            Logger.Log("***************************************");
            Logger.Log("                                       ");
            Logger.Log("     Babanenizin en sevdiği plugin     ");
            Logger.Log("                                       ");
            Logger.Log("                                       ");
            Logger.Log("                                       ");
            Logger.Log($"{name}{Assembly.GetName().Version} Plugin Başarılı Bir şekilde Unload olmuştur |Anancılık plugin");
            Logger.Log("                                       ");
            Logger.Log("               Vidanjör                ");
            Logger.Log("                                       ");
            Logger.Log("                                       ");
            Logger.Log(" Dikkat Babennize Bağımlılık yapabilir ");
            Logger.Log("                                       ");
            Logger.Log("***************************************");
        }

        
    }
}
