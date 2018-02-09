using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestScript : MonoBehaviour {

    bool inTrig = false;
    string text = "";

    void OnTriggerEnter(Collider col)
    {
        inTrig = true;

        if (col.gameObject.tag == "chest")
        {
            Debug.Log("Collision detected");
            text = "Press E to pickup";

            if (Input.GetKeyDown(KeyCode.E))
            {

            }
        }
    }
}
