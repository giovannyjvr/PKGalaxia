using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    public GameObject novoVilaoPrefab;
    public float minX = -6f, maxX = 6f;
    public float minY = -3f, maxY = 3f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Gera novo vilão círculo em posição aleatória
            Vector2 pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate(novoVilaoPrefab, pos, Quaternion.identity);

            Destroy(gameObject); // destrói este vilão
        }
    }
}
