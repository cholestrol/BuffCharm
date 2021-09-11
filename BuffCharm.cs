using BuffCharm.UI;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace BuffCharm
{
	public class BuffCharm : Mod
	{
        public static BuffCharm ModInstance;
        public static List<int> Charms = new List<int>();

        public CharmUI CharmUIInstance;

        private UserInterface userInterface;

        public override void Load()
        {
            ModInstance = this;
            if (!Main.dedServ)
            {
                userInterface = new UserInterface();
                CharmUIInstance = new CharmUI();
                CharmUIInstance.Activate();
                userInterface.SetState(CharmUIInstance);
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int inventoryLayer = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Inventory"));
            if (inventoryLayer != -1)
            {
                layers.Insert(
                    inventoryLayer,
                    new LegacyGameInterfaceLayer("BuffCharm: Charms", () => {
                        if (CharmUIInstance.Visible)
                        {
                            userInterface.Draw(Main.spriteBatch, new GameTime());
                        }
                        return true;
                    },
                    InterfaceScaleType.UI));
            }
        }
    }
}