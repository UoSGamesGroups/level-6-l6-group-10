using UnityEngine;
using System.Collections;

public class Notes : MonoBehaviour {

    public Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
	
        if(gameObject.name == "notes_6") //Check the gameobject is note_6
        {

            GetComponent<BoxCollider2D>(); //Add the 2D collider to the object
            rb2D.velocity = new Vector2(-100, 0); //Get the new velocity for the object

        }

        if (gameObject.name == "notes_7")
        {

            GetComponent<BoxCollider2D>();
            rb2D.velocity = new Vector2(-100, 0);

        }

        if (gameObject.name == "notes_8")
        {

            GetComponent<BoxCollider2D>();
            rb2D.velocity = new Vector2(100, 0);

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
