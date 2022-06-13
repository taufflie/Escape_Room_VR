using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light3 : MonoBehaviour
{
    public GameObject light;
    public GameObject fire;
    public GameObject canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            Debug.Log("Light");
            light.SetActive(true);
            fire.SetActive(true);
            canvas.SetActive(true);
        }
    }
}