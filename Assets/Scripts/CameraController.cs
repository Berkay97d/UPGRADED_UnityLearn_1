using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //editörde göster ?????   türü       ismi
    [SerializeField] private GameObject Araba;
    [SerializeField] private Vector3 offset;
    
    
    void LateUpdate()
    {
        transform.position = Araba.transform.position + offset;
    }
}
