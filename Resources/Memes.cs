using System;
using System.Collections.Generic;

namespace memeProvider.Resources
{
    public class Memes 
    {        
        public static Dictionary<string, Card> cards = new Dictionary<string, Card>();
        public static Dictionary<string,string> emotes = new Dictionary<string, string>();

        public static void EmotesDictionaryInit(){

            emotes.Add("pope", "<:by_the_pope:493411746002894864>");
            emotes.Add("gontta", "<:Gontta:417747336287223828>");
            emotes.Add("alkus", "<:ALKUS:334775515263270912>");
            emotes.Add("notak", "<:notak:403267331264086016>");
            emotes.Add("heh", "<:heh:333585033204072458>");
            emotes.Add("damnwhat", "<:damnwhat:413093188178411520>");
            emotes.Add("orbit", null);
            emotes.Add("fu", "<:mioush:425310386292523008>");
            emotes.Add("szogun", "<:szogun:329021218512437268>");
            emotes.Add("woj", "<:Wojownicy:327477498680049667>");
        } 

        public static void CardsDictionaryInit(){
            cards.Add("bicz", new Card("biiicz", 
            "https://cdn.discordapp.com/attachments/517488778718216193/518234165330837514/StopBitch.PNG", 
            "biiiicz description", 
            1));       
            cards.Add("timeToStop", new Card("stop", 
            "https://cdn.discordapp.com/attachments/517488778718216193/518236369529864193/TimeToStop.jpg", 
            "stop desc", 
            2));
            cards.Add("fuckYourOpinion", new Card("opinion",
            "https://cdn.discordapp.com/attachments/517488778718216193/518238813601005584/DXE5L2ZXkAE9Bsn.png",
            "opinion desc",
            3));
        }
    }
}