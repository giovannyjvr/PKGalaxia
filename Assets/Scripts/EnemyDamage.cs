using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int dano = 1;
    public GameObject inimigoPrefab;
    public float minX = -8f, maxX = 8f;
    public float minY = -4f, maxY = 4f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth player = other.GetComponent<PlayerHealth>();
            if (player != null)
            {
                player.LevarDano(dano);

                // Corrigido: declarar aqui fora
                Transform playerTransform = other.transform;
                Vector2 novaPos;
                int tentativas = 0;

                do
                {
                    novaPos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                    tentativas++;
                    if (tentativas > 50) break; // segurança
                }
                while (Vector2.Distance(novaPos, playerTransform.position) < 2f); // distância mínima

                Instantiate(inimigoPrefab, novaPos, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
