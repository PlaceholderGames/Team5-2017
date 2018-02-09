using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour {


	void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "pickup")
        {
            Destroy(col.gameObject);
        }
    }
}
