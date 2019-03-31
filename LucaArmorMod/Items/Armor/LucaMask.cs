using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LucaArmorMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class LucaMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Lucario Mask");
			Tooltip.SetDefault("Wear to impersonate a Pokémon.");
		}

		public override void SetDefaults()
		{
         		item.width = 22;
        		item.height = 24;
         		item.value = 10000;
         		item.rare = 7;
         		item.vanity = true;
		}
	}
}