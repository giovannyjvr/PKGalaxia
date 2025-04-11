using UnityEngine;

public class VilaoFinal : MonoBehaviour
{
    public int dano = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth player = other.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.LevarDano(dano);
            }
        }
    }
}
