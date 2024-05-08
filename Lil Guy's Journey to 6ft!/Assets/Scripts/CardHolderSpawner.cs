using UnityEngine;

// CREATES CARD MAT; SPAWNS CARD HOLDERS.

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

    // creates card mat.
    void Start() {
        // create enemy card holders.
        // create player card holders A and B.
        for(int i = 0; i < 4; i++) {
            spawnCardHolder(enemyCardHolderPrefab, enemyCardHolderGroup);
            spawnCardHolder(playerCardHolderAPrefab, playerCardHolderAGroup);
            spawnCardHolder(playerCardHolderBPrefab, playerCardHolderBGroup);
        }
    }

    // instantiates or spawns a card holder prefab clone.
    public GameObject spawnCardHolder(GameObject cardHolderPrefab, Transform cardHolderGroup) {
        GameObject newCardHolder = Instantiate(cardHolderPrefab);
        newCardHolder.tag = "Empty";
        newCardHolder.transform.SetParent(cardHolderGroup, false);

        return newCardHolder;
    }
}
