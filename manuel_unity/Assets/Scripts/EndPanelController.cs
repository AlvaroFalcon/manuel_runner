using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPanelController : MonoBehaviour {


    public Text scoreText;
    public Button retryButton;
    public Button mainMenuButton;

    void Update () {
        scoreText.text = "Puntuación total: " + GameCommon.score;
	}
}
