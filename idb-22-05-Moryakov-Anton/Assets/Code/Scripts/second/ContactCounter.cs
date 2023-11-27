using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContactCounter : MonoBehaviour
{
    
    [SerializeField] private int score = 2;
    [SerializeField] private TextMeshProUGUI scoreText;


    void Start()
    {
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision other) 
    {
        DecreaseScore();    
    }
    
    void DecreaseScore()
    {
        score--; 
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

}
