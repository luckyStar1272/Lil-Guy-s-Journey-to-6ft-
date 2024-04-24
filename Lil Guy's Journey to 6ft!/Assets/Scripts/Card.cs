using System;
using UnityEngine;

//CONTAINS SCRIPTABLE CARD OBJECTS INFO.

namespace CardNamespace {
    [CreateAssetMenu(menuName = "New Card")]

    public class Card : ScriptableObject
    {
        [Header("Card Stats:")]
        
        //card name.
        public new string name;
        
        //card health.
        public int health;
        
        //card's attack damage.
        public int atkDmg;
        
        //card's type.
        public CardType type;
        
        //card's rank.
        public CardRank rank;
        
        //boolean to see if card has an ability.
        public Boolean hasAbility;
        
        //card's ability name.
        public string abilityName;
        
        //description for the card's ability if they have one.
        public string cardDescription;
        
        //MP cost to use card's ability.
        public int abilityCost;
        
        //card's value; enemy reward value, sell value, and buy value.
        public int cardValue;

        //sprite/image of card.    
        public Sprite cardImg;

        //card's current status.
        public CardStat status;

        public enum CardType {enemy, fireFamiliar, waterFamiliar, earthFamiliar, lightFamiliar, darkFamiliar, item, equip, spell}

        public enum CardRank {C, B, A, S}

        public enum CardStat {alive, dead, poisoned, atkUp, hpUp, magicSealed, other}
    }
}
