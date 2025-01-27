﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController1 : MonoBehaviour
{
    private HingeJoint myHingeJoint;
    private float defaultAngle = 20;
    private float flickAngle = -20;
    // Start is called before the first frame update
    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z") && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyDown("x") && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyUp("z") && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp("x") && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

    }

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
