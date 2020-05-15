using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observe : MonoBehaviour {
    Camera currentCamera;
    Ray ray;
    RaycastHit[] hits;


    void Start()
    {
        currentCamera = Camera.main;
    }

    public void Scare()
    {
        ray = currentCamera.ScreenPointToRay(Input.mousePosition);
        hits = Physics.RaycastAll(currentCamera.transform.position, currentCamera.transform.forward);//(ray,60);
        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.tag == "lb_bird")
            {
                hit.transform.SendMessage("Flee");
              //  break;
            }
        }
    }

    public void See()
    {
        ray = currentCamera.ScreenPointToRay(Input.mousePosition);
        hits = Physics.RaycastAll(currentCamera.transform.position, currentCamera.transform.forward);//(ray,60);
        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.tag == "lb_bird")
            {
                hit.transform.SendMessage("KillBirdWithForce", ray.direction * 500);
              //  break;
            }
        }
    }
}
