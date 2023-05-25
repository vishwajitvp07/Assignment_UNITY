using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text newscore;
    int score = 0;
    public GameObject ScorePannel;
    public Text newHighscore;
    
    int highscore = 0;


    void Start()
    {


        highscore = PlayerPrefs.GetInt("highscore", 0);
        newscore.text = "" + score.ToString();
        newHighscore.text = "" + highscore.ToString();
    }

    private void Awake()
    {
        instance = this;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Addpoint()
    {

        score += 1;
        newscore.text = "" + score.ToString();
        if (highscore < score)
            PlayerPrefs.SetInt("highscore", score);
        Debug.Log("Score" + score);
        if(score == 4)
        {
            ScorePannel.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
