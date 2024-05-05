using TMPro;
using UnityEngine;
using UnityEngine.UI;
using CardNamespace;

// CREATES VISUAL DISPLAY FOR CARD PREFAB.

public class CardDisplay : MonoBehaviour
{
    // contains Card info to use to create the card.
    public Card cardData;

    // card image/sprite.
    public Image cardImg;

    // HP text.
    public TMP_Text hpTxt;

    // MP text.
    public TMP_Text atkTxt;

    // name text.
    public TMP_Text nameTxt;

    // description text.
    public TMP_Text descriptionTxt;

    // Start is called before the first frame update.
    void Start() {
        CreateCardDisplay();
    }

    // creates the card display.
    public void CreateCardDisplay() {
        // sets all text for card.
        hpTxt.text = cardData.health.ToString();
        atkTxt.text = cardData.atkDmg.ToString();
        nameTxt.text = cardData.name;
        descriptionTxt.text = cardData.cardDescription;

        // sets hp and atk text if needed.
        if(cardData.type == Card.CardType.equip || cardData.type == Card.CardType.item || cardData.type == Card.CardType.spell) {
            hpTxt.gameObject.SetActive(false);
            atkTxt.gameObject.SetActive(false);
        }
        else {
            hpTxt.gameObject.SetActive(true);
            atkTxt.gameObject.SetActive(true);
        }

        // sets card image.
        cardImg.sprite = cardData.cardImg;
    }

    public Card.CardType getCardType() {
        return cardData.type;
    }
}
