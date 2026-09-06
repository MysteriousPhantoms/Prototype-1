using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public GameObject endPanel;
    public TextMeshProUGUI endMessage;

    public void ShowEndScreen(float finalTime)
    {
        endPanel.SetActive(true);
        endMessage.text = "You survived " + finalTime.ToString("F2") + " seconds";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
