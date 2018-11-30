using Discord.Commands;
using Discord;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Linq;

namespace memeProvider.Modules
{
    public class usefullCommands :  ModuleBase<SocketCommandContext>
    {
        
        [Command("del")]
        public async Task delTenAsync(int quant = 1){
            var messagesToDel = await Context.Channel.GetMessagesAsync(quant +1).Flatten();
            await Context.Channel.DeleteMessagesAsync(messagesToDel);
            await Context.Channel.SendMessageAsync($"10 Last messages purged! {Context.User.Username}");
            await Task.Delay(2000);
            messagesToDel = await Context.Channel.GetMessagesAsync(1).Flatten();
            await Context.Channel.DeleteMessagesAsync(messagesToDel);
        }
        [Command("help")]
        public async Task help(string isLocal = null)
        {
            var privateEmbed = new Discord.EmbedBuilder();
            var publicEmbed = new Discord.EmbedBuilder();
            privateEmbed.WithTitle("Lista komend:")
                .AddInlineField("!komeny", "!orbit \n!orbit2 \n!orbit3 \n!orbitmax\n!Wojownicy \n!szogun \n!pikna \n!notak \n!mioush \n!jordan_cry \n!heh \n!Gontta \n!damnwhat \n!by_the_pope \n!biiiicz \n!ALKUS")
                .AddField("usefullShiet", "!help // wysyla sms o tresci pomagam \n (-p jesli chcesz na publiczny kanal help) \n !del x //usówa x ostatnich wiadomości ");
            publicEmbed.WithTitle("Lista komend:")
                .AddInlineField("!komendy", "!orbit \n!orbit2 \n!orbit3 \n!orbitmax\n!Wojownicy \n!szogun \n!pikna \n!notak \n!mioush \n!jordan_cry \n!heh \n!Gontta \n!damnwhat \n!by_the_pope \n!biiiicz \n!ALKUS")
                .AddInlineField("Emotki",  "\n\n\n :Wojownicy: \n :szogun: \n :pikna: \n <:notak:403267331264086016> \n <:mioush:425310386292523008> \n :jordan_cry: \n <:heh:333585033204072458> \n <:Gontta:417747336287223828> \n <:damnwhat:413093188178411520> \n <:by_the_pope:493411746002894864> \n :biiiicz: \n <:ALKUS:334775515263270912>")
                .AddField("usefullShiet", "!help // wysyla sms o tresci pomagam \n (-p jesli chcesz na publiczny kanal help) \n !del x //usówa x ostatnich wiadomości ");
            if (isLocal != "-p"){
                Discord.IDMChannel gencom = await Context.Message.Author.GetOrCreateDMChannelAsync();
                await gencom.SendMessageAsync("", false, privateEmbed);
                await gencom.CloseAsync();
            }else
            for (int helpChannelID = 0; helpChannelID < Context.Guild.TextChannels.Count; helpChannelID++){
                var helpChannel = Context.Guild.TextChannels.ElementAt(helpChannelID); 
                if(helpChannel.Name == "help")          
                    await helpChannel.SendMessageAsync("", false, publicEmbed);
            }
        }
    }
}