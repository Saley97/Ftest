using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPScript : MonoBehaviour {
    public Transform tPPoint;

    Renderer pr;
    Color c;

    bool isGetDamage = false;

    private void Start()
    {
        pr = GameObject.FindGameObjectWithTag("Player").GetComponent<Renderer>();
        c = pr.material.color;
    }

    private void Update()
    {
        if (isGetDamage)
        {

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.transform.position = tPPoint.position;
            pr.material.color = new Color(c.r, c.g, c.b, 0);
            StartCoroutine("ColorChanger");
        }
    }

    IEnumerator ColorChanger()
    {
        for (int i = 0; i < 5; i++)
        {
            for (float a = 0; a <= 1.0f; a+=0.1f)
            {
                float ta = i % 2 == 0 ? a : 1 - a;
                c.a = ta;
                pr.material.color = c;
                yield return new WaitForSeconds(.03f);
            }
        }
        yield return null;
    }

}
