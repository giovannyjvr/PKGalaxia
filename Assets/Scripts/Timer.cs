using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float tempoInicial = 30f; // segundos
    private float tempoRestante;
    public Text textoTimer;
    public GameObject painelFimDeJogo;

    void Start()
    {
        tempoRestante = tempoInicial;
    }

    void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
            textoTimer.text = "Tempo: " + Mathf.Ceil(tempoRestante).ToString();
        }
        else
        {
            tempoRestante = 0;
            textoTimer.text = "Tempo: 0";
            painelFimDeJogo.SetActive(true);
            Time.timeScale = 1f; // pausa o jogo
        }
    }
}
