using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;



public class HighScoreManager : MonoBehaviour
{

    public List<string> hsNames;//make 2 lists 
    public List<int> hsScores;
    
    // Start is called before the first frame update
    void Start()
    {
        string filePath = Application.dataPath + "/highScore.txt";

        if (!File.Exists(filePath)) //if the file does not exists
        {
            //create a file
            string output = "";

            for (int i = 0; i < 10; i++)//for loop
            {
                output += "ANN:" + (10 - i) + '\n';
                
            }

            Debug.Log("output" + output);
            
           // output = "ANN: 100\nMatt:10";//[\n] means next line

           File.WriteAllText(filePath, output);
           

        }
        //else //if the file does exist
        //{
            //read file
            string[] inputLines = File.ReadAllLines(filePath);
            for (int i = 0; i < inputLines.Length; i++)
            {
                string line = inputLines[i]; //ax: "ANN:10"
                string[] splitLine = line.Split(':'); //ex: "ANN" | "10"
                string name = splitLine[0]; //ex: "ANN"
                int score = Int32.Parse(splitLine[1]);// ex: 10

                hsNames.Add(name); //put name in my list of names
                hsScores.Add(score); //put score in my list of scores
                

            }
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
