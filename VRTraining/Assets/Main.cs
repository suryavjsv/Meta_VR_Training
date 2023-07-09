using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public AudioClip[] voiceOversBasic;
    public AudioClip[] voiceOversInteractable;

    public AudioSource audioSource;

    public InputActionProperty checkTrigger, checkGrab;

    public bool voComplete = false;

    public GameObject leftHandModel, rightHandModel;
    public GameObject leftController, rightController;

    public TextMeshProUGUI instructionText;
    public GameObject controllerguidePNG;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartTheVR());
    }

    // Update is called once per frame
    void Update()
    {
        bool grab = checkGrab.action.IsPressed();

        if((grab) && (voComplete))
        {
            StartCoroutine(TrainingProgram(9));
        }


    }
    

    IEnumerator StartTheVR()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine(TrainingProgram(0));

    }
    /// <summary>
    /// With this Enumerator we can play the audio clips by fixing the time between each clips.
    /// </summary>
    /// <param name="value"> this value will call the respective case</param>
    /// <returns></returns>
    IEnumerator TrainingProgram(int value)
    {
        switch (value)
        {

            case 0:
                audioSource.clip = voiceOversBasic[0];
                audioSource.Play();
                instructionText.text = "Welcome to Renault Nissan Mitsubishi VR Training!";
                yield return new WaitForSeconds(8);
                StartCoroutine(TrainingProgram(1));
                break;

            case 1:
                audioSource.clip = voiceOversBasic[1];
                audioSource.Play();
                instructionText.text = "Now! You are wearing Meta Quest 2 VR Headset and In your hands you have Meta Quest 2 Controllers";
                yield return new WaitForSeconds(8);
                StartCoroutine(TrainingProgram(2));
                break;

            case 2:
                audioSource.clip = voiceOversBasic[2];
                audioSource.Play();
                instructionText.text = "As you can see in the image you have 6 types of buttons in the controllers, which includes 2 Thumbstick 2 Grip and Trigger Buttons on both ccontrollers";
                controllerguidePNG.SetActive(true);
                yield return new WaitForSeconds(15);
                StartCoroutine(TrainingProgram(3));
                break;

            case 3:
                audioSource.clip = voiceOversBasic[3];
                audioSource.Play();
                instructionText.text = "And Menu button on the left controllers and oculus button on the right controllers";
                yield return new WaitForSeconds(10);
                StartCoroutine(TrainingProgram(4));
                break;

            case 4:
                controllerguidePNG.SetActive(false);
                audioSource.clip = voiceOversInteractable[0];
                audioSource.Play();
                instructionText.text = "Now you able to see Your Virtual Hands on the screen";
                leftHandModel.SetActive(true);
                rightHandModel.SetActive(true);
                leftController.SetActive(false);
                rightController.SetActive(false);
                yield return new WaitForSeconds(10);
                StartCoroutine(TrainingProgram(5));
                break;

            case 5:
                audioSource.clip = voiceOversInteractable[1];
                audioSource.Play();
                instructionText.text = "In your surrounding! you've some interactable spots by using your right controlller's thumbstick, can able to teleport on the selected area! Which denotes green circle";
                yield return new WaitForSeconds(20);
                StartCoroutine(TrainingProgram(6));
                break;

            case 6:
                audioSource.clip = voiceOversInteractable[2];
                audioSource.Play();
                instructionText.text = "Also By using your thumbstick on the left controller you can able to move continuosuly!";
                yield return new WaitForSeconds(20);
                StartCoroutine(TrainingProgram(7));
                break;

            case 7:
                audioSource.clip = voiceOversInteractable[3];
                audioSource.Play();
                instructionText.text = "Congratulations! you just learnt the basic movement in VR.";
                StartCoroutine(TrainingProgram(8));
                break;

            case 8:
                audioSource.clip = voiceOversInteractable[4];
                audioSource.Play();
                instructionText.text = "Now you can use your grip buttons to grab objects! You can poke the buttons in poke interactable. And you can use UI using trigger or grip button & adjust the Slide Value ";
                yield return new WaitForSeconds(20);
                voComplete = true;
                break;

            case 9:
                audioSource.clip = voiceOversInteractable[5];
                audioSource.Play();
                instructionText.text = "Congratulations! You've learnt to operate VR through RNM Virtual Reality Training Program. Have a nice Day! ";
                break;

            default:
                //Nothing
                break;


        }
    }


}
