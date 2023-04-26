using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.External_Classes
{
    internal class RockGameBuilder
    {
        public string[] picks = { "Kamien", "Papier", "Nozyce", "Jaszczurka Spock" };

        public string BotPick { get; internal set; }

        public RockGameBuilder()
        {
            var random = new Random();
            int indexPicks = random.Next(0, this.picks.Length - 1);
            this.BotPick = this.picks.ElementAt(indexPicks);
        }

    }
}
