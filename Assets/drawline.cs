﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawline : MonoBehaviour
{
    public LineRenderer line;
    public Transform t1;
    public Transform t2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(1, t1.position);
        line.SetPosition(0, t2.position);
    }
}
