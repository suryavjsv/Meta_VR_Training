using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICanvasLookAt : MonoBehaviour
{
    [SerializeField]
    GameObject panel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 panelRotation = new Vector3(panel.transform.position.x, transform.position.y, transform.position.z);
        transform.LookAt(panelRotation);
    }


}
