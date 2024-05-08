using UnityEngine;
using UnityEngine.SceneManagement;

// RESPONSIBLE FOR MAIN MENU AND SCENE TRANSITIONS.

public class MainMenuHandler : MonoBehaviour
{
    // toggles fullscreen on and off with esc key.
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }

    // loads/starts game.
    public void Play() {
        SceneManager.LoadScene("Gameplay Scene");
    }

    // quits game/closes application.
    public void Quit() {
        Application.Quit();
    }

    // loads/goes back to start scene.
    public void QuitRun() {
        SceneManager.LoadScene("Start Scene");
    }

    // loads/opens options scene.
    public void Option() {
        SceneManager.LoadScene("Options Scene");
    }
}
