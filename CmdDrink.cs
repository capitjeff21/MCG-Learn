using System;
using MCGalaxy;
using System.Collections.Generic;
namespace MCGalaxy.Commands.Chatting{
    public sealed class CmdDrink : MessageCmd
    {
        public override string name { get { return "Drink"; } }
        public override string type { get { return "other"; } }

        public override void Use(Player p, string message, CommandData data)
        {
          var drinkMessages = new List<string>() { " drank lemonade", " drank water", " drank milk", " drank soda" };
          var random = new Random();
        int index = random.Next(drinkMessages.Count);
        Chat.MessageGlobal(p.name + drinkMessages[index]);
        }

        public override void Help(Player p) {
            p.Message("%T/Drink %H- Drinks a random drink.");
        }
    }
}