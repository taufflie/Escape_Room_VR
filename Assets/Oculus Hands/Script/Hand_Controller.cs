using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class Hand_Controller : MonoBehaviour
{
    public InputDeviceCharacteristics controllerCharachteristics;
    private InputDevice handDevice;
    public GameObject handPrefab;
    private GameObject handModel;
    private Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharachteristics,  devices);
        foreach(InputDevice d in devices)
        {
            Debug.Log(d.name + d.characteristics);
        }
        if(devices.Count > 0)
        {
            handDevice = devices[0];
            handModel = Instantiate(handPrefab, this.transform);
            handAnimator = handModel.GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (handDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("Grab", gripValue);
        }
        else
        {
            handAnimator.SetFloat("Grab", 0f);
        }

        if (handDevice.TryGetFeatureValue(CommonUsages.trigger,out float triggerValue))
        {
            handAnimator.SetFloat("Pinch", triggerValue);
        }
        else
        {
            handAnimator.SetFloat("Pinch", 0f);
        }
    }
}
