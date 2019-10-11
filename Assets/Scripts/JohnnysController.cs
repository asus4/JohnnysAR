using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;



namespace Johnnys
{

    public class JohnnysController : MonoBehaviour
    {
        [SerializeField]
        ARHumanBodyManager humanBodyManager;

        [SerializeField]
        RawImage image;


        void Start()
        {
            Debug.Log("Started");
        }

        void Update()
        {
            var subsystem = humanBodyManager.subsystem;
            if (subsystem == null)
            {
                return;
            }

            var stencil = humanBodyManager.humanStencilTexture;
            image.texture = stencil;
        }
    }
}