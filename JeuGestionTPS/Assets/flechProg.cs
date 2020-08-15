using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flechProg : MonoBehaviour
{
    [SerializeField]
    private GameObject cible;

    [SerializeField]
    private Transform joueur;

    [SerializeField]
    protected float dommage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        if(collision.gameObject.tag == "Enemi")
        {
            collision.gameObject.GetComponent<identite>().setVie(dommage);
        }
    }
}
