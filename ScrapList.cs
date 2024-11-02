using System;
using UnityEngine;

namespace AbelMuak.Libs.LethalHelper
{
    [Serializable]
    public struct ScrapInfo
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

    [CreateAssetMenu(fileName = "ScrapList", menuName = "Abel/Scrap list", order = 0)]
    public class ScrapList : ScriptableObject
    {
        public ScrapInfo[] ScrapInfos;
    }

}


