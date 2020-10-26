using System;
using MCGalaxy;

namespace MCGalaxy.Commands.Chatting {
	public sealed class CmdCry : MessageCmd {
			public override string name { get { return "Cry"; } }
			
			public override void Use(Player p, string message, CommandData data) {
				TryMessageAction(p, message, "λNICK %Sis crying because of λTARGET", true);
			}

			public override void Help(Player p) {
				p.Message("%T/Cry <player> - cry, optionally because of <player>");
			}
		}
	}
