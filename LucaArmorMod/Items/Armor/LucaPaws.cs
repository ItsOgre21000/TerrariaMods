using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LucaArmorMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class LucaPaws : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Lucario Paws");
			Tooltip.SetDefault("Wear to impersonate a Pokémon.");
		}

		public override void SetDefaults()
		{
         		item.width = 14;
        		item.height = 20;
         		item.value = 10000;
         		item.rare = 7;
         		item.vanity = true;
		}
	}
}