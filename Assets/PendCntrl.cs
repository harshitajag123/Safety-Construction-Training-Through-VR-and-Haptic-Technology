using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PendCntrl : MonoBehaviour
{
    public GameObject pendulum;
    public float slowSpeed = 100f;
    public float mediumSpeed = 200f;
    public float fastSpeed = 300f;
    public bool movependulum;
    public Button resetButton;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    
    private bool flag;
    private float pendulumspeed;
    private Quaternion initialRotation;
    private Rigidbody pendulumRb;

    private void Start()
    {
        if (pendulum == null)
        {
            Debug.LogError("Pendulum GameObject not assigned!");
            return;
        }

        pendulumRb = pendulum.GetComponent<Rigidbody>();
        if (pendulumRb == null)
        {
            Debug.LogError("Pendulum Rigidbody component not found!");
            return;
        }

        initialRotation = pendulum.transform.rotation;

        // Assign button click listeners
        button1.onClick.AddListener(OnClickButton1);
        button2.onClick.AddListener(OnClickButton2);
        button3.onClick.AddListener(OnClickButton3);
        button4.onClick.AddListener(OnClickButton4);
        resetButton.onClick.AddListener(OnClickResetButton);
    }

    private void Update()
    {
        if (movependulum)
        {
            // Add torque to the pendulum to control its speed
            pendulumRb.AddTorque(-Vector3.right * pendulumspeed);
        }

        // Stop the pendulum if it reaches a certain angle
        if (pendulum.transform.eulerAngles.x < 320f && !flag)
        {
            movependulum = false;
            pendulumRb.Sleep();
            flag = true;
        }
    }

    public void OnClickButton1()
    {
        pendulumspeed = 1f;
        movependulum = true;
        flag = false;
    }

    public void OnClickButton2()
    {
        pendulumspeed = 9f;
        movependulum = true;
        flag = false;
    }

    public void OnClickButton3()
    {
        pendulumspeed = 25f;
        movependulum = true;
        flag = false;
    }

    public void OnClickButton4()
    {
        pendulumspeed = 300f;
        movependulum = true;
        flag = false;
    }

    public void OnClickResetButton()
    {
        movependulum = false;
        flag = true;
        pendulum.transform.rotation = initialRotation;
        pendulumRb.velocity = Vector3.zero;
        pendulumRb.angularVelocity = Vector3.zero;
    }
}
