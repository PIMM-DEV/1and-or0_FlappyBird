using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float Score;
    public float timer;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;
    [SerializeField] GameOverManager gameOverManager;

    void Awake()
    {
        Score = 0;
    }

    void Update()
    {
        if (!gameOverManager.isGameOver)
        {
            SetTimerAndScore();
        }

        UpdateScoreTMP();
    }

    void SetTimerAndScore()
    {
        timer += Time.deltaTime;
        Score = Mathf.Floor(timer * 10f) * 10 / 2;
    }

    void UpdateScoreTMP()
    {
        textMeshProUGUI.text = $"Score: {Score}";
    }
}
