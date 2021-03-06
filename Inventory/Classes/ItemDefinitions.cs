﻿using System.Collections.Generic;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using Inventory.ItemTypes;

namespace Inventory.Classes
{
    public enum ItemID
    {
        Armor_Tier1 = 0,
        Armor_Tier2,
        Armor_Tier3,
        Armor_Tier4,
        Armor_Tier5,

        Weapon_CombatPistol = 10,
        Weapon_PumpShotgun,
        Weapon_CarbineRifle,
        Weapon_SniperRifle,

        Skin_Agent14 = 100,
        Skin_Trevor,
        Skin_Michael,
        Skin_Franklin
    }

    public class ItemDefinitions
    {
        public static Dictionary<ItemID, BaseItem> ItemDictionary = new Dictionary<ItemID, BaseItem>
        {
            { ItemID.Armor_Tier1, new ArmorItem("Super Light Armor", "+20 armor.", 3, 20, new WorldModel("prop_armour_pickup", new Vector3(0.0, 0.0, 0.1), new Vector3(-90.0, 0.0, 0.0))) },
            { ItemID.Armor_Tier2, new ArmorItem("Light Armor", "+40 armor.", 2, 40, new WorldModel("prop_bodyarmour_02", new Vector3(0.0, 0.0, 0.125), new Vector3(-90.0, 0.0, 0.0))) },
            { ItemID.Armor_Tier3, new ArmorItem("Standard Armor", "+60 armor.", 2, 60, new WorldModel("prop_bodyarmour_03", new Vector3(0.0, 0.0, 0.125), new Vector3(-90.0, 0.0, 0.0))) },
            { ItemID.Armor_Tier4, new ArmorItem("Heavy Armor", "+80 armor.", 1, 80, new WorldModel("prop_bodyarmour_04", new Vector3(0.0, 0.0, 0.125), new Vector3(-90.0, 0.0, 0.0))) },
            { ItemID.Armor_Tier5, new ArmorItem("Super Heavy Armor", "+100 armor.", 1, 100, new WorldModel("prop_bodyarmour_05", new Vector3(0.0, 0.0, 0.125), new Vector3(-90.0, 0.0, 0.0))) },

            { ItemID.Weapon_CombatPistol, new WeaponItem("Combat Pistol", "A compact, lightweight, semi-automatic pistol.", 1, WeaponHash.CombatPistol, new WorldModel("w_pi_combatpistol", new Vector3(0.0, 0.0, 0.15), new Vector3())) },
            { ItemID.Weapon_PumpShotgun, new WeaponItem("Pump Shotgun", "Standard shotgun ideal for short-range combat.", 1, WeaponHash.PumpShotgun, new WorldModel("w_sg_pumpshotgun", new Vector3(0.0, 0.0, 0.15), new Vector3())) },
            { ItemID.Weapon_CarbineRifle, new WeaponItem("Carbine Rifle", "Combining long distance accuracy with a high-capacity magazine, the carbine rifle can be relied on to make the hit.", 1, WeaponHash.CarbineRifle, new WorldModel("w_ar_carbinerifle", new Vector3(0.0, 0.0, 0.15), new Vector3())) },
            { ItemID.Weapon_SniperRifle, new WeaponItem("Sniper Rifle", "Standard sniper rifle. Ideal for situations that require accuracy at long range. Limitations include slow reload speed and very low rate of fire.", 1, WeaponHash.SniperRifle, new WorldModel("w_sr_sniperrifle", new Vector3(0.0, 0.0, 0.15), new Vector3())) },

            { ItemID.Skin_Agent14, new SkinItem("Agent 14 Skin", "Will set your model to Agent 14.", 5, PedHash.Agent14) },
            { ItemID.Skin_Trevor, new SkinItem("Trevor Skin", "Will set your model to Trevor.", 5, PedHash.Trevor) },
            { ItemID.Skin_Michael, new SkinItem("Michael Skin", "Will set your model to Michael.", 5, PedHash.Michael) },
            { ItemID.Skin_Franklin, new SkinItem("Franklin Skin", "Will set your model to Franklin.", 5, PedHash.Franklin) }
        };
    }
}
