using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvertureEcranArmée : MonoBehaviour
{
    [SerializeField]
    private string Créer_Armée;

    [SerializeField]
    private GameObject écranArmé;

    private bool pause = false;

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
        void fixedTimePause()
        {
            Time.fixedDeltaTime = Time.fixedDeltaTime * Time.timeScale;
        }
        if (Input.GetKeyDown(Créer_Armée))
        {
            pause = !pause;
            écranArmé.SetActive(pause);
            if (écranArmé.active)
            {
                Time.timeScale = 0f;
                //fixedTimePause();
            }
            else
            {
                Time.timeScale = 1f;
                //fixedTimePause();
            }
        }
    }
}
