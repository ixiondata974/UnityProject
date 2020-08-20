using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class PersoMouvement : MonoBehaviour
{
    [SerializeField]
    private float vitesseMarche, acceleration;

    [SerializeField]
    private string devant, derrier, gauche, droite, NomDeEnemie;

    [SerializeField]
    private Camera laCamera;

    [SerializeField]
    private GameObject cylindre, OuvertureEcranEnemie, flech;

    private CapsuleCollider playerCollider;
    private Rigidbody rb;
    private float speed = 10.0f;
    private GameObject rayHit;

    void Start()
    {
        playerCollider = gameObject.GetComponent<CapsuleCollider>();
        OuvertureEcranEnemie.SetActive(false);
        rb = GetComponent<Rigidbody>();
        rayHit = GameObject.Find("RayHit");
    }
    
    // Update is called once per frame
    void Update()
    {
        deplacement();

    }

    private void FixedUpdate()
    {
        attack();
    }

    private void attack()
    {
        RaycastHit hit;
        Debug.DrawRay(rayHit.transform.position, transform.forward * 20, Color.red);

        if (Physics.Raycast(rayHit.transform.position, transform.forward * 10, out hit, 20))
        {
            if(hit.collider.tag == "Enemi")
            {
                OuvertureEcranEnemie.SetActive(true);
                OuvertureEcranEnemie.transform.GetChild(0).GetComponent<Text>().text = hit.collider.transform.name;
                OuvertureEcranEnemie.transform.GetChild(1).GetComponent<Text>().text = "Point de vie : "+hit.collider.gameObject.GetComponent<identite>().getVie().ToString();
                attackFlech();
            }
        }
        else
        {
            OuvertureEcranEnemie.gameObject.SetActive(false);
        }
    }

    private void attackFlech()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject arrow = Instantiate(flech, rayHit.transform.position, transform.rotation);
            arrow.SetActive(true);
            arrow.GetComponent<Rigidbody>().AddForce(transform.forward * 2000f);
        }
    }

    private void deplacement()
    {
        if (Input.GetKey(devant))
        {
            transform.Translate(0, 0, vitesseMarche * Time.deltaTime);
        }
        if (Input.GetKey(derrier))
        {
            transform.Translate(0, 0, -vitesseMarche * Time.deltaTime);
        }
        if (Input.GetKey(gauche))
        {
            transform.Translate(-vitesseMarche * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(droite))
        {
            transform.Translate(vitesseMarche * Time.deltaTime, 0, 0);
        }
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            vitesseMarche += acceleration;
        }else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            vitesseMarche -= acceleration;
        }

    }
}
