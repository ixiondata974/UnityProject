using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcranEnemie : MonoBehaviour
{
    private Text myText;

    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("Canvas/EcranEnemie/Texte").GetComponent<Text>();
        myText.text = "vsrbsfsf";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
