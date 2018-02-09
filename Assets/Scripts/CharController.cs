
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharController : MonoBehaviour {

    public Text scoreString;
    public Text pressE;

    public float playerCredits;
    bool onTrig;


    [SerializeField]
    float moveSpeed = 2f;

    Vector3 forward, right;

	void Start ()
    {
        playerCredits = 0;
        onTrig = false;
        setCountText();

        pressE.text = "";

        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;


    }
	
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
            Move();
        else if (Input.GetKey(KeyCode.A))
            Move();
        else if (Input.GetKey(KeyCode.S))
            Move();
        else if (Input.GetKey(KeyCode.D))
            Move();
    }

    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey"));
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");


        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
    }

    void OnTriggerEnter(Collider other)
    {
        onTrig = true;
        if (other.gameObject.CompareTag("chest"))
        {
            // fix the on trigger looping to true so the chest can be opened only once
            showText("Press 'E' to open");                      
        }
    }

    void OnTriggerExit(Collider other)
    {
        showText("");
    }

    void setCountText()
    {
        scoreString.text = "Items Collected: " + playerCredits.ToString();
    }

    void showText(string a)
    {
        if (onTrig == true)
        {
            pressE.text = a;
            Debug.Log("Y");
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("key pressed");
               // count = count + 1;
                setCountText();
                pressE.text = "";
            }
        }
    }
}
