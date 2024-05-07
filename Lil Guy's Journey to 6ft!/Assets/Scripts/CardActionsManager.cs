using CardNamespace;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using System.Collections.Generic;

// MANAGES CARD ACTIONS BASED ON USER ACTIONS (EX. MOUSE CLICKS ETC.).

public class CardActionsManager : MonoBehaviour, ISelectHandler
{
    // UI drop down game object.
    public GameObject dropDown;

    // dropdown component.
    TMP_Dropdown dropDownComponent;

    // card data to decide actions.
    public CardDisplay card;

    // initializes variables.
    void Awake()
    {
        dropDownComponent = dropDown.GetComponent<TMP_Dropdown>();
    }

    // when selected, the cropdown menu of actions the card can do will appear and the user can decide card actions.
    public void OnSelect(BaseEventData eventData) {
        dropDownComponent.Show();
    }
}
