using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btybm : MonoBehaviour
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
        Application.OpenURL("https://ybmpln.org/");
    }
}