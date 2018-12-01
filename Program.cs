using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using Microsoft.Extensions.DependencyInjection;

using Discord;
using Discord.WebSocket;
using Discord.Commands;
using memeProvider.Resources;

namespace memeProvider
{
	public class Program
	{

        Card dupa = new Card("asd", "asds", "asdaaa", 1);
        
		public static void Main(string[] args)
			=> new Program().MainAsync().GetAwaiter().GetResult();

        private string path = "..\\memeProvider\\Data\\Token.txt";
        private string token;
        public DiscordSocketClient _client;
        public CommandService _commands;
        public IServiceProvider _services;     

		public async Task MainAsync()
		{   
            Memes.CardsDictionaryInit();
            Memes.EmotesDictionaryInit();

            _client = new DiscordSocketClient();
            _commands = new CommandService();
            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();
             
            using (StreamReader streamReader = new StreamReader(path, true)){
                token = streamReader.ReadToEnd();
            }

            //events here
         	_client.Log += Log;
            _client.UserJoined += AnnounceUserJoined;


            await RegisterCommandsAsync();
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
	        await Task.Delay(-1);
		
            
        }
        private Task Log (LogMessage msg){
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
        public async Task RegisterCommandsAsync(){
            _client.MessageReceived += HandleCommandAsync;

            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }
        public async Task AnnounceUserJoined(SocketGuildUser arg){

            var guild = arg.Guild;
            var channel = guild.DefaultChannel;
            SocketRole role;
            string[] roleList = {
                "Moszna Boga",
                "Penis Boga",
                "Prawe Jajko Boga",
                "Lewe Jajko Boga"
            };
            for (int i = 0; i < arg.Roles.Count; i++){
                role = arg.Roles.ElementAt(i);
                for (int t = 0; t < roleList.Count(); t++)
                {
                    if(role.Name == roleList[t])
                        await channel.SendMessageAsync($"{arg.Mention}, just joined!");
                        return;
                }
            }
        }

        public async Task HandleCommandAsync(SocketMessage arg){
            var message = arg as SocketUserMessage;

            if (message is null || message.Author.IsBot)
                return;

            int argPos = 0;
            var tag =  message.Tags;
            bool containsEmoji = false;
            if (tag.Count != 0){
                containsEmoji = tag.ElementAt(0).ToString().Contains("Emoji");    //"Emoji", StringComparison.Ordinal); => netcoreapp 2.1 remains
            }
            
            if (message.HasStringPrefix("!", ref argPos) || containsEmoji){
                var context = new SocketCommandContext(_client, message);

                var result = await _commands.ExecuteAsync(context, argPos, _services);

                if (!result.IsSuccess)
                    Console.WriteLine(result.ErrorReason + "   ...thats fuckin why");
                    // await context.Message.Channel.SendMessageAsync("dzwoń po pomoc, bo nie ogarniasz (!help)");
                    // await Task.Delay(3000);
                    // var messagesToDel = await context.Channel.GetMessagesAsync(+1).Flatten();
                    // await context.Channel.DeleteMessagesAsync(messagesToDel);
            }
        }
	}
}