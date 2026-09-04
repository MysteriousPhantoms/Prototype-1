using UnityEngine;

public class SurvivalTimer : MonoBehaviour
{
    public float timeSurvived = 0f;
    private bool isAlive = true;

    void Update()
    {
        if (isAlive)
            timeSurvived += Time.deltaTime;
    }

    public void PlayerDied()
    {
        isAlive = false;
        Debug.Log("Final Time: " + timeSurvived);
    }
}
