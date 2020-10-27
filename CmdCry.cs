using System;
using MCGalaxy;

namespace MCGalaxy.Commands.Chatting {
	public sealed class CmdCry : MessageCmd {
			public override string name { get { return "Cry"; } }
			
			public override void Use(Player p, string message, CommandData data) {
				Player target = PlayerInfo.FindMatches(p, name);
				if (target == null) {
					Chat.MessageGlobal(p.name + " is crying");
				} else{
				Chat.MessageGlobal(p.name + " is crying because of " + target.name);
			}}

			public override void Help(Player p) {
				p.Message("%T/Cry <player> - cry, optionally because of <player>");
			}
		}
	}
