using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelmove : MonoBehaviour
{
    public WheelJoint2D wheelJoint;
    public HingeJoint2D Rfoot; // 关联的关节
    public float motorSpeed = 100f;

    private JointMotor2D motor;

    void Start()
    {
        motor = wheelJoint.motor;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            // 启用马达
            wheelJoint.useMotor = true;

            // 设置马达的速度，正值表示顺时针旋转，负值表示逆时针旋转
            motor.motorSpeed = motorSpeed;

            // 应用马达设置到关节
            wheelJoint.motor = motor;

            // 激活关联的关节（例如，Rfoot 关节）
            Rfoot.useMotor = true;
        }
        else
        {
            // 停用马达
            wheelJoint.useMotor = false;

            // 停用关联的关节（例如，Rfoot 关节）
            Rfoot.useMotor = false;
        }
    }
}
