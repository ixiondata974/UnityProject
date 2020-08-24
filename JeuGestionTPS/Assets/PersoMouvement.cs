using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = System.Random;

public class PersoMouvement : BaseMouvement
{
    [SerializeField]
    private GameObject OuvertureEcranEnemie, flech;

    public string LoadScene2;

    private CapsuleCollider playerCollider;
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
        LoadScene();
    }

    private void LoadScene()
    {
        if (Input.GetKey(LoadScene2))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
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
}
