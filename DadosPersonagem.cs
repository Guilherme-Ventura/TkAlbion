using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkAlbion
{

    public class DadosPersonagem
    {
        public float AverageItemPower { get; set; }
        public Equipment Equipment { get; set; }
        public object[] Inventory { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string GuildName { get; set; }
        public string GuildId { get; set; }
        public string AllianceName { get; set; }
        public string AllianceId { get; set; }
        public string AllianceTag { get; set; }
        public string Avatar { get; set; }
        public string AvatarRing { get; set; }
        public int DeathFame { get; set; }
        public int KillFame { get; set; }
        public float FameRatio { get; set; }
        public Lifetimestatistics LifetimeStatistics { get; set; }
    }

    public class Equipment
    {
        public object MainHand { get; set; }
        public object OffHand { get; set; }
        public object Head { get; set; }
        public object Armor { get; set; }
        public object Shoes { get; set; }
        public object Bag { get; set; }
        public object Cape { get; set; }
        public object Mount { get; set; }
        public object Potion { get; set; }
        public object Food { get; set; }
    }

    public class Lifetimestatistics
    {
        public Pve PvE { get; set; }
        public Gathering Gathering { get; set; }
        public Crafting Crafting { get; set; }
        public int CrystalLeague { get; set; }
        public int FishingFame { get; set; }
        public int FarmingFame { get; set; }
        public DateTime Timestamp { get; set; }
    }

    public class Pve
    {
        public int Total { get; set; }
        public int Royal { get; set; }
        public int Outlands { get; set; }
        public int Avalon { get; set; }
        public int Hellgate { get; set; }
        public int CorruptedDungeon { get; set; }
    }

    public class Gathering
    {
        public Fiber Fiber { get; set; }
        public Hide Hide { get; set; }
        public Ore Ore { get; set; }
        public Rock Rock { get; set; }
        public Wood Wood { get; set; }
        public All All { get; set; }
    }

    public class Fiber
    {
        public int Total { get; set; }
        public int Royal { get; set; }
        public int Outlands { get; set; }
        public int Avalon { get; set; }
    }

    public class Hide
    {
        public int Total { get; set; }
        public int Royal { get; set; }
        public int Outlands { get; set; }
        public int Avalon { get; set; }
    }

    public class Ore
    {
        public int Total { get; set; }
        public int Royal { get; set; }
        public int Outlands { get; set; }
        public int Avalon { get; set; }
    }

    public class Rock
    {
        public int Total { get; set; }
        public int Royal { get; set; }
        public int Outlands { get; set; }
        public int Avalon { get; set; }
    }

    public class Wood
    {
        public int Total { get; set; }
        public int Royal { get; set; }
        public int Outlands { get; set; }
        public int Avalon { get; set; }
    }

    public class All
    {
        public int Total { get; set; }
        public int Royal { get; set; }
        public int Outlands { get; set; }
        public int Avalon { get; set; }
    }

    public class Crafting
    {
        public int Total { get; set; }
        public int Royal { get; set; }
        public int Outlands { get; set; }
        public int Avalon { get; set; }
    }
}

