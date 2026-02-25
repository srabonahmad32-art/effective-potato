using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeManager : MonoBehaviour
{
    public bool extremeMode;
    public int playerHealth = 100;

    public void TakeDamage(int amount)
    {
        playerHealth -= amount;

        if (playerHealth <= 0)
        {
            if (extremeMode)
            {
                PlayerPrefs.DeleteAll(); // wipe save
            }

            SceneManager.LoadScene("MainMenu");
        }
    }
}