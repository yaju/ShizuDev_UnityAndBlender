using UnityEngine;
using System.Collections;

public class decabocha : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        float h = Input.GetAxisRaw("Horizontal");

        switch ((int)h)
        {
            case 0:
                GetComponent<Animator>().SetBool("Right", false);
                GetComponent<Animator>().SetBool("Left", false);
                break;
            case -1:
                GetComponent<Animator>().SetBool("Left", true);
                break;
            case 1:
                GetComponent<Animator>().SetBool("Right", true);
                break;
        }
        
        /*
         Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
         float h = Input.GetAxisRaw("Horizontal");
         float v = Input.GetAxisRaw("Vertical");

         GetComponent<Animator>().SetInteger("DirX", (int)h);
         GetComponent<Animator>().SetInteger("DirY", (int)v);
        */
        
        /*
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        GetComponent<Animator>().SetFloat("DirX", h);
        GetComponent<Animator>().SetFloat("DirY", v);
        */
    }

}
