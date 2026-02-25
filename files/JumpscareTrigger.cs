using UnityEngine;

public class JumpscareTrigger : MonoBehaviour
{
    public GameObject jumpscareObject;
    public AudioSource screamSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jumpscareObject.SetActive(true);
            screamSound.Play();
            Time.timeScale = 0.2f;
        }
    }
}