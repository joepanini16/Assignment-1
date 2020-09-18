using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermanager : MonoBehaviour
{
    Rigidbody2D rb2d;
    SpriteRenderer spriteRen;
    Animator tankAnim;
	
    // Use this for initialization
	void Start ()
    {
		Debug.Log("test:player manger reporting");

        rb2d = GetComponent<Rigidbody2D>();
        spriteRen = GetComponent<SpriteRenderer>();
        tankAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
        if(Input.GetKey("w") || Input.GetKey("up")) 
        {
            rb2d.velocity = new Vector2(0,2);
            spriteRen.flipY = false;
            tankAnim.Play("plaermoveA");
        }
        else if(Input.GetKey("s") || Input.GetKey("down"))
        {
            rb2d.velocity = new Vector2(0,-2);
            spriteRen.flipY = true;
            tankAnim.Play("plaermoveA");
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(2,0);
            spriteRen.flipX = false;
            tankAnim.Play("playermoveB");
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-2,0);
            spriteRen.flipX = true;
            tankAnim.Play("playermoveB");
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
        }

    }

}
