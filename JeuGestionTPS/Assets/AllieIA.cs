using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AllieIA : identite
{
    public Transform Personnage;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy();
        IAAllie();
    }

    private void IAAllie()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            agent.speed = 20;
        }
        agent.SetDestination(Personnage.position);
    }
}
