using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlle : MonoBehaviour
{
    public float RotationSpeed = 1;
    public Transform cible, joueur;
    float mouseX, mouseY;
    private bool activate = true;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        if (activate == true)
        {
            CameraControl();
        }
    }

    private void CameraControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);
        transform.LookAt(cible);

        cible.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        joueur.rotation = Quaternion.Euler(0, mouseX, 0);
    }
    
    public void setActivate()
    {
        activate = !activate;
    }
}
