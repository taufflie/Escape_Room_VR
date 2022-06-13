using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light2 : MonoBehaviour
{
    public GameObject light;
    public GameObject fire;
    public GameObject book2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Body"))
        {
            Debug.Log("Light");
            light.SetActive(true);
            fire.SetActive(true);
            book2.SetActive(true);
        }
    }
}