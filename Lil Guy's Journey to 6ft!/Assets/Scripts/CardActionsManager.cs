using CardNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

// MANAGES CARD ACTIONS BASED ON USER ACTIONS (EX. MOUSE CLICKS ETC.).

public class CardActionsManager : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    // UI drop down game object.
    public GameObject dropDown;

    // initializes variables.
    void Awake()
    {
        dropDown.SetActive(false);
    }

    // when selected, the cropdown menu of actions the card can do will appear and the user can decide card actions.
    public void OnSelect(BaseEventData eventData) {
        // activate card actions dropdown menu.
        dropDown.SetActive(true);
    }

    // when deselected, the dropdown menu will disappear.
    public void OnDeselect(BaseEventData eventData) {
    }
}
