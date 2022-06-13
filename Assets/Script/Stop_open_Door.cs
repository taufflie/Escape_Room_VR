using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_open_Door : MonoBehaviour
{
    public GameObject handlecollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stop_Trigger"))
        {
            handlecollider.GetComponent<Open_Door>().enabled = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
