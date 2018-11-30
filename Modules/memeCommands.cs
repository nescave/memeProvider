using Discord.Commands;
using Discord;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace memeProvider.Modules
{
    public class memeCommands :  ModuleBase<SocketCommandContext>
    {

        //BY THE POPE!
        [Command("pope"), Alias("<:by_the_pope:493411746002894864>")]
        public async Task popeAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/attachments/327186803595411456/493413712796057602/emoji.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }

        //GONTTA
        [Command("gontta"), Alias("<:Gontta:417747336287223828>")]
        public async Task gonttaAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/417747336287223828.png?v=1")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }
    
        //ALKUS
        [Command("alkus"), Alias("<:ALKUS:334775515263270912>")]
        public async Task alkusAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/334775515263270912.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }

        //NOTAK
        [Command("notak"), Alias("<:notak:403267331264086016>")]
        public async Task notakAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/403267331264086016.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }

        //HEH
        [Command("heh"), Alias("<:heh:333585033204072458>")]
        public async Task hehAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/333585033204072458.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }

        //DAMNWHAT
        [Command("damnwhat"), Alias("<:damnwhat:413093188178411520>")]
        public async Task damnwhatAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/attachments/327186803595411456/517850761871228942/14bc742b59a690d5eb4ca176a6211c51.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }

        //orbit
        [Command("orbit")]
        public async Task orbitAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/attachments/439121299512754178/439121684537278485/output_cSHCwX.gif")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }


        //FUUU
        [Command("fu"), Alias("<:mioush:425310386292523008>")]
        public async Task fuAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/425310386292523008.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }
        
        //SZOGUN
        [Command("szogun"), Alias("<:szogun:329021218512437268>")]
        public async Task szogunAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/329021218512437268.png?v=1")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }
                
        //WOJOWNICY
        [Command("woj"), Alias("<:Wojownicy:327477498680049667>")]
        public async Task wojownicyAsync()
        {
            var embed = new EmbedBuilder();
            embed.WithImageUrl("https://cdn.discordapp.com/emojis/327477498680049667.png")
                .WithAuthor(Context.Message.Author);

            await Context.Message.DeleteAsync();
            await ReplyAsync("", false, embed);
        }
    }
}