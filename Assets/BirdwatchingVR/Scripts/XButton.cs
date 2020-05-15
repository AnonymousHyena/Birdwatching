using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XButton : MonoBehaviour {

    void Awake()
    {
        Input.backButtonLeavesApp = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
