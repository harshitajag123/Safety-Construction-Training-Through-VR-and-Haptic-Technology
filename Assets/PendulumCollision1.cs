using UnityEngine;

public class PendulumCollision1 : MonoBehaviour
{
    public AudioClip crashSound; // Assign this in the Inspector
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = crashSound;
        audioSource.playOnAwake = false; // Ensure the audio does not play on start
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BuildingBlock"))
        {
            // Play crash sound if pendulum hits a building block
            audioSource.Play();

            // Notify the block to fall
            collision.gameObject.GetComponent<BlockFall>().TriggerFall();
        }
    }
}
