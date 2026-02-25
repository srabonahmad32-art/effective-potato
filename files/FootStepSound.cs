using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioSource source;

    void Update()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            if (!source.isPlaying)
                source.Play();
        }
        else
        {
            source.Stop();
        }
    }
}