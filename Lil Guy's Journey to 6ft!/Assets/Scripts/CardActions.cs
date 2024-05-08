using UnityEngine;
using TMPro;
using CardNamespace;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

// METHODS FOR CARD DROPDOWN ACTIONS; PERFORMS ACTIONS.

public class CardActions : MonoBehaviour, ISelectHandler
{
    // dropdown component.
    TMP_Dropdown dropDownComponent;

    // card data.
    public CardDisplay cardData;

    // card holder selectable components.
    List<Selectable> enemyCardHoldersS, playerCardHoldersAS, playerCardHoldersBS;

    // list of actions the do after the player ends their turn.
    public static List<String> playerActionsQueue = new List<String>();

    // initialize variables.
    void Awake() {
        dropDownComponent = GetComponent<TMP_Dropdown>();

        enemyCardHoldersS = new List<Selectable>();
        playerCardHoldersAS = new List<Selectable>();
        playerCardHoldersBS = new List<Selectable>();
    }

    void Start() {
        dropDownComponent.onValueChanged.AddListener(delegate {performAction(dropDownComponent);});

        // get all selectable components from card holder game objects.
        foreach(GameObject cardHolder in FindObjectsOfType(typeof(GameObject))) {
            if(cardHolder.name == "Player Card Holder A(Clone)") {
                playerCardHoldersAS.Add(cardHolder.GetComponent<Selectable>());
            }
            else if(cardHolder.name == "Player Card Holder B(Clone)") {
                playerCardHoldersBS.Add(cardHolder.GetComponent<Selectable>());
            }
            else if(cardHolder.name == "Enemy Card Holder(Clone)") {
                enemyCardHoldersS.Add(cardHolder.GetComponent<Selectable>());
            }
        }
    }

    public void OnSelect(BaseEventData eventData) {
        GetComponent<AudioSource>().Play();
    }

    // call method for the action clicked.
    void performAction(TMP_Dropdown dropdown)
    {
        // FIX!
        switch(dropdown.value) {
            case 1:
                // places card on an empty spot.
                PlayCard();
                break;
            case 2:
                // assigns card to attack an enemy card.
                Attack();
                break;
            case 3:
                // assign card to use ability.
                ActivateAbility();
                break;
            case 4:
                UseItem();
                break;
            case 5:
                CastSpell();
                break;
        }
    }

    public void PlayCard() {
        Debug.Log("play card chosen.");
        
        // will stop action if card is NOT in the deck/hand.
        if(cardData.tag != "In Player Deck") {
            dropDownComponent.value = 0;
        }
        else {
            // will make the correct card holders selectable depending on card type.
            switch(cardData.GetCardType()) {
                case Card.CardType.item:
                case Card.CardType.equip:
                case Card.CardType.spell:
                    // enable all empty player card holder B selectables.
                    foreach(Selectable cardHolder in playerCardHoldersBS) {
                        cardHolder.interactable = cardHolder.tag == "Empty" ? true : false;
                    }
                    // disable all player card holder A selectables.
                    foreach(Selectable cardHolder in playerCardHoldersAS) {
                        cardHolder.interactable = false;
                    }
                    // disable all enemy card holder selectables.
                    foreach(Selectable cardHolder in enemyCardHoldersS) {
                        cardHolder.interactable = false;
                    }
                    break;
                case Card.CardType.darkFamiliar:
                case Card.CardType.lightFamiliar:
                case Card.CardType.earthFamiliar:
                case Card.CardType.waterFamiliar:
                case Card.CardType.fireFamiliar:
                    // enable all empty player card holder A selectables.
                    foreach(Selectable cardHolder in playerCardHoldersAS) {
                        cardHolder.interactable = cardHolder.tag == "Empty" ? true : false;
                    }
                    // disable all player card holder B selectables.
                    foreach(Selectable cardHolder in playerCardHoldersBS) {
                        cardHolder.interactable = false;
                    }
                    // disable all enemy card holder selectables.
                    foreach(Selectable cardHolder in enemyCardHoldersS) {
                        cardHolder.interactable = false;
                    }
                    break;
            }
            MoveCardToField();
        }
    }

    // moves card in PlayerCardHolderManager.cs OnSelect().
    public void MoveCardToField() {
        GameObject card = gameObject.transform.parent.gameObject;
        card.transform.SetParent(this.transform, false);
        Debug.Log("card: "+card);
        Debug.Log("current selected game object: "+EventSystem.current.currentSelectedGameObject.transform);
    }

    public void Attack() {
        Debug.Log("attack chosen.");

        // returns if the card is in the player's deck; cannot perform action.
        if(cardData.tag == "In Player Deck") {
            return;
        }
    }

    public void ActivateAbility() {
        Debug.Log("activate ability chosen.");
        
        // returns if the card is in the player's deck; cannot perform action.
        if(cardData.tag == "In Player Deck") {
            return;
        }
    }

    public void UseItem() {
        Debug.Log("use item chosen.");
        
        // returns if the card is in the player's deck; cannot perform action.
        if(cardData.tag == "In Player Deck") {
            return;
        }
    }

    public void CastSpell() {
        Debug.Log("cast spell chosen.");
        
        // returns if the card is in the player's deck; cannot perform action.
        if(cardData.tag == "In Player Deck") {
            return;
        }
    }
}
