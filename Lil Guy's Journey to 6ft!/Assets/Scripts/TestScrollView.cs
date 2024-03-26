using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Tilemaps;
using UnityEngine.UI;

public class TestScrollView : MonoBehaviour
{
    public GameObject testImg;
    public int testNum;

    public void Start() {
        PopulateTest();
    }

    public void PopulateTest() {
        GameObject newTestImg;
        for(int i = 0; i < testNum; i++) {
            newTestImg = Instantiate(testImg, transform);
            newTestImg.GetComponent<Image>().color = Random.ColorHSV();
        }
    }
}
