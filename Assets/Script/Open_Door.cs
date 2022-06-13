using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door : MonoBehaviour
{
    public GameObject door;
    private bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stop_Trigger"))
        {
            flag = true;
        }


    }
    // Update is called once per frame
    void Update()
    {
        if (flag == true)
        {
            door.transform.Rotate(0, 20 / 120f, 0);
            GameObject.Find("door").GetComponent<AudioSource>().enabled = true;
        }
        
    }
}
