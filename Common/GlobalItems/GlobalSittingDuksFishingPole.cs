using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaFishingOverhaul.Common.GlobalItems
{
	public class GlobalSittingDuksFishingPole : GlobalItem
	{
		// Here we make sure to only instance this GlobalItem for the Copper Shortsword, by checking item.type
		public override bool AppliesToEntity(Item item, bool lateInstatiation) {
			return item.type == ItemID.SittingDucksFishingRod;
		}

		public override void SetDefaults(Item item) {
			item.StatsModifiedBy.Add(Mod); // Notify the game that we've made a functional change to this item.
		}

        public override bool Shoot(Item item, Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) {
			int bobberAmount = 1;
			float spreadAmount = 75f; // how much the different bobbers are spread out.

			for (int index = 0; index < bobberAmount; ++index) {
				Vector2 bobberSpeed = velocity + new Vector2(Main.rand.NextFloat(-spreadAmount, spreadAmount) * 0.05f, Main.rand.NextFloat(-spreadAmount, spreadAmount) * 0.05f);

				// Generate new bobbers
				Projectile.NewProjectile(source, position, bobberSpeed, type, 0, 0f, player.whoAmI);
			}
			return false;
		}
	}
}