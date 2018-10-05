using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour {


    public Score scoreTracker;
    public int scoreValue = 1;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()

    {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        //taking the score
        if (collision.GetComponent<PLayer>())

        {
            // Updating the score based on how much the object is worth
            scoreTracker.ChangeValue(scoreValue);

            //getting rid of the object picked
            Destroy(gameObject);
        }
    }

}
