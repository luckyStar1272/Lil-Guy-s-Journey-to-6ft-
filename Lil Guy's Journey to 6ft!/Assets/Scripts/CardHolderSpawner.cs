using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardHolderSpawner : MonoBehaviour
{
    // card holder game objects.
    [SerializeField] GameObject enemyCardHolderPrefab;
    [SerializeField] GameObject playerCardHolderAPrefab;
    [SerializeField] GameObject playerCardHolderBPrefab;

    // card holder game objects.
    [SerializeField] Transform enemyCardHolderGroup;
    [SerializeField] Transform playerCardHolderAGroup;
    [SerializeField] Transform playerCardHolderBGroup;

    // list of card holders.
    public List<GameObject> enemyCardHolders = new List<GameObject>();
    public List<GameObject> playerCardHoldersA = new List<GameObject>();
    public List<GameObject> playerCardHoldersB = new List<GameObject>();

    // creates card mat.
    void Start() {
        // create enemy card holders.
        // create player card holders A and B.
        for(int i = 0; i < 4; i++) {
            enemyCardHolders.Add(spawnCardHolder(enemyCardHolderPrefab, enemyCardHolderGroup));
            playerCardHoldersA.Add(spawnCardHolder(playerCardHolderAPrefab, playerCardHolderAGroup));
            playerCardHoldersB.Add(spawnCardHolder(playerCardHolderBPrefab, playerCardHolderBGroup));
        }
    }

    public GameObject spawnCardHolder(GameObject cardHolderPrefab, Transform cardHolderGroup) {
        GameObject newCardHolder = Instantiate(cardHolderPrefab);
        newCardHolder.tag = "Empty";
        newCardHolder.transform.SetParent(cardHolderGroup, false);

        return newCardHolder;
    }
}
