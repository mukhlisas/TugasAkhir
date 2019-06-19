using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float kecepatan, scaleX, lompat;
    // Start is called before the first frame update
    void Start()
    {
        scaleX = transform.localScale.x;
    }

    public void jalan_kiri()
    {
        if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0). IsName("New State"))
        {
            GetComponent<Animator>().SetTrigger("tangan");
        }
        transform.localScale = new Vector3(-scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.left * kecepatan * Time.fixedDeltaTime, Space.Self);
    }

    public void jalan_kanan()
    {
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("New State"))
        {
            GetComponent<Animator>().SetTrigger("tangan");
        }
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.right * kecepatan * Time.fixedDeltaTime, Space.Self);
    }

    public void melompat ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, lompat);
    }

    public void berhenti()
    {
        GetComponent<Animator>().SetTrigger("stop");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            jalan_kiri();
        } if (Input.GetKey (KeyCode.RightArrow))
        {
            jalan_kanan();
        } if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            melompat();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            berhenti();
        }
    }
}
