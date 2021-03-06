﻿using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Shared;
using Inventory.Classes;
using Inventory.Interfaces;

namespace Inventory.ItemTypes
{
    public class WeaponItem : BaseItem, IDroppable
    {
        public WeaponHash Hash { get; set; }
        public WorldModel DropModel { get; set; }

        public WeaponItem(string name, string description, int stackSize, WeaponHash hash, WorldModel dropModel) : base(name, description, stackSize)
        {
            Hash = hash;
            DropModel = dropModel;
        }

        public override bool Use(Client player)
        {
            player.sendChatMessage($"Received weapon. ({Hash})");
            player.giveWeapon(Hash, 9999, true, true);
            return true;
        }
    }
}
