using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int vidaMaxima = 3;
    public int vidaAtual;
    public GameObject painelGameOver;

    void Start()
    {
        vidaAtual = vidaMaxima;
    }

    public void LevarDano(int dano)
    {
        vidaAtual -= dano;

        if (vidaAtual <= 0)
        {
            vidaAtual = 0;
            painelGameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void ResetarVida()
    {
        vidaAtual = vidaMaxima;
    }

}
