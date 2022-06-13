using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_Candle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject book1;
    public GameObject book2;
    public GameObject hint;
    public GameObject hint1;
    private bool flag1;
    private bool flag2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        flag1 = false;
        flag2 = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Book1"))
        {
            Debug.Log("Book 1");
            flag1 = true;
            hint1.SetActive(true);
        }

        if (other.CompareTag("Book2"))
        {
            Debug.Log("Book 2");
            flag2 = true;
            hint1.SetActive(true);
        }


    }
    // Update is called once per frame
    void Update()
    {
        if (flag1 == true && flag2 == true)
        {
            GameObject.Find("CH (5)").GetComponent<Collider>().enabled = true;
            gameObject.GetComponent<AudioSource>().enabled = true;
            hint1.SetActive(false);
            hint.SetActive(true);
        }


    }
}
