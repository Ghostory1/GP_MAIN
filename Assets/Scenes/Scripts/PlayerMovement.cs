using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed = 10;
    [SerializeField]
    float rotationSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0,0,1 * Time.deltaTime * speed);

        if(Input.GetKey(KeyCode.W)) { transform.Translate(0,0,Time.deltaTime * speed);}
        if(Input.GetKey(KeyCode.S)) { transform.Translate(0,0,-Time.deltaTime * speed);}
        if(Input.GetKey(KeyCode.A)) { transform.Translate(-Time.deltaTime * speed,0,0);}
        if(Input.GetKey(KeyCode.D)) { transform.Translate(Time.deltaTime * speed,0,0);}
        if(Input.GetKey(KeyCode.Q)) {transform.Translate(0,Time.deltaTime * speed,0);}
        if(Input.GetKey(KeyCode.E)) {transform.Translate(0,-Time.deltaTime * speed,0);}

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0,mouseX * rotationSpeed,0);

        float mouseY = Input.GetAxis("Mouse Y");
        transform.Rotate(0,0,mouseY * rotationSpeed);
        
        
    }
}
