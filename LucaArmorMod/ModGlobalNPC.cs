using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LucaArmorMod
{
    class MyGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
		if(npc.type == NPCID.DungeonGuardian)
		{
            		Item.NewItem(npc.getRect(), mod.ItemType("LucaMask"));
            		Item.NewItem(npc.getRect(), mod.ItemType("LucaRobes"));
            		Item.NewItem(npc.getRect(), mod.ItemType("LucaPaws"));
		}
        }
    }
}