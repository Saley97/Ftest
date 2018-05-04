using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusterScript : MonoBehaviour {
    public float boostForce = 700f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddForce(transform.up * boostForce);
        }
    }
}
