using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
	}
    // Called before any Physics computations
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(moveHorizontal * speed * Time.deltaTime, 0.0f, moveVertical * speed * Time.deltaTime);
    }
}
