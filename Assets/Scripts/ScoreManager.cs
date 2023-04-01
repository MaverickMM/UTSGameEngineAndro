using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;


    int score = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void AddPointm()
    {
        score += 10;
        scoreText.text = score.ToString();
    }
        public void AddPointb()
    {
        score += 20;
        scoreText.text = score.ToString();
    }
        public void AddPointk()
    {
        score += 15;
        scoreText.text = score.ToString();
    }
        public void MinPointm()
    {
        score -= 10;
        scoreText.text = score.ToString();
    }
        public void MinPointb()
    {
        score -= 20;
        scoreText.text = score.ToString();
    }
        public void MinPointk()
    {
        score -= 15;
        scoreText.text = score.ToString();
    }


}
