using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }

    void Update()
    {
        // Exemplo de controle adicional, como parar o som quando o objeto está muito longe
        if (Vector3.Distance(transform.position, Camera.main.transform.position) > audioSource.maxDistance)
        {
            audioSource.Stop();
        }
        else if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
