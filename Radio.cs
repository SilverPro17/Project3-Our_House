using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interface IUseable definida corretamente
public interface IUseable
{
    void Use();
}

public class Radio : MonoBehaviour, IUseable
{
    public AudioSource audioSource;

    // Implementação do método Use
    public void Use()
    {
        // Alterna o estado do AudioSource
        audioSource.enabled = !audioSource.enabled;
    }
}
