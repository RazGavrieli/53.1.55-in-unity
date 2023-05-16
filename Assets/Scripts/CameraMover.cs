using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    private Vector3 CameraPosition;
    public float CameraSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            CameraPosition.y += CameraSpeed/10;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            CameraPosition.y -= CameraSpeed/10;
        }
        if(Input.GetKey(KeyCode.A))
        {
            CameraPosition.x -= CameraSpeed/10;
        }
        if(Input.GetKey(KeyCode.D))
        {
            CameraPosition.x += CameraSpeed/10;
        }
        if(Input.GetKey(KeyCode.S))
        {
            CameraPosition.z -= CameraSpeed/10;
        }
        if(Input.GetKey(KeyCode.W))
        {
            CameraPosition.z += CameraSpeed/10;
        }
        //when press left arrow key camera will rotate left
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, -CameraSpeed, 0);
        }
        //when press right arrow key camera will rotate right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, CameraSpeed, 0);
        }


        this.transform.position = CameraPosition;
    }
}
