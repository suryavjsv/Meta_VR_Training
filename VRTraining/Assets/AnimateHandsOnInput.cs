using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandsOnInput : MonoBehaviour
{
    //Intializing InputAction Properties // AA - Animation Action
  //  public InputActionProperty pinch_AA;
    public InputActionProperty grip_AA;

    public Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*float triggerValue =  pinch_AA.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);*/

        float gripValue = grip_AA.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);


    }
}
