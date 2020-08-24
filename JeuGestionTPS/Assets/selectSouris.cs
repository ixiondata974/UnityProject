using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectSouris : MonoBehaviour
{
    public GameObject PointeurSouris;
    bool barriere;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        PointeurSouris.transform.position = snapPosition(pointeur());
        getInput();
    }

    private void getInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startFence();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            setFence();
        }
        else
        {
            if (barriere)
            {
                updateFence();
            }
        }
    }

    private void updateFence()
    {
        throw new NotImplementedException();
    }

    private void setFence()
    {
        barriere = false;
    }

    private void startFence()
    {
        barriere = false;
    }

    public Vector3 pointeur()
    {
        Camera cam = GetComponent<Camera>();
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            return hit.point;
        }
        else
        {
            return Vector3.zero;
        }
    }

    public Vector3 snapPosition(Vector3 original)
    {
        Vector3 snapped;
        snapped.x = Mathf.Floor(original.x + 0.05f);
        snapped.y = Mathf.Floor(original.y + 0.05f);
        snapped.z = Mathf.Floor(original.z + 0.05f);

        return snapped;
    }
}
