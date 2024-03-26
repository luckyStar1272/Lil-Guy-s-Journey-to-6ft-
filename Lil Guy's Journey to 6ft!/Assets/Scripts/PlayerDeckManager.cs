using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardNamespace;

public class PlayerDeckManager : MonoBehaviour
{
    //card prefab.
    public GameObject cardPrefab;

    //starting amount of cards the player starts with.
    int startingDeckSize = 5; 

    //cards currently still in hand.
    int curDeckSize;

    //max. amount of cards player can carry.
    int maxDeckSize = 20;

    //random index to get a random card from gameDeck.
    int randomIdx;

    //ALL possible cards in the game. [ALL CARDS IN THE GAME]
    public List<Card> familiarDeck = new List<Card>();
    //public List<Card> itemDeck;
    //public List<Card> spellDeck;
    //public List<Card> enemyDeck;

    //cards in a player's deck. [ALL CARDS THE PLAYER HAS]
    //public List<Card> playerDeck = new List<Card>();

    //cards currently in a player's hand. [WHAT THE PLAYER SEES]
    //public List<GameObject> playerHand = new List<GameObject>();

    public void Start() {
        //gets a random index number to pick a random card.
        randomIdx = (int)Random.Range(0f,familiarDeck.Count);

        //draws 5 random cards to start with.
        for(int i = 0; i < startingDeckSize; i++) {
            Card randomCard = familiarDeck[i];

            GameObject newCard = Instantiate(cardPrefab, transform);
            newCard.GetComponent<CardDisplay>().cardData = randomCard;
        }
    }

    //display ALL cards to choose from in hand.
    public void displayHand() {

    }
}
