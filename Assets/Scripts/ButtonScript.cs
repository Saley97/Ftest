using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {
    public GameObject obj;
    public bool isActive = false;
	

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            obj.SetActive(isActive);
        }
    }
}
