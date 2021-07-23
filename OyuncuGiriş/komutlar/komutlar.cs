using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OyuncuGiriş.komutlar
{
    public class komutlar : IRocketCommand
    {
        
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "İnfo";

        public string Help => (AnaBbaba.Instance.Configuration.Instance.ServerİnfoHelpKomudu);

        public string Syntax => "<name>";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            var c = AnaBbaba.Instance.Configuration.Instance;
            if (command.Length < 1)
            {
                UnturnedChat.Say(caller, c.HatalıKod);
                return;
            }
            if (command.Count()!=0)
            {
                UnturnedChat.Say(caller, c.Serverİnfo);
                return;
            }
        }
    }
}
