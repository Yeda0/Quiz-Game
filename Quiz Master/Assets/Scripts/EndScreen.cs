using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI finalScoreText;
    private ScoreKeeper _scoreKeeper;
    void Awake()
    {
        _scoreKeeper = FindObjectOfType<ScoreKeeper>();
        
        
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Parabéns \n voce conseguiu : " + _scoreKeeper.CalculateScore()
        + "%";
    }
   
}
