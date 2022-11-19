using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;

    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;

    [SerializeField] private GameObject winCanvas;
    [SerializeField] private GameObject loseCanvas;
    
    
    
    void Update()
    {
        if (transform.position.y < -5)
        {
            loseCanvas.SetActive(true);
        }
        if (transform.position.z >= 365)
        {
            winCanvas.SetActive(true);
            verticalInput = 0;
            horizontalInput = 0;
        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");
        }
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput * verticalInput );
    }

    public void PlayAgain()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.Euler(new Vector3(0,0,0));
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false);
    }
}
