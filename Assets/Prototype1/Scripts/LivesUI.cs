using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    public Image[] brainIcons;

    public void UpdateLives(int lives)
    {
        for (int i = 0; i < brainIcons.Length; i++)
        {
            brainIcons[i].enabled = i < lives;
        }
    }
}
