using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//RESPONSIBLE FOR MAIN MENU AND SCENE TRANSITIONS.

public class MainMenuHandler : MonoBehaviour
{
    //loads/starts game.
    public void Play() {
        SceneManager.LoadScene("Gameplay Scene");
    }

    //quits game/closes application.
    public void Quit() {
        Application.Quit();
    }
}
