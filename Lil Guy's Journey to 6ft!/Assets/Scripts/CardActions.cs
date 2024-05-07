using UnityEngine;
using TMPro;
using CardNamespace;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

// METHODS FOR CARD DROPDOWN ACTIONS.

public class CardActions : MonoBehaviour
{
    // dropdown component.
    TMP_Dropdown dropDownComponent;

    // card data.
    public CardDisplay cardData;

    // card holder spawner.
    [SerializeField] CardHolderSpawner chs;

    // card holder arrays.
    GameObject[] enemyCardHolders = chs.cardHolders[0];
    GameObject[] playerCardHoldersA;
    GameObject[] playerCardHoldersB;
    
    // prefab of player familiar card holders.
    public GameObject playerCardHolderAPrefab;

    // prefab of player item/spell card holders.
    public GameObject playerCardHolderBPrefab;

    // selectable component for card holders.
    Selectable playerCardHolderASelectable;
    Selectable playerCardHolderBSelectable;

    // list of actions the do after the player ends their turn.
    public static List<String> playerActionsQueue = new List<String>();
    void Awake() {
        dropDownComponent = GetComponent<TMP_Dropdown>();
        playerCardHolderASelectable = playerCardHolderAPrefab.GetComponent<Selectable>();
        playerCardHolderBSelectable = playerCardHolderBPrefab.GetComponent<Selectable>();
    }

    void Start() {
        dropDownComponent.onValueChanged.AddListener(delegate {performAction(dropDownComponent);});
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
                    playerCardHolderASelectable.interactable = false;
                    playerCardHolderBSelectable.interactable = true;
                    break;
                case Card.CardType.darkFamiliar:
                case Card.CardType.lightFamiliar:
                case Card.CardType.earthFamiliar:
                case Card.CardType.waterFamiliar:
                case Card.CardType.fireFamiliar:
                    playerCardHolderASelectable.interactable = true;
                    playerCardHolderBSelectable.interactable = false;
                    break;
            }
        }
    }

    public void Attack() {
        Debug.Log("attack chosen.");
    }

    public void ActivateAbility() {
        Debug.Log("activate ability chosen.");
    }

    public void UseItem() {
        Debug.Log("use item chosen.");
    }

    public void CastSpell() {
        Debug.Log("cast spell chosen.");
    }
}
