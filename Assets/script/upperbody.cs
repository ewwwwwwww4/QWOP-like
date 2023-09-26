using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upperbody : MonoBehaviour
{
    public HingeJoint2D Lupperarm;
    public HingeJoint2D Rupperarm;
    public HingeJoint2D Llowerarm;
    public HingeJoint2D Rlowerarm;
    public HingeJoint2D Lhand;
    public HingeJoint2D Rhand;

    private JointMotor2D LupperarmMotorRef;
    private JointMotor2D RupperarmMotorRef;
    private JointMotor2D LlowerarmMotorRef;
    private JointMotor2D RlowerarmMotorRef;
    private JointMotor2D LhandMotorRef;
    private JointMotor2D RhandMotorRef;

    public float hingeSpeed = 120;

    void Start()
    {
        LupperarmMotorRef = Lupperarm.motor;
        RupperarmMotorRef = Rupperarm.motor;
        LlowerarmMotorRef = Llowerarm.motor;
        RlowerarmMotorRef = Rlowerarm.motor;
        LhandMotorRef = Lhand.motor;
        RhandMotorRef = Rhand.motor;
    }

    void Update()
    {
        HandleArmControl(KeyCode.A, KeyCode.S, Lupperarm, Rupperarm, LupperarmMotorRef, RupperarmMotorRef);
        HandleArmControl(KeyCode.D, KeyCode.F, Llowerarm, Rlowerarm, LlowerarmMotorRef, RlowerarmMotorRef);
        HandleHandControl(KeyCode.G, KeyCode.H, Lhand, Rhand, LhandMotorRef, RhandMotorRef);
    }

    void HandleArmControl(KeyCode forwardKey, KeyCode backwardKey, HingeJoint2D leftJoint, HingeJoint2D rightJoint, JointMotor2D leftMotor, JointMotor2D rightMotor)
    {
        if (Input.GetKey(forwardKey))
        {
            leftJoint.useMotor = true;
            rightJoint.useMotor = true;
            leftMotor.motorSpeed = -hingeSpeed;
            rightMotor.motorSpeed = hingeSpeed;
        }
        else if (Input.GetKey(backwardKey))
        {
            leftJoint.useMotor = true;
            rightJoint.useMotor = true;
            leftMotor.motorSpeed = hingeSpeed;
            rightMotor.motorSpeed = -hingeSpeed;
        }
        else
        {
            leftJoint.useMotor = false;
            rightJoint.useMotor = false;
        }

        leftJoint.motor = leftMotor;
        rightJoint.motor = rightMotor;
    }

    void HandleHandControl(KeyCode openKey, KeyCode closeKey, HingeJoint2D leftJoint, HingeJoint2D rightJoint, JointMotor2D leftMotor, JointMotor2D rightMotor)
    {
        if (Input.GetKeyDown(openKey))
        {
            leftJoint.useMotor = true;
            rightJoint.useMotor = true;
            leftMotor.motorSpeed = -hingeSpeed;
            rightMotor.motorSpeed = hingeSpeed;
        }
        else if (Input.GetKeyDown(closeKey))
        {
            leftJoint.useMotor = true;
            rightJoint.useMotor = true;
            leftMotor.motorSpeed = hingeSpeed;
            rightMotor.motorSpeed = -hingeSpeed;
        }
        else
        {
            leftJoint.useMotor = false;
            rightJoint.useMotor = false;
        }

        leftJoint.motor = leftMotor;
        rightJoint.motor = rightMotor;

       
    }
}

