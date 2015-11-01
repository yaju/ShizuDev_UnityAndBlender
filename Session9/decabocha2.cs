using UnityEngine;
using System.Collections;

public class decabocha2 : MonoBehaviour {

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
                //GetComponent<Animator>().SetTrigger("Idle");
                break;
            case -1:
                GetComponent<Animator>().SetTrigger("Left");
                break;
            case 1:
                GetComponent<Animator>().SetTrigger("Right");
                break;
        }
    }
}
