using UnityEngine;
using TMPro;

public class FlashingTextTMP : MonoBehaviour
{
    public TextMeshProUGUI myText; // Referência ao componente TextMeshPro
    public Color color1 = Color.red;
    public Color color2 = Color.green;
    public Color color3 = Color.blue;
    private float speed = 1f; // Velocidade da troca de cores

    void Update()
    {
        FlashColors();
    }

    void FlashColors()
    {
        float t = Mathf.PingPong(Time.time * speed, 3); // Alterna entre 0, 1 e 2

        if (t < 1) // Primeira cor
            myText.color = Color.Lerp(color1, color2, t);
        else if (t < 2) // Segunda cor
            myText.color = Color.Lerp(color2, color3, t - 1);
        else // Terceira cor
            myText.color = Color.Lerp(color3, color1, t - 2);
    }
}
