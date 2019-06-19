using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klikproject : MonoBehaviour
{
    AudioSource btn;
    private void Start()
    {
        btn = GetComponent<AudioSource>();
    }

    private void OnMouseUp()
    {
        btn.Play();
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(1);
        Application.LoadLevel("project");
    }
}
