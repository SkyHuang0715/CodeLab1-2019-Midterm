using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using System.IO;
using System;


public class levelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string filePath = Application.dataPath + "/level0.txt";

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "X");
            
        }

        string[] inputLines = File.ReadAllLines(filePath);

        for (int y = 0; y < inputLines.Length; y++)
        {


            string line = inputLines[y];

            for (int x = 0; x < line.Length; x++)
            {
              //  if (line[x] == 'X')
               // {
                 //   GameObject newcube = Instantiate(Resources.Load<GameObject>("Prefab/cube"));
                //    newcube.transform.position = new Vector2(x - line.Length / 2f, line.Length / 2f - y);

              //  }else if (line[x] == 'P')
              //  {
              //      GameObject player = Instantiate(Resources.Load<GameObject>("Prefab/Player"));
              //      player.transform.position = new Vector2(x - line.Length/2f, line.Length / 2f - y);
             //   }

             GameObject tile = null;
             switch (line[x])
             {
                 case 'X':
                     tile = Instantiate(Resources.Load<GameObject>("Prefab/cube"));
                     break;
                 case 'P':
                     tile = Instantiate(Resources.Load<GameObject>("Prefab/Player"));
                     break;
                 case 'G':
                     tile = Instantiate(Resources.Load<GameObject>("Prefab/Goal"));
                     break;
                 case 'T':
                     tile = Instantiate(Resources.Load<GameObject>("Prefab/Trap"));
                     break;
                 default:
                     break;
             }

             if (tile != null)
             {
                 tile.transform.position = new Vector2(x - line.Length / 2f, inputLines.Length / 2f - y);
                 
             }
            }
        }

        // if (line[0] == "X")
      //  {
            //make a cube
        //    Instantiate(Resources.Load("Prefab/cube"));
      //  }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
