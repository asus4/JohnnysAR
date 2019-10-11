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
        Material material;

    static readonly int _textureStencil = Shader.PropertyToID("_textureStencil");

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
            material.SetTexture(_textureStencil, stencil);
        }
    }
}