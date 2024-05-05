using UnityEngine;
using TMPro;
using CardNamespace;
using UnityEngine.EventSystems;
using System.Collections.Generic;

// MANAGES CARD DROPDOWN ACTIONS.

public class CardActions : MonoBehaviour
{
    // dropdown component.
    TMP_Dropdown dropDown;

    // option if card is in the deck.
    List<string> playCardOpt = new List<string> {"Play Card"};

    // option if card is on the field and does not have an ability.
    List<string> attackCardOpt = new List<string> {"Attack"};

    // option if card is on the field and only has an ability (spell and item cards).
    List<string> abilityCardOpt = new List<string> {"Use Ability"};

    // options if card is on the field.
    List<string> playedCardOpt = new List<string> {"Attack, Use Ability"};

    // card data to decide actions.
    public CardDisplay card;

    // initializes variables.
    void Awake() {
        dropDown = GetComponent<TMP_Dropdown>();
        dropDown.value = -1;
    }

    // Update is called once per frame
    void Update()
    {
        switch(dropDown.value) {
            case 0:
                // places card on an empty spot.
                PlayCard();
                break;
            case 1:
                // assigns card to attack an enemy card.
                Attack();
                break;
            case 2:
                // assign card to use ability.
                UseAbility();
                break;
        }
    }

    void OnPointerClick(PointerEventData eventData) {
        Debug.Log("dropdown clicked.");
        dropDown.AddOptions(playCardOpt);
        //dropDown.AddOptions(attackCardOpt);
        //dropDown.AddOptions(abilityCardOpt);
        //dropDown.AddOptions(playedCardOpt);
    }

    public void PlayCard() {
        Debug.Log("play card chosen.");
    }

    public void Attack() {
        Debug.Log("attack chosen.");
    }

    public void UseAbility() {
        Debug.Log("use ability chosen.");
    }
}
