using System;
using System.Collections.Generic;

namespace memeProvider.Resources
{
    public class Memes 
    {        
        public static Dictionary<string, Card> cards = new Dictionary<string, Card>();
        public static Dictionary<string,MyEmote> emotes = new Dictionary<string, MyEmote>();

        public static void EmotesDictionaryInit(){

            emotes.Add("pope", new MyEmote("<:by_the_pope:493411746002894864>",
            "https://cdn.discordapp.com/attachments/327186803595411456/493413712796057602/emoji.png"));
            emotes.Add("gontta", new MyEmote("<:Gontta:417747336287223828>", 
            "https://cdn.discordapp.com/emojis/417747336287223828.png?v=1"));
            emotes.Add("alkus", new MyEmote("<:ALKUS:334775515263270912>", 
            "https://cdn.discordapp.com/emojis/334775515263270912.png"));
            emotes.Add("notak", new MyEmote("<:notak:403267331264086016>", 
            "https://cdn.discordapp.com/emojis/403267331264086016.png"));
            emotes.Add("heh", new MyEmote("<:heh:333585033204072458>", 
            "https://cdn.discordapp.com/emojis/333585033204072458.png"));
            emotes.Add("damnwhat", new MyEmote("<:damnwhat:413093188178411520>", 
            "https://cdn.discordapp.com/attachments/327186803595411456/517850761871228942/14bc742b59a690d5eb4ca176a6211c51.png"));
            emotes.Add("orbit", new MyEmote("nullEmoteErrorCode404", 
            "https://cdn.discordapp.com/attachments/439121299512754178/439121684537278485/output_cSHCwX.gif"));
            emotes.Add("fu", new MyEmote("<:mioush:425310386292523008>", 
            "https://cdn.discordapp.com/emojis/425310386292523008.png"));
            emotes.Add("szogun", new MyEmote("<:szogun:329021218512437268>", 
            "https://cdn.discordapp.com/emojis/329021218512437268.png?v=1"));
            emotes.Add("woj", new MyEmote("<:Wojownicy:327477498680049667>", 
            "https://cdn.discordapp.com/emojis/327477498680049667.png"));
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