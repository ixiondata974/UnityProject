using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMouvement : MonoBehaviour
{
    public float vitesseMarche, acceleration;
    
    public string devant, derrier, gauche, droite;

    [SerializeField]
    private Camera laCamera;
    
    protected Rigidbody rb;

    protected void deplacement()
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
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            vitesseMarche -= acceleration;
        }
    }
}
