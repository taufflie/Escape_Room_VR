using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Teleportation_activation : MonoBehaviour
{
    public XRController teleporterController;
    public InputHelpers.Button teleportationActivationButton;
    public float activationThreshold = 0.1f;

    private void Update()
    {
        InputHelpers.IsPressed(teleporterController.inputDevice, teleportationActivationButton, out bool isPressed, activationThreshold);
            teleporterController.gameObject.SetActive(isPressed);
    }
}
