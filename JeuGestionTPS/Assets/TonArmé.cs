using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TonArmé : MonoBehaviour
{
    [SerializeField]
    private string afficheArmé;

    [SerializeField]
    private GameObject ecran;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        ecran.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "Personnage")
        {
            ecran.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.name == "Personnage")
        {
            ecran.SetActive(false);
        }
    }
}
