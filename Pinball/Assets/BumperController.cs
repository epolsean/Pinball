using UnityEngine;
using System.Collections;

public class BumperController : MonoBehaviour
{

    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float flipperStrength = 10f;
    public float flipperDamper = 1F;

    void Awake()
    {
        GetComponent<HingeJoint>().useSpring = true;
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();

        spring.spring = flipperStrength;
        spring.damper = flipperDamper;

        if ((gameObject.name == "leftPaddle" && GameManager.leftPaddlePressed) || (gameObject.name == "rightPaddle" && GameManager.rightPaddlePressed))
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        GetComponent<HingeJoint>().spring = spring;
        GetComponent<HingeJoint>().useLimits = true;
        JointLimits limits = new JointLimits();
        limits.min = restPosition;
        limits.max = pressedPosition;
        GetComponent<HingeJoint>().limits = limits;
    }
}
