using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparaitionEnemie : MonoBehaviour
{
    public GameObject enemi;
    private Vector3 newPosis;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            float X = Random.Range(116f, 330f);
            float Z = Random.Range(162.4f, 362.9f);
            if (X != enemi.transform.position.x && Z != enemi.transform.position.z)
            {
                newPosis = new Vector3(X, 6, Z);
                GameObject arme = Instantiate(enemi, newPosis, transform.rotation);
                arme.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
