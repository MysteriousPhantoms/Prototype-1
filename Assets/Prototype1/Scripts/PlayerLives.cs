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

            SurvivalTimer timer = FindObjectOfType<SurvivalTimer>();
            timer.PlayerDied(); // stop timer

            EndScreen endScreen = FindObjectOfType<EndScreen>();
            endScreen.ShowEndScreen(timer.timeSurvived); // show end screen
        }
    }
}
