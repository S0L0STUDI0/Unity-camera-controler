using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cams : MonoBehaviour
{

    public GameObject Camera1;
    public GameObject Camera2;

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne ();
        }

        if (Input.GetKeyDown("2"))
        {
            CameraTwo ();
        }
    }

    void CameraOne()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }

    void CameraTwo()
    {
        Camera2.SetActive(true);
        Camera1.SetActive(false);
    }
    
}
