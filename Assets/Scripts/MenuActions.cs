using UnityEngine;
using UnityEngine.SceneManagement; 

public class MenuActions : MonoBehaviour
{
    public void IniciaJogo()
    {
        GameController.Reset(); // limpa score e contador
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;

        // Espera carregar a cena, e reseta a vida do player
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlayerHealth player = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
        player.ResetarVida();
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0); 
    }
}

