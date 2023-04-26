using DiscordBot.External_Classes;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    internal class GameCommands : BaseCommandModule
    {
        [Command("cardgame")]
        public async Task CardGame(CommandContext ctx)
        {
            var userCard = new CardBuilder();

            var userCardMessage = new DiscordMessageBuilder()
                .AddEmbed(new DiscordEmbedBuilder()
                .WithColor(DiscordColor.Azure)
                .WithTitle("Your Card")
                .WithDescription($"You drew a {userCard.SelectedCard}")
                );

            await ctx.Channel.SendMessageAsync(userCardMessage);

            var botCard = new CardBuilder();

            var botCardMessage = new DiscordMessageBuilder()
                .AddEmbed(new DiscordEmbedBuilder()
                .WithColor(DiscordColor.Azure)
                .WithTitle("Bot's Card")
                .WithDescription($"Bot drew a {botCard.SelectedCard}")
                );

            await ctx.Channel.SendMessageAsync(botCardMessage);

            if (userCard.SelectedNumber > botCard.SelectedNumber)
            {
                var winningMessage = new DiscordEmbedBuilder()
                {
                    Title = "You win the game!",
                    Color = DiscordColor.Green
                };
                await ctx.Channel.SendMessageAsync(embed: winningMessage);
            }
            else if (userCard.SelectedNumber < botCard.SelectedNumber)
            {
                var losingMessage = new DiscordEmbedBuilder()
                {
                    Title = "You lost the game!",
                    Color = DiscordColor.Red
                };
                await ctx.Channel.SendMessageAsync(embed: losingMessage);
            }
            else
            {
                var tieMessage = new DiscordEmbedBuilder()
                {
                    Title = "You have tied the game!",
                    Color = DiscordColor.Orange
                };
                await ctx.Channel.SendMessageAsync(embed: tieMessage);
            }
        }
    }
}
