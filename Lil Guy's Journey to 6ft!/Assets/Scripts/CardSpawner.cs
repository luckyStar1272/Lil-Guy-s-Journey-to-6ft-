using UnityEngine;
using CardNamespace;
using System;
using Random = UnityEngine.Random;

// SPAWNS/CREATES CARDS FOR PLAYER DECKS, ENEMY DECKS, AND TREASURE REWARDS.

public class CardSpawner : MonoBehaviour
{
    // game object of card prefab.
    [SerializeField] GameObject cardPrefab;

    // parent game object for card game object.
    [SerializeField] Transform playerDeckContent;

    // arrays of Card data.
    [SerializeField] Card[] enemyCardData; // ordered by rank = S, A, B, C.
    [SerializeField] Card[] familiarCardData; // ordered by rank = A, B, C.
    [SerializeField] Card[] rewardCardData; // order = equipment, spells, items.

    // card data.
    CardDisplay cardData;

    // enemy card drop rates that change as the player progresses through the levels.
    float[] enemyDropRates = {0.03f, 0.07f, 0.10f, 0.80f}; // drop rate for: S, A, B, C.

    // familiar card drop rates.
    float[] familiarDropRates = {0.02f, 0.02f, 0.02f, 0.02f, 0.02f, 0.05f, 0.05f, 0.05f, 0.05f, 0.05f, 0.13f, 0.13f, 0.13f, 0.13f, 0.13f}; // drop rate for: A , B, C; (each element).

    // reward and shop card drop rates.
    float[] rewardDropRates = {0.125f, 0.125f, 0.05f, 0.05f, 0.05f, 0.0875f, 0.0875f, 0.0875f, 0.0875f}; // drop rate for: equip, spell, item [will get cards from the familiar card data array]

    // instantiates or spawns a card prefab clone.
    public GameObject SpawnCard(String deckType) {
        // spawns however many cards specified
        GameObject newCard = Instantiate(cardPrefab);
        cardData = newCard.GetComponent<CardDisplay>();
        float chance = Random.Range(0.0f, 1.0f);

        // assigns card data based on draw rate and deck type.
        switch(deckType) {
            case "enemy deck":
                cardData.cardData = PickEnemyCard(chance);
                newCard.tag = "In Enemy Deck";
                break;
            case "player deck":
                cardData.cardData = PickFamiliarCard(chance);
                newCard.tag = "In Player Deck";
                // sets card as a child to content in player deck scroll view.
                newCard.transform.SetParent(playerDeckContent, false);
                newCard.transform.localScale = new Vector3(2f, 2f, 2f);
                break;
            case "reward/shop deck":
                cardData.cardData = PickRewardCard(chance);
                break;
        }

        // returns card to be added to deck/hand.
        return newCard;
    }

    // returns a Card SO for enemy card based on drop rates of cards and deck type.
    Card PickEnemyCard(float randChance) {
        float totalDropRate = 0.0f;
        int i = 0;

        // picks index based on drop rate,
        foreach(float dr in enemyDropRates) {
            totalDropRate += dr;
            if(randChance <= totalDropRate) {
                break;
            }
            i++;
        }
        return enemyCardData[i];
    }

    // returns a Card SO for familiar card based on drop rates of cards and deck type.
    Card PickFamiliarCard(float randChance) {
        float totalDropRate = 0.0f;
        int i = 0;

        // picks index based on drop rate,
        foreach(float dr in familiarDropRates) {
            totalDropRate += dr;
            if(randChance <= totalDropRate) {
                break;
            }
            i++;
        }
        return familiarCardData[i];
    }

    // returns a Card SO for reward card based on drop rates of cards and deck type.
    Card PickRewardCard(float randChance) {
        float totalDropRate = 0.0f;
        int i = 0;
        Boolean foundCard = false;

        // picks index based on drop rate,
        foreach(float dr in rewardDropRates) {
            totalDropRate += dr;
            if(randChance <= totalDropRate) {
                foundCard = true; //if not found, will call PickFamiliarCard() as a reward.
                break;
            }
            i++;
        }

        if(foundCard) {
            return rewardCardData[i];
        }
        else {
            float chance = Random.Range(0.0f, 1.0f);
            return PickFamiliarCard(chance);
        }
    }
}
