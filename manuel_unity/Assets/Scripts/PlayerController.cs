using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject[] floors;
    public GameObject backgroundHotel;
    public GameObject backgroundFalseHotel;
    public Transform backgroundgen;
    public Transform floorGen;
    private Rigidbody2D myRigidBody;

    private bool isJumping;

    void Start () {
        myRigidBody = this.GetComponent<Rigidbody2D>();

        isJumping = false;
	}

	void Update () {
        if (GameCommon.isAlive) {
            myRigidBody.velocity = new Vector2(3 , myRigidBody.velocity.y);
            if (Input.GetMouseButtonDown(0) && !isJumping) {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(myRigidBody.velocity.x,5.5f);
                isJumping = true;
            }
        }

    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log(coll.gameObject.name);
        isJumping = false;

    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag.Equals("background")) {
            Instantiate(backgroundHotel, backgroundgen.position, Quaternion.identity);
        }
        if (other.gameObject.tag.Equals("background2")) {
            Debug.Log("bacgrkound");
            Instantiate(backgroundFalseHotel, new Vector3(backgroundgen.position.x, backgroundgen.position.y, 12), Quaternion.identity);
        }
        if (other.gameObject.tag.Equals("floor")) {
            
            Instantiate(floors[Random.Range(0,floors.Length)], floorGen.position, Quaternion.identity);
        }
        if (other.gameObject.tag.Equals("point")) {
            Destroy(other.gameObject);
            GameCommon.score += 1*GameCommon.bonus;
        }
        if (other.gameObject.tag.Equals("enemy")) {
            GameCommon.lifes--;
        }
        if(other.gameObject.tag.Equals("bonus")){
            Destroy(other.gameObject);
            GameCommon.speed += 0.25f;
            GameCommon.bonusCountDown = 5;
            GameCommon.bonus++;
        }
        if(other.gameObject.tag.Equals("dead")){
            GameCommon.lifes = 0;
        }
    }

}
