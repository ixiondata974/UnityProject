using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persoMouvementGestion : BaseMouvement
{
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        deplacement();
    }
}
