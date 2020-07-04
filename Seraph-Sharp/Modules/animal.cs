using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using Newtonsoft.Json;
using System.Net.Http;

namespace Seraph_Sharp.Modules
{
    [Group("animal", CanInvokeWithoutSubcommand = true)] // this makes the class a group, but with a twist; the class now needs an ExecuteGroupAsync method
    [Description("Contains some memes. When invoked without subcommand, returns a random one.")]
    [Aliases("aww")]
    public class AnimalCommands
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
            var nxt = rnd.Next(0, 3);

            switch (nxt)
            {
                case 0:
                    await Fox(ctx);
                    return;
                case 1:
                    await Dog(ctx);
                    return;
                case 2:
                    await Cat(ctx);
                    return;
            }
        }

        [Command("fox"), Description("Random cute fox images.")]
        public async Task Fox(CommandContext ctx)
        {

            using (var client = new HttpClient())
            {

                await ctx.TriggerTypingAsync();

                //Response from http request
                var response = await client.GetAsync($"https://randomfox.ca/floof/");
                //Console.WriteLine(response);

                //json = response;

                //content strign conversion
                var content = await response.Content.ReadAsStringAsync();

                //JSON conversion to string data
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                // wrap it into an embed
                var embed = new DiscordEmbedBuilder
                {
                    Title = "Daily dose of Foxes",
                    ImageUrl = item.image,
                    Url = item.link
                    
                };

                await ctx.RespondAsync(embed: embed);

            }
        }


        [Command("dog"), Description("Random cute dog images.")]
        public async Task Dog(CommandContext ctx)
        {

            using (var client = new HttpClient())
            {

                await ctx.TriggerTypingAsync();

                //Response from http request
                var response = await client.GetAsync($"https://dog.ceo/api/breeds/image/random");
                //Console.WriteLine(response);

                //json = response;

                //content strign conversion
                var content = await response.Content.ReadAsStringAsync();

                //JSON conversion to string data
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                // wrap it into an embed
                var embed = new DiscordEmbedBuilder
                {
                    Title = "Daily dose of Doggos",
                    ImageUrl = item.message,
                    Url = item.message

                };

                await ctx.RespondAsync(embed: embed);

            }
        }

        [Command("cat"), Description("Random cute cat images.")]
        public async Task Cat(CommandContext ctx)
        {

            using (var client = new HttpClient())
            {

                await ctx.TriggerTypingAsync();

                //Response from http request
                var response = await client.GetAsync($"https://api.thecatapi.com/v1/images/search");
                //Console.WriteLine(response);

                //json = response;

                //content strign conversion
                var content = await response.Content.ReadAsStringAsync();

                //JSON conversion to string data
                dynamic item = Newtonsoft.Json.JsonConvert.DeserializeObject(content);

                // wrap it into an embed
                var embed = new DiscordEmbedBuilder
                {
                    Title = "Daily dose of Cats",
                    ImageUrl = item[0].url,
                    Url = item[0].url

                };

                await ctx.RespondAsync(embed: embed);

            }
        }

    }

}
