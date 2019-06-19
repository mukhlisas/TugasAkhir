using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //untuk musik lanjut terus
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
