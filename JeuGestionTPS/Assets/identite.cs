using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class identite : MonoBehaviour
{
    protected float vie = 100f;
    protected NavMeshAgent agent;
    
    private GameObject objetASuivre = null;
    private bool canAttack = true;
    private Animator animAttack;

    [SerializeField]
    [Range(0f,1f)]
    private float lerp = 0f;

    public GameObject bras;

    public float depart = 1.51f;
    public float fin = -1.77f;

//.............................................................................................
    
        // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        animAttack = bras.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Destroy();
    }

    //..................................................................................................................

    private void attack()
    {
        RaycastHit ray;
        Debug.DrawRay(transform.position, transform.forward * 5, Color.red);
        if (Physics.Raycast(transform.position, transform.forward * 10, out ray, 8) && canAttack)
        {
            Debug.Log("Détécté");
            animAttack.Play("Bras(attack)");
        }
    }

    protected virtual void Destroy()
    {
        if(this.vie <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void persoSuivi()
    {
        //aller vers l'enemie..............
        if(objetASuivre != null)
        {
            agent.destination = objetASuivre.transform.position;
            attack();
        }
    }

    //**********************************************************************************************************
    public float getVie()
    {
        return vie;
    }

    public void setVie(float dommage)
    {
        this.vie -= dommage;
    }

    public void setObjASuivre(GameObject aSuivre)
    {
        this.objetASuivre = aSuivre;
    }
    
}
