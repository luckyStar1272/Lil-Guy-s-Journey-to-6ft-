using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardNamespace;

//MANAGES PLAYER DECK OF CARD OBJECTS.

public class PlayerDeckManager : MonoBehaviour
{
    //card prefab.
    public GameObject cardPrefab;

    //player deck.
    List<GameObject> playerDeck = new List<GameObject>();

    //starting amount of cards the player starts with.
    int startingDeckSize = 5; 

    //cards currently still in hand.
    int curDeckSize;

    //max. amount of cards player can carry.
    int maxDeckSize = 20;

    // spawns cards to fill the player's deck (gameobject list).
    public void Start() {
        for(int i = 0; i < startingDeckSize; i++) {
        }
    }

    //display ALL cards to choose from in hand.
    public void DisplayHand() {

    }
}
