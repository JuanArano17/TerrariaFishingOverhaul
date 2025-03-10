﻿using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace TerrariaFishingOverhaul.Content.Items.FishingRods
{
	public class FrozenFishingPole : ModFishingRod
	{
		public int bobberAmount = 1;
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Frozen Fishing Pole");
			Tooltip.SetDefault("");

		}

		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.fishingPole = 30; // Sets the poles fishing power
			Item.shootSpeed = 13f; // Sets the speed in which the bobbers are launched. Wooden Fishing Pole is 9f and Golden Fishing Rod is 17f.
			Item.shoot = ModContent.ProjectileType<Projectiles.FrozenBobber>(); // The Bobber projectile.
		}

		public override void HoldItem(Player player)
		{
			base.HoldItem(player);
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CopperBar, 15);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
	}
}
