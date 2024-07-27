using UnityEngine;

public class BlockFall : MonoBehaviour
{
    private bool isFalling = false;
    private AudioSource audioSource;
    public AudioClip crashSound; // Assign this in the Inspector

    private void Start()
    {
        // Add an AudioSource component to the block
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = crashSound;
        audioSource.playOnAwake = false;
    }

    public void TriggerFall()
    {
        if (!isFalling)
        {
            isFalling = true;
            // Add Rigidbody component to simulate falling
            if (!GetComponent<Rigidbody>())
            {
                gameObject.AddComponent<Rigidbody>();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isFalling && collision.relativeVelocity.magnitude > 2)
        {
            // Play sound when the block hits the ground or another block
            audioSource.Play();
        }
    }
}
