//Adam Van Peelen 2017
//    Used to show the show the end results for the game
//    03/10/2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {
    public Text totalScoreTxT;
    public Text colourScoreTxT;
    public GameObject AnswerText;
    public GameObject AnswerText2;
    public GameObject PlayAgain;
    public GameObject Home;
    public Text AnswerText2TxT;
    public InputField userAnswer;
    public GameObject userAnswerField;
    string Answer;
    //public EndGameScores scores;
    int cScore;
    int tScore;
    int choiceColour; //0= blue 1=green 2=red 3=yellow 4=purple
	// Use this for initialization
	void Start () {
        
        //cScore = scores.GetColourScore(cScore);
        cScore = PlayerPrefs.GetInt("Colour Score");
        tScore = PlayerPrefs.GetInt("Total Score");
        //tScore = scores.GetTotalScore(tScore);
        //choiceColour = scores.GetColourChoice(choiceColour);
        choiceColour = PlayerPrefs.GetInt("Round Choice");
        DisplayScores();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void DisplayScores()
    {
        totalScoreTxT.text = "" + tScore;
        if(choiceColour == 0 )
        {
            colourScoreTxT.text = "Blue?";
        }
        if (choiceColour == 1)
        {
            colourScoreTxT.text = "Green?";
        }
        if (choiceColour == 2)
        {
            colourScoreTxT.text = "Red?";
        }
        if (choiceColour == 3)
        {
            colourScoreTxT.text = "Yellow?";
        }
        if (choiceColour == 4)
        {
            colourScoreTxT.text = "Purple?";
        }
    }
    public void CheckScore()
    {
        Answer = cScore.ToString();
        if (userAnswer.text == Answer)
        {
            AnswerText.SetActive(true);
        }
        else
        {
            AnswerText2.SetActive(true);
            AnswerText2TxT.text = "Sorry. " + cScore;
           
        }
        PlayAgain.SetActive(true);
        Home.SetActive(true);
        userAnswerField.SetActive(false);
    }
}
