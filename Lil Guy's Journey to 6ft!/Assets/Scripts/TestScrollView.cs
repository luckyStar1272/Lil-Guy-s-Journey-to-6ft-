using UnityEngine;
using UnityEngine.UI;

//TEST SCRIPT FOR POPULATING SCROLL.

public class TestScrollView : MonoBehaviour
{
    public GameObject testImg;
    public int testNum;
    [SerializeField] CardSpawner cs;

    public void Start() {
/*        for(int i = 0; i < testNum; i++) {
            PopulateTest();
        }
*/
        cs.SpawnCard("player deck");
    }

    public void PopulateTest() {
/*        for(int i = 0; i < testNum; i++) {
            Instantiate(testImg, transform);
            testImg.GetComponent<Image>().color = Random.ColorHSV();
        }
*/
        Instantiate(testImg, transform);
        testImg.GetComponent<Image>().color = Random.ColorHSV();
    }
}
