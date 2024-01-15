//   _  _    _____       _       _____ _             _ _       
// _| || |_ / ____|     | |     / ____| |           | (_)      
//|_  __  _| (___   ___ | | ___| (___ | |_ _   _  __| |_  ___  
// _| || |_ \___ \ / _ \| |/ _ \\___ \| __| | | |/ _` | |/ _ \ 
//|_  __  _|____) | (_) | | (_) |___) | |_| |_| | (_| | | (_) |
//  |_||_| |_____/ \___/|_|\___/_____/ \__|\__,_|\__,_|_|\___/ 


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

//SoloStudio-2024
