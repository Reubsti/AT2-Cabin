using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //This allows UI stuffs.

public class Interaction : MonoBehaviour
{
    public float reach = 3;  //of of teractionrd
    public Image crosshair; //Links crosshair into the game
    public Text infoPanel; //links to text of UI Images

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            Debug.Log("Bye Bitch");  //E is for quitting its good enough for me }
            crosshair.color = Color.white;
            infoPanel.text = "Hover over objects to see info here.";
        }


    }


    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * reach, Color.blue, 0.01f);

        //if raycast hit object
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit objectHit) == true) ;
        {
         

            //Now lets find out our hitting accuracy
            //We will aim for the invention by Dunny
            if (objectHit.collider.name == "PFB_Dunny")
            {
                Debug.Log("I hit the Crap Holder");
                crosshair.color = Color.green;
                infoPanel.text = objectHit.collider.name;
                //infoPanel.enabled = true
            }
            else
            {
                Debug.Log("Where is the Dunny");
                crosshair.color = Color.white;
                infoPanel.text = ("hover objectsto see info here,");
                //infoPanel.enmabled= false;
            }


        }


       
       
    }



}
