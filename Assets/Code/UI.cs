using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Player Player;
    public TMP_Text ScoreText;
    public GameObject DefeatUI;

    private void Update()
    {
        UpdateScore();
        CheckDefeat();
    }
    private void UpdateScore()
    {
        ScoreText.text = Player.Points.ToString();

    }
    private void CheckDefeat()
    {
        if (Player == null)
        {
            DefeatUI.SetActive(true);
        }
    }
    public void OnClickRestart()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }
}
