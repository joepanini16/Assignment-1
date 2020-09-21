using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titlepagemanager : MonoBehaviour
{

    
    public GameObject tittlepage;
    public GameObject cursor;
    public GameObject[] curserposition;
    public GameObject playerSelectIndicator;
    public Text thisText;
    public GameObject gamearea;
    public GameObject playeronespawn;
    public GameObject playerper;
    
    public Camera gamecamera;
    public Camera maincamera;

    private bool ongamestartselection;

    // Use this for initialization
    void Start ()
    {
        ongamestartselection = false;
        thisText = playerSelectIndicator.GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        

        if (Input.GetKeyDown("up") || Input.GetKeyDown("down"))
        {
           if(ongamestartselection)
            {
                ongamestartselection = false;
            }
           else
            {
              ongamestartselection = true;
            }
        }
        if(ongamestartselection)
        {
            cursor.transform.position = curserposition[1].transform.position;
        }
        else
        {
            cursor.transform.position = curserposition[0].transform.position;
        }

        if (Input.GetKeyDown("space") || Input.GetKeyDown("return"))
        {
            if (ongamestartselection == true)
            {
                
                
                gamearea.SetActive(true);
                tittlepage.SetActive(false);

                maincamera.enabled = false;
                gamecamera.enabled = true;

                Instantiate(playerper, playeronespawn.transform.position, Quaternion.identity);
            }
            if (ongamestartselection == false)
            {
                if (thisText.text == "1")
                {
                    thisText.text = "2";
                }
                else
                {
                    thisText.text = "1";
                }

            }

        }
        
            
        
        
    }

}
