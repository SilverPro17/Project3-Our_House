using UnityEngine;
using UnityEngine.Video;

public class VideoAudioFad : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public float fadeDuration = 5.0f; // Duração da diminuição do volume em segundos
    private float fadeTimer = 0.0f;

    void Start()
    {
        // Certifique-se de que o VideoPlayer está configurado para usar um AudioSource
        if (videoPlayer.audioOutputMode == VideoAudioOutputMode.AudioSource)
        {
            // Inicie o vídeo
            videoPlayer.Play();
        }
        else
        {
            Debug.LogError("O VideoPlayer não está configurado para usar um AudioSource.");
        }
    }

    void Update()
    {
        // Verifique se o vídeo está tocando
        if (videoPlayer.isPlaying)
        {
            // Incrementa o temporizador de diminuição
            fadeTimer += Time.deltaTime;

            // Calcula o novo volume com base no tempo de diminuição
            float newVolume = Mathf.Lerp(1.0f, 0.0f, fadeTimer / fadeDuration);

            // Define o novo volume no AudioSource do VideoPlayer
            videoPlayer.SetDirectAudioVolume(0, newVolume);
        }
    }
}
