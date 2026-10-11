using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager Instance;

    [Header("UI Reference")]
    public TextMeshProUGUI scoreText;

    private int currentScore = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreUI();
        
    }

    public void AddScore(int amount)
    {
        currentScore += amount;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if(scoreText != null)
        {
            scoreText.text = $"Score: {currentScore}";
        }
    }

}
