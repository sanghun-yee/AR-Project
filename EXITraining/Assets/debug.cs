﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class debug : MonoBehaviour
{

    public GameObject arSessOr, arSession, arCam;

    TMP_Text txt;

    private void Start()
    {
        txt = this.GetComponent<TMP_Text>();
    }

    void Update()
    {
        txt.text = "AR Sess.Or : " + arSessOr.transform.position.ToString() + arSessOr.transform.rotation.ToString();
        txt.text += "\nAR Session : " + arSession.transform.position.ToString() + arSession.transform.rotation.ToString();
<<<<<<< HEAD
        txt.text += "\nAR Camera : " + arCam.transform.position.ToString() + arCam.transform.rotation.ToString();
=======
        txt.text += "\nAR Camera : " + arCam.transform.position.ToString() + arCam.transform.rotation.ToString() + arCam.transform.rotation.eulerAngles.ToString() ;
>>>>>>> a255a2aec8bfb25472af9e768ecf2e25ed769108
    }
}
