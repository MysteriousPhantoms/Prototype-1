using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int maxLives = 3;
    public int currentLives;

    public LivesUI livesUI;

    void Start()
    {
        currentLives = maxLives;
        livesUI.UpdateLives(currentLives);
    }

    public void LoseLife()
    {
        currentLives--;
        livesUI.UpdateLives(currentLives);

        if (currentLives <= 0)
        {
            currentLives = 0;
            FindObjectOfType<SurvivalTimer>().PlayerDied();
            Debug.Log("Player Out of Lives");
        }
    }
}
