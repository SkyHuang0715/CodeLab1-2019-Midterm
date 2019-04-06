using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //int score;
    public Text scoreText;
    public Text highScoreText;

    private const string PLAYER_PREF_HIGHSCORE = "highScore "; //const= constant means sth doest change
    private const string FILE_HIGH_SCORE = "_MyHighScoreFile.txt";
    

    int score = 0;

    public int Score
    {

        get
        {
            return score;
        }
        
        set
        {
            score = value;
            scoreText.text = "Score " + score;
            HighScore = score;
        }
    }

    private int highScore = 0;

    public int HighScore
    {
        get
        {
            return highScore;
            
        }
        set
        {
            if (value > highScore) //when score > high score, renew the high score to current score
            {
                highScore = value;
                highScoreText.text = "High Score " + highScore;
                PlayerPrefs.SetInt(PLAYER_PREF_HIGHSCORE, highScore);


             Debug.Log("Application.dataPath: "+ Application.dataPath);
                //game data folder
             string fullPathToFile = Application.dataPath + "/" + FILE_HIGH_SCORE;
                
             
                   File.WriteAllText(fullPathToFile, "High Score" + highScore); 
                  
            }
        }
    }

    public static GameManager instance;
    
    
    // Start is called before the first frame update
    void Start()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            

        }
        else
        {
            Destroy(gameObject);
        }

        Score = 0;

        //HighScore = PlayerPrefs.GetInt(PLAYER_PREF_HIGHSCORE, 10);

        string highScoreFileTxt = File.ReadAllText(Application.dataPath + FILE_HIGH_SCORE);

        string[] scoreSplit = highScoreFileTxt.Split(' ');
        
        highScore = Int32.Parse(scoreSplit[1]);

        // print(File.ReadAllText(Application.dataPath + FILE_HIGH_SCORE));


    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
