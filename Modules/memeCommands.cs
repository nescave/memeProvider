using Discord.Commands;
using Discord;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace alternativeBot.Modules
{
    public class memeCommands :  ModuleBase<SocketCommandContext>
    {
        //BY THE POPE!
        [Command("pope")]
        public async Task popeAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/attachments/327186803595411456/493413712796057602/emoji.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            //await Context.Channel.DeleteMessagesAsync(Context.Message.);
            //await ReplyAsync($"{Context.Message.Author.Mention}");
            await ReplyAsync("", false, embed);
        }
        [Command("<:by_the_pope:493411746002894864>")]
        public async Task popeEmoteAsync()
        {
            await popeAsync();
        }

        //GONTTA
        [Command("gontta")]
        public async Task gonttaAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/417747336287223828.png?v=1")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            //await Context.Channel.DeleteMessagesAsync(Context.Message.);
            //await ReplyAsync($"{Context.Message.Author.Mention}");
            await ReplyAsync("", false, embed);
        }
        [Command("<:Gontta:417747336287223828>")]
        public async Task gonttaEmoteAsync()
        {
            await gonttaAsync();
        }


        //ALKUS
        [Command("alkus")]
        public async Task alkusAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/334775515263270912.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            //await Context.Channel.DeleteMessagesAsync(Context.Message.);
            //await ReplyAsync($"{Context.Message.Author.Mention}");
            await ReplyAsync("", false, embed);
        }
        [Command("<:ALKUS:334775515263270912>")]
        public async Task alkusEmoteAsync()
        {
            await alkusAsync();
        }


        //NOTAK
        [Command("notak")]
        public async Task notakAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/403267331264086016.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            //await Context.Channel.DeleteMessagesAsync(Context.Message.);
            //await ReplyAsync($"{Context.Message.Author.Mention}");
            await ReplyAsync("", false, embed);
        }
        [Command("<:notak:403267331264086016>")]
        public async Task notakEmoteAsync()
        {
            await notakAsync();
        }


        //HEH
        [Command("heh")]
        public async Task hehAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/333585033204072458.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            //await Context.Channel.DeleteMessagesAsync(Context.Message.);
            //await ReplyAsync($"{Context.Message.Author.Mention}");
            await ReplyAsync("", false, embed);
        }
        [Command("<:heh:333585033204072458>")]
        public async Task hehEmoteAsync()
        {
            await hehAsync();
        }


        //DAMNWHAT
        [Command("damnwhat")]
        public async Task damnwhatAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/attachments/327186803595411456/517850761871228942/14bc742b59a690d5eb4ca176a6211c51.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            //await Context.Channel.DeleteMessagesAsync(Context.Message.);
            //await ReplyAsync($"{Context.Message.Author.Mention}");
            await ReplyAsync("", false, embed);
        }
        [Command("<:damnwhat:413093188178411520>")]
        public async Task damnwhatEmoteAsync()
        {
            await damnwhatAsync();
        }


        //orbit
        [Command("orbit")]
        public async Task orbitAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/attachments/439121299512754178/439121684537278485/output_cSHCwX.gif")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            //await Context.Channel.DeleteMessagesAsync(Context.Message.);
            //await ReplyAsync($"{Context.Message.Author.Mention}");
            await ReplyAsync("", false, embed);
        }

        [Command("fu")]
        public async Task fuAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/425310386292523008.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            //await Context.Channel.DeleteMessagesAsync(Context.Message.);
            //await ReplyAsync($"{Context.Message.Author.Mention}");
            await ReplyAsync("", false, embed);
        }
        [Command("<:mioush:425310386292523008>")]
        public async Task mioushEmoteAsync()
        {
            await fuAsync();
        }
    }
}