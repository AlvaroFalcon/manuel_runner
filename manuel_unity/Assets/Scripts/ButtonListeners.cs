using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonListeners : MonoBehaviour {

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void restartLevel()
    {
        SceneManager.LoadScene("GameScene");
    }
}
