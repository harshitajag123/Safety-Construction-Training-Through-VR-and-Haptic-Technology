using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float speed = 1.0f;
    public float maxAngle = 45.0f;

    private float angle = 0.0f;
    private bool movingRight = true;

    void Update()
    {
        float step = speed * Time.deltaTime;

        if (movingRight)
        {
            angle += step;
            if (angle >= maxAngle)
            {
                angle = maxAngle;
                movingRight = false;
            }
        }
        else
        {
            angle -= step;
            if (angle <= -maxAngle)
            {
                angle = -maxAngle;
                movingRight = true;
            }
        }

        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }
}
