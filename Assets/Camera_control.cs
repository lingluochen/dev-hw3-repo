using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_control : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;
    public Camera camera6;
    public Transform y_position_1;
    public Transform ball1;
    public Transform x_position_1;
    public Transform ball2;
    public Transform x_position_2;
    public Transform ball3;
    public Transform y_position_2;
    public Transform ball4;
    public Transform y_position_3;
    public Transform ball5;
    private bool shot2 = false;
    private bool shot3 = false;
    private bool shot4 = false;
    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
        camera4.enabled = false;
        camera5.enabled = false;
        camera6.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball1.position.y < y_position_1.position.y){
            camera2.enabled = true;
            camera1.enabled = false;
            shot2 = true;
        }

        if (ball2.position.x > x_position_1.position.x && shot2 == true)
        {
            camera2.enabled = false;
            camera3.enabled = true;
            shot3 = true;
            shot2 = false;
        }

        if (ball3.position.x > x_position_2.position.x && shot3 == true)
        {
            camera3.enabled = false;
            camera4.enabled = true;
            shot4 = true;
            shot3 = false;
        }

        if (ball4.position.x > y_position_2.position.x && shot4 == true)
        {
            camera4.enabled = false;
            camera5.enabled = true;
            shot4 = false;
        }

        if (ball5.position.y < y_position_3.position.y)
        {
            camera5.enabled = false;
            camera6.enabled = true;
        }

    }
}
