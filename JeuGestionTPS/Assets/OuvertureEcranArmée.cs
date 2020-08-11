using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureEcranArmée : MonoBehaviour
{
    [SerializeField]
    private string Créer_Armée;

    [SerializeField]
    private GameObject écranArmé;

    [SerializeField]
    private PersoMouvement setactiveMouv;

    [SerializeField]
    private CameraControlle setCameraActive;

    void Start()
    {
        écranArmé.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        EcranArmeOpenClose();
    }

    private void EcranArmeOpenClose()
    {
        if (Input.GetKeyDown(Créer_Armée))
        {
            if (écranArmé.active == true)
            {
                écranArmé.SetActive(false);
                active();
            }
            else
            {
                écranArmé.SetActive(true);
                active();
            }
        }

        if(écranArmé.active == true && Input.GetKeyDown(KeyCode.Escape))
        {
            écranArmé.SetActive(false);
            active();
        }
    }

    private void active()
    {
        setactiveMouv.setActive();
        setCameraActive.setActivate();
    }
}
