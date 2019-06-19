using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown() {
        if (gameObject.name == "btnatas") {
            player.GetComponent<player>().melompat();
        }

        if (gameObject.name == "btnprev")
        {
            player.GetComponent<player>().jalan_kiri();
        }
        else if (gameObject.name == "btnext")
        {
            player.GetComponent<player>().jalan_kanan();
        }
    }


    void OnMouseUp() {
        if (gameObject.name == "btnprev") {
            player.GetComponent<player>().berhenti();
        } else if (gameObject.name == "btnext") {
            player.GetComponent<player>().berhenti();
        }
    }

    void OnMouseDrag() {
        if (gameObject.name == "btnatas")
        {
            player.GetComponent<player>().melompat();
        }

        if (gameObject.name == "btnprev") {
            player.GetComponent<player>().jalan_kiri();
        } else if (gameObject.name == "btnext") {
            player.GetComponent<player>().jalan_kanan();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}