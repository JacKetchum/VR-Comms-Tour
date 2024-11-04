using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxCamera : MonoBehaviour
{
        [SerializeField] private Transform playerCamera;

    
    private void Update()
    {
        transform.rotation = playerCamera.rotation;
    }
}
