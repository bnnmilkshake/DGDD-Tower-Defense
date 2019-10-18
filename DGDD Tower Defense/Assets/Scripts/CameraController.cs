using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraPanSpeed;
    float modifier = 0; 
    public float screenPixelLimit;

    public float yMin, yMax;
    public float xMin, xMax;
    public float zMin, zMax;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            modifier = 5; 
        } else
        {
            modifier = 1; 
        }



        Vector3 cameraPos = transform.position; //allow us to get the all 3 pos of the camera, x, y and z

        if (Input.GetKey(KeyCode.W) || Input.mousePosition.y >= Screen.height - screenPixelLimit)
        {
            cameraPos.z += modifier * cameraPanSpeed * Time.deltaTime; //allow us to control the camera z pos in frames
        }

        if (Input.GetKey(KeyCode.S) || Input.mousePosition.y <= screenPixelLimit)
        {
            cameraPos.z += modifier * -cameraPanSpeed * Time.deltaTime; //allow us to control the camera z pos in frames
        }

        if (Input.GetKey(KeyCode.D) || Input.mousePosition.x >= Screen.width - screenPixelLimit)
        {
            cameraPos.x += modifier * cameraPanSpeed * Time.deltaTime; //allow us to control the camera x pos in frames
        }

        if (Input.GetKey(KeyCode.A) || Input.mousePosition.x <= screenPixelLimit)
        {
            cameraPos.x += modifier * -cameraPanSpeed * Time.deltaTime; //allow us to control the camera x pos in frames
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            cameraPos.y += modifier * cameraPanSpeed * Time.deltaTime;
        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            cameraPos.y += modifier * -cameraPanSpeed * Time.deltaTime;
        }

        //set limits for camera
        cameraPos.y = Mathf.Clamp(cameraPos.y, yMin, yMax);
        cameraPos.x = Mathf.Clamp(cameraPos.x, xMin, xMax);
        cameraPos.z = Mathf.Clamp(cameraPos.z, zMin, zMax);

        transform.position = cameraPos;
    }
}
