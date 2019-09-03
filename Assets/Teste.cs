using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public ArdJoystick.ArdController ardController;

    // Update is called once per frame
    private void Update()
    {
        if (ardController.GetKeyDown(ArdJoystick.ArdKeyCode.BUTTON_A))
        {
            //Action for Button A
        }
    }
}