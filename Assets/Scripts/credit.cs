using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credit : MonoBehaviour {

    // Keeps track of the total credits in the scene
    public static int creditCount;

	void Start ()
    {
       
        // Object created, increment credit count
       // ++credit.creditCount;
	}

    void OnTriggerEnter (Collider Col)
    {
        // If player collides with credit, then destroy object
        if (Col.CompareTag("Player"))
            Destroy(gameObject);
    }
	
	void onDestroy()
    {
        GameObject.Find("Player").GetComponent<CharController>().playerCredits += 1f;
        // increment credit count
        ++credit.creditCount;

        // Check remaining credits
        if (credit.creditCount <= 0)
        {
            
        }
    }
}
