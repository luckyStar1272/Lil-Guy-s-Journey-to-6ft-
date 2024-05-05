using System.Collections.Generic;
using UnityEngine;
using CardNamespace;

//MANAGES PLAYER DECK OF CARD OBJECTS.

public class PlayerDeckManager : MonoBehaviour
{
    bool startLv = true;

    //starting amount of cards the player starts with.
    int startingDeckSize = 5;

    int curDeckSize = 0;

    //max. amount of cards player can carry.
    int maxDeckSize = 20;

    // card spawner game object to create deck.
    [SerializeField] CardSpawner cs;

    // player deck.
    List<Card> playerDeck = new List<Card>();

    // player hand; cards that haven't been played yet.
    List<GameObject> playerHand = new List<GameObject>();

    // spawns cards to fill the player's hand and deck.
    public void Start() {
        for(int i = 0; i < startingDeckSize; i++) {
            GameObject newCard = cs.SpawnCard("player deck");
            Card newCardData = newCard.GetComponent<CardDisplay>().cardData;

            playerHand.Add(newCard);
            playerDeck.Add(newCardData);
        }
        curDeckSize = startingDeckSize;
    }

    /*public void AddCard() {
        GameObject newCard = cs.SpawnCard("player deck");
        Card newCardData = newCard.GetComponent<CardDisplay>().cardData;

        playerHand.Add(newCard);
        playerDeck.Add(newCardData);
    }*/
}