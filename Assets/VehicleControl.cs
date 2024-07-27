using UnityEngine;
using UnityEngine.UI;

public class VehicleControl : MonoBehaviour
{
    public GameObject vehicle;
    public float moveSpeed = 5f;
    public float turnSpeed = 60f;
    public Button forwardButton;
    public Button backwardButton;
    public Button leftButton;
    public Button rightButton;

    private void Start()
    {
        // Ensure vehicle is assigned
        if (vehicle == null)
        {
            Debug.LogError("Vehicle GameObject not assigned!");
            return;
        }

        // Assign button click listeners
        if (forwardButton != null)
            forwardButton.onClick.AddListener(MoveForward);
        else
            Debug.LogError("Forward Button not assigned!");

        if (backwardButton != null)
            backwardButton.onClick.AddListener(MoveBackward);
        else
            Debug.LogError("Backward Button not assigned!");

        if (leftButton != null)
            leftButton.onClick.AddListener(TurnLeft);
        else
            Debug.LogError("Left Button not assigned!");

        if (rightButton != null)
            rightButton.onClick.AddListener(TurnRight);
        else
            Debug.LogError("Right Button not assigned!");
    }

    public void MoveForward()
    {
        Debug.Log("MoveForward called");
        vehicle.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void MoveBackward()
    {
        Debug.Log("MoveBackward called");
        vehicle.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void TurnLeft()
    {
        Debug.Log("TurnLeft called");
        vehicle.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }

    public void TurnRight()
    {
        Debug.Log("TurnRight called");
        vehicle.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}
