using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallColorToggle : MonoBehaviour
{
    private int toggleCounter = 1;
    public InputActionReference toggleReference = null;
    public Material mat1;
    public Material mat2;
    public Material mat3;

    private void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    private void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    void Toggle(InputAction.CallbackContext context)
    {
        toggleCounter++;
        if (toggleCounter >= 4)
        {
            toggleCounter = 1;
        }
        if (toggleCounter == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat1;
        }
        else if (toggleCounter == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material = mat2;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material = mat3;
        }
    }
}
