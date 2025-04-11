using UnityEngine;

public static class GameController
{
    private static int collectableCount;
    private static int score;

    public static bool gameOver => collectableCount <= 1;

    public static void Init(int quantidade)
    {
        collectableCount = quantidade;
        score = 0;
        Debug.Log("Iniciado com: " + quantidade + " coletáveis");

    }

    public static void Collect()
    {
        collectableCount--;
        score += 10;

    }

    public static void Reset()
    {
        collectableCount = 0;
        score = 0;
    }

    public static void AddCollectables(int quantidade)
    {
        collectableCount += quantidade;
    }

    public static int GetScore()
    {
        return score;
    }
}
