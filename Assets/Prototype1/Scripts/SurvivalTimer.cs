using UnityEngine;
using TMPro;

public class SurvivalTimer : MonoBehaviour
{
    public float timeSurvived = 0f;
    private bool isAlive = true;

    public TextMeshProUGUI timerText;

    void Update()
    {
        if (isAlive)
        {
            timeSurvived += Time.deltaTime;
            if (timerText != null)
                timerText.text = timeSurvived.ToString("F2");
        }
    }

    public void PlayerDied()
    {
        isAlive = false;
        Debug.Log("Final Time: " + timeSurvived);
    }
}
