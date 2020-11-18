using System;
using System.Collections.Generic;
using System.Text;

namespace TheresaFacts
{
    public class TheresaFactData
    {
        public TheresaFactData()
        {
        }
        public static IEnumerable<TheresaFactData> All { private set; get; }
        public string Image { get; set; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        
        static TheresaFactData()
        {
            List<TheresaFactData> all = new List<TheresaFactData>();
         
            all.Add(new TheresaFactData() { 
                Image = "rex.png",
                TheFact = "I have a little Chihuahua named Rex.  He is 10 years old.", 
                ShortFact = "My Dog" });
            all.Add(new TheresaFactData() { Image = "guitar.png",
                TheFact = "I have been playing guitar for 33 years. My favorite style of music to play on guitar is Metal.", 
                ShortFact = "Guitar" });
            all.Add(new TheresaFactData() { 
                Image = "violin.png",
                TheFact = "I have been playing violin for 20 years. My main violin is almost 200 years old, and I named it Monti after the composer of the first peice I played on it - 'Czardas' by Vittorio Monti.", 
                ShortFact = "Violin" });
            all.Add(new TheresaFactData() { 
                Image = "jack.png",
                TheFact = "I was taught by famous local jazz guitar virtuoso, Jack Grassel.", 
                ShortFact = "Best Guitar Teacher" });
            all.Add(new TheresaFactData() { 
                Image = "tam.png",
                TheFact = "My gaming handle and World of Warcraft main character is Tamino, who is the main character in Mozart's 'Magic Flute'.",
                ShortFact = "Tamino" });
            all.Add(new TheresaFactData() { 
                Image = "bavaria.png",
                TheFact = "My last name is Bavarian German.", 
                ShortFact = "Bollhagen" });
            all.Add(new TheresaFactData()
            {
                Image = "whom.png",
                TheFact = "I teach guitar, violin, and viola at White House of Music. I will start developing for the company in January in addition to teaching.",
                ShortFact = "Work"
            });
            all.Add(new TheresaFactData()
            {
                Image = "wolf.png",
                TheFact = "If I could have a wild animal as a pet, it would be a wolf.",
                ShortFact = "Wolf"
            });
            All = all;

        }
    }
}
