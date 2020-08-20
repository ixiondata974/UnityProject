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

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        if(collision.gameObject.tag == "Enemi")
        {
            collision.gameObject.GetComponent<identite>().setVie(dommage);
        }
    }
}
