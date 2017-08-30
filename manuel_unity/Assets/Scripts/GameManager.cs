using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public SpriteRenderer lifes;
    public Sprite[] lifeSprites;
    public Text scoreText;
    public GameObject endPanel;

	void Start () {
        GameCommon.jumpSpeed = 6;
        GameCommon.speed = 3;
        GameCommon.lifes = 3;
        GameCommon.isAlive = true;
        GameCommon.score = 0;
        GameCommon.bonus = 1;
        GameCommon.bonusCountDown = 10;
	}
	
	void Update () {
        if (GameCommon.isAlive) {
            updateLifeSprite();
            updateScore();
            doBonusCountDown();
        }

	}
    void doBonusCountDown(){
        if(GameCommon.bonus > 1 && GameCommon.bonusCountDown > 0) {
            GameCommon.bonusCountDown -= Time.deltaTime;
        }
        if(GameCommon.bonusCountDown < 0){
            GameCommon.bonus = 1;
            GameCommon.bonusCountDown = 10;
            GameCommon.speed = 2;
        }
    }
    void updateScore(){
        scoreText.text = GameCommon.score.ToString();
    }
    void updateLifeSprite(){
        if (GameCommon.lifes == 3) {
            lifes.sprite = lifeSprites[0];
        } else if (GameCommon.lifes == 2) {
            lifes.sprite = lifeSprites[1];
        } else if (GameCommon.lifes == 1) {
            lifes.sprite = lifeSprites[2];
        } else {
            lifes.sprite = lifeSprites[3];
            //GameCommon.isAlive = false;
            //endPanel.SetActive(true);
        }
    }
}
