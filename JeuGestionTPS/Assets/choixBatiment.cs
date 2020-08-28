using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class choixBatiment : MonoBehaviour
{
    ToggleGroup groupButton;
    GameObject objFind;
    
    // Start is called before the first frame update
    void Start()
    {
        groupButton = GetComponent<ToggleGroup>();
    }

    private void Update()
    {

    }

    public Toggle objSelect
    {
        get {
                return groupButton.ActiveToggles().FirstOrDefault();
        }
    }
}
