﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using bth.Items.Blocks;
using Terraria.DataStructures;

namespace bth.Tiles
{
    internal class crystalsandstone : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;

            ModTranslation name = CreateMapEntryName();
            AddMapEntry(Color.DarkOliveGreen, name);
            name.SetDefault("");
        }
        public override bool Drop(int i, int j)
        {
            Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 16, 16, ModContent.ItemType<CrystalSandstoneBlock>());
            return base.Drop(i, j);
        }
    }
}
