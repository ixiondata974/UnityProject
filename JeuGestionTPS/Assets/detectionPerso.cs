using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectionPerso : MonoBehaviour
{
    public GameObject soldat;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per fram

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "allié" || other.transform.name == "Personnage")
        {
            soldat.GetComponent<identite>().setObjASuivre(other.gameObject);
        }
    }

    private void OnTriggerStay()
    {
        soldat.GetComponent<identite>().persoSuivi();
    }

    //...............................................................................

}
