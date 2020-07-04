using System;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace Seraph_Sharp.Modules
{
    class Memecommands
    {
        [Group("memes", CanInvokeWithoutSubcommand = true)] // this makes the class a group, but with a twist; the class now needs an ExecuteGroupAsync method
        [Description("Contains some memes. When invoked without subcommand, returns a random one.")]
        [Aliases("copypasta")]
        public class ExampleExecutableGroup
        {
            // commands in this group need to be executed as 
            // <prefix>memes [command] or <prefix>copypasta [command]

            // this is the group's command; unlike with other commands, 
            // any attributes on this one are ignored, but like other
            // commands, it can take arguments
            public async Task ExecuteGroupAsync(CommandContext ctx)
            {
                //Randome meme - add more later
                var rnd = new Random();
                var nxt = rnd.Next(0, 0);

                switch (nxt)
                {
                    case 0:
                        await Pepe(ctx);
                        return;
                }
            }

            [Command("pepe"), Aliases("feelsbadman"), Description("Feels bad, man.")]
            public async Task Pepe(CommandContext ctx)
            {
                await ctx.TriggerTypingAsync();

                // wrap it into an embed
                var embed = new DiscordEmbedBuilder
                {
                    Title = "Pepe",
                    ImageUrl = "http://i.imgur.com/44SoSqS.jpg"
                };
                await ctx.RespondAsync(embed: embed);
            }

            // this is a subgroup; you can nest groups as much 
            // as you like
            [Group("mememan", CanInvokeWithoutSubcommand = true), Hidden]
            public class MemeMan
            {
                public async Task ExecuteGroupAsync(CommandContext ctx)
                {
                    await ctx.TriggerTypingAsync();

                    // wrap it into an embed
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "Meme man",
                        ImageUrl = "http://i.imgur.com/tEmKtNt.png"
                    };
                    await ctx.RespondAsync(embed: embed);
                }

                [Command("ukip"), Description("The UKIP pledge.")]
                public async Task Ukip(CommandContext ctx)
                {
                    await ctx.TriggerTypingAsync();

                    // wrap it into an embed
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "UKIP pledge",
                        ImageUrl = "http://i.imgur.com/ql76fCQ.png"
                    };
                    await ctx.RespondAsync(embed: embed);
                }

                [Command("lineofsight"), Description("Line of sight.")]
                public async Task LOS(CommandContext ctx)
                {
                    await ctx.TriggerTypingAsync();

                    // wrap it into an embed
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "Line of sight",
                        ImageUrl = "http://i.imgur.com/ZuCUnEb.png"
                    };
                    await ctx.RespondAsync(embed: embed);
                }

                [Command("art"), Description("Art.")]
                public async Task Art(CommandContext ctx)
                {
                    await ctx.TriggerTypingAsync();

                    // wrap it into an embed
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "Art",
                        ImageUrl = "http://i.imgur.com/VkmmmQd.png"
                    };
                    await ctx.RespondAsync(embed: embed);
                }

                [Command("seeameme"), Description("When you see a meme.")]
                public async Task SeeMeme(CommandContext ctx)
                {
                    await ctx.TriggerTypingAsync();

                    // wrap it into an embed
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "When you see a meme",
                        ImageUrl = "http://i.imgur.com/8GD0hbZ.jpg"
                    };
                    await ctx.RespondAsync(embed: embed);
                }

                [Command("thisis"), Description("This is meme man.")]
                public async Task ThisIs(CommandContext ctx)
                {
                    await ctx.TriggerTypingAsync();

                    // wrap it into an embed
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "This is meme man",
                        ImageUrl = "http://i.imgur.com/57vDOe6.png"
                    };
                    await ctx.RespondAsync(embed: embed);
                }

                [Command("deepdream"), Description("Deepdream'd meme man.")]
                public async Task DeepDream(CommandContext ctx)
                {
                    await ctx.TriggerTypingAsync();

                    // wrap it into an embed
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "Deep dream",
                        ImageUrl = "http://i.imgur.com/U666J6x.png"
                    };
                    await ctx.RespondAsync(embed: embed);
                }

                [Command("sword"), Description("Meme with a sword?")]
                public async Task Sword(CommandContext ctx)
                {
                    await ctx.TriggerTypingAsync();

                    // wrap it into an embed
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "Meme with a sword?",
                        ImageUrl = "http://i.imgur.com/T3FMXdu.png"
                    };
                    await ctx.RespondAsync(embed: embed);
                }

                [Command("christmas"), Description("Beneath the christmas spike...")]
                public async Task ChristmasSpike(CommandContext ctx)
                {
                    await ctx.TriggerTypingAsync();

                    // wrap it into an embed
                    var embed = new DiscordEmbedBuilder
                    {
                        Title = "Christmas spike",
                        ImageUrl = "http://i.imgur.com/uXIqUS7.png"
                    };
                    await ctx.RespondAsync(embed: embed);
                }
            }
        }
    }
}
