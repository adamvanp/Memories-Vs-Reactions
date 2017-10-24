//Adam Van Peelen 2017
//    Used to load parts of the menu when new objects are chosen to play with and 
//    to set the PlayerPref for the game objects
//    03/10/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSelection : MonoBehaviour
{
    
    public Audio _audioScript;
    public GameObject[] balls;
    public GameObject[] squares;
    public GameObject[] triangles;
    public GameObject ActiveBalls;
    public GameObject ActiveSquare;
    public GameObject ActiveTriangle;
    public int Selection;


    // Use this for initialization
    void Start()
    {
        Selection = 0;
    }
    private void Update()
    {
        if (Selection == 0)
        {
            PlayerPrefs.SetInt("Object Selection", Selection);
        }
        else if (Selection == 1)
        {
            PlayerPrefs.SetInt("Object Selection", Selection);
        }
        else if (Selection == 2)
        {
            PlayerPrefs.SetInt("Object Selection", Selection);
        }
    }
    // Update is called once per frame
    public void Balls()
    {
        Selection = 0;
        for (int i = 0; i <= 4; i++)
        {
            balls[i].GetComponent<LoadMainMenu>().ResetStartPoint();
            balls[i].SetActive(true);
            ActiveBalls.SetActive(true);
            ActiveTriangle.SetActive(false);
            ActiveSquare.SetActive(false);
            squares[i].SetActive(false);
            triangles[i].SetActive(false);
        }
    }
    public void Square()
    {
        Selection = 1;
        for (int i = 0; i <= 4; i++)
        {
            squares[i].GetComponent<LoadMainMenu>().ResetStartPoint();
            squares[i].SetActive(true);
            ActiveBalls.SetActive(false);
            ActiveTriangle.SetActive(false);
            ActiveSquare.SetActive(true);
            balls[i].SetActive(false);
            triangles[i].SetActive(false);
        }
    }
    public void Triangles()
    {
        Selection = 2;
        for (int i = 0; i <= 4; i++)
        {
            triangles[i].GetComponent<LoadMainMenu>().ResetStartPoint();
            triangles[i].SetActive(true);
            ActiveBalls.SetActive(false);
            ActiveTriangle.SetActive(true);
            ActiveSquare.SetActive(false);
            balls[i].SetActive(false);
            squares[i].SetActive(false);
        }
    }
   
}

