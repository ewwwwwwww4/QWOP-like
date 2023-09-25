using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public HingeJoint2D Rupperleg;
    public HingeJoint2D Lupperleg;
    public HingeJoint2D Rlowerleg;
    public HingeJoint2D Llowerleg;

    private JointMotor2D RupperlegMotorRef;
    private JointMotor2D LupperlegMotorRef;
    private JointMotor2D RlowerlegMotorRef;
    private JointMotor2D LlowerlegMotorRef;
    public float highspeed = 140;

    // Start is called before the first frame update
    void Start()
    {
        RupperlegMotorRef = Rupperleg.motor;
        LupperlegMotorRef = Lupperleg.motor;
        RlowerlegMotorRef = Rlowerleg.motor;
        LlowerlegMotorRef = Llowerleg.motor;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Rupperleg.useMotor = true;
            Lupperleg.useMotor = true;
            RupperlegMotorRef.motorSpeed = -highspeed;
            LupperlegMotorRef.motorSpeed = highspeed;
            Rupperleg.motor = RupperlegMotorRef;
            Lupperleg.motor = LupperlegMotorRef;

        }
        else if (Input.GetKey(KeyCode.W))
        {
            Rupperleg.useMotor = true;
            Lupperleg.useMotor = true;
            RupperlegMotorRef.motorSpeed = highspeed;
            LupperlegMotorRef.motorSpeed = -highspeed;
            Rupperleg.motor = RupperlegMotorRef;
            Lupperleg.motor = LupperlegMotorRef;

        }
        else
        {
            Rupperleg.useMotor = false;
            Lupperleg.useMotor = false;
        }
        if (Input.GetKey(KeyCode.O))
        {
            Rlowerleg.useMotor = true;
            Llowerleg.useMotor = true;
            RlowerlegMotorRef.motorSpeed = -highspeed;
            LlowerlegMotorRef.motorSpeed = highspeed;
            Rlowerleg.motor = RlowerlegMotorRef;
            Llowerleg.motor = LlowerlegMotorRef;

        }
        else if (Input.GetKey(KeyCode.P))
        {
            Rlowerleg.useMotor = true;
            Llowerleg.useMotor = true;
            RlowerlegMotorRef.motorSpeed = highspeed;
            LlowerlegMotorRef.motorSpeed = -highspeed;
            Rlowerleg.motor = RlowerlegMotorRef;
            Llowerleg.motor = LlowerlegMotorRef;

        }
        else
        {
            Rlowerleg.useMotor = false;
            Llowerleg.useMotor = false;
        }

    }
}
