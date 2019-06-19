using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popupMenu : MonoBehaviour
{
    public GameObject PopUp;
    public bool aktif;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        PopUp.SetActive (aktif);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
