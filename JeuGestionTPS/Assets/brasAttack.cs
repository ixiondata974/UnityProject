using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brasAttack : flechProg
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "allié")
        {
            Debug.Log("Attaque");
            other.gameObject.GetComponent<AllieIA>().setVie(dommage);
        }
    }
}
