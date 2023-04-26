using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class FunCommands : BaseCommandModule
    {
        [Command("greet")]
        public async Task TestCommand(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello there!");
        }

        [Command("embedmessage")]
        public async Task SendEmbedMessage(CommandContext ctx)
        {
            var embedMessage = new DiscordMessageBuilder()
                .AddEmbed(new DiscordEmbedBuilder()
                .WithTitle("This is a Title")
                .WithDescription("This is a description")
                .WithColor(DiscordColor.Chartreuse)
                );
            await ctx.Channel.SendMessageAsync(embedMessage);
        }
    }
}
