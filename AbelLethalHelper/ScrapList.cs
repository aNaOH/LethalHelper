using System;
using System.Collections.Generic;
using UnityEngine;

namespace AbelMuak.Libs.LethalHelper
{

    [Serializable]
    public class ScrapInfo
    {
        public Item ItemDef;
        public int Rarity;
        public int LevelType;

        public ScrapInfo(Item ItemDef, int Rarity, int LevelType = -1)
        {
            this.ItemDef = ItemDef;
            this.Rarity = Rarity;
            this.LevelType = LevelType;
        }
    }

    public class ScrapInfoJSON
    {
        public string ItemDef;
        public int Rarity;
        public int LevelType;

        public ScrapInfoJSON(string ItemDef, int Rarity, int LevelType = -1)
        {
            this.ItemDef = ItemDef;
            this.Rarity = Rarity;
            this.LevelType = LevelType;
        }
    }

    [CreateAssetMenu(fileName = "ScrapList", menuName = "Abel/Scrap list", order = 0)]
    [Serializable]
    public class ScrapList : ScriptableObject
    {
        public List<ScrapInfo> ScrapInfos;
    }

}


