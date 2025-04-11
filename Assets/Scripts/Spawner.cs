using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coletavelPrefab;
    public int quantidade = 5;
    public float minX = -8f, maxX = 8f;
    public float minY = -4f, maxY = 4f;

    void Start()
    {
        GameController.AddCollectables(quantidade);

        for (int i = 0; i < quantidade; i++)
        {
            Vector2 pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate(coletavelPrefab, pos, Quaternion.identity);
        }
    }

}
