using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerCardHolderManager : MonoBehaviour
{
    // move card 
    void OnSelect(BaseEventData eventData) 
    {
        Debug.Log("card holder selected.");
    }
}
