//Adam Van Peelen 2017
//    Used to handle the core of the game and the spawning of objects on the screen
//    03/10/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour {
    public int MaxOnScreen;
    public GameObject[] Balls;
    public GameObject[] Triangles;
    public GameObject[] Squares;
    // public EndGameScores endScore;

    public int NumBalls;
    public Transform Spawn;
    public  int blue, green, red, yellow, purple;
    public int RoundSelection;
    public int totalColourCount;
    //public int BallCount;
    public int Total;
    //public static int TotalScore;

    float timeLeft = 30.0f;

    // Use this for initialization
    void Start () {
        for (int i = 0; i <= 4; i++)
        {
            Balls[i].transform.localScale = new Vector3(.1f, .1f, .1f);
            Squares[i].transform.localScale = new Vector3(.1f, .1f, .1f);
            Triangles[i].transform.localScale = new Vector3(.1f, .1f, .1f);
        }
        RoundSelection = Random.Range(0, 5);
        Total = 0;
        blue = 0;
        red = 0;
        green = 0;
        yellow = 0;
        purple = 0;
        if (PlayerPrefs.GetInt("Object Selection") == 0)
        {
            StartCoroutine(SpawnBalls(Random.Range(0f, 1.4f)));
        }
        if (PlayerPrefs.GetInt("Object Selection") == 1)
        {
            StartCoroutine(SpawnSquares(Random.Range(0f, 1.4f)));
        }
        if (PlayerPrefs.GetInt("Object Selection") == 2)
        {
            StartCoroutine(SpawnTriangles(Random.Range(0f, 1.4f)));
        }


        //TotalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            if(RoundSelection == 0)
            {
                totalColourCount = blue;
            }
            else if (RoundSelection == 1)
            {
                totalColourCount = green;
            }
            else if (RoundSelection == 2)
            {
                totalColourCount = red;
            }
            else if (RoundSelection == 3)
            {
                totalColourCount = yellow;
            }
            else if (RoundSelection == 4)
            {
                totalColourCount = purple;
            }
            //endScore.SetScores(Total, totalColourCount, RoundSelection);
            PlayerPrefs.SetInt("Total Score", Total);
            PlayerPrefs.SetInt("Colour Score", totalColourCount);
            PlayerPrefs.SetInt("Round Choice", RoundSelection);

            SceneManager.LoadScene(2);
        }
    }
    void StartGame()
    {

    }

    IEnumerator SpawnBalls(float time)
    {
        while (true)
        {

            Transform pointTransform = Spawn.transform;
                int j = Random.Range(1, 4);
            for (int i = 0; i <= j; i++)
            {
                    GameObject ball = Balls[Random.Range(0, NumBalls)];
                if (ball == Balls[RoundSelection])
                {
                    ball.transform.localScale = new Vector3(.2f, .2f, .2f);

                }
                else
                {
                    ball.transform.localScale = new Vector3(.1f, .1f, .1f);
                }
                float x = Random.Range(-2.5f, 2.5f);
                float y = Random.Range(-4.5f, 4.5f);

                ball.transform.position = pointTransform.position;
                ball.transform.position = new Vector3(x, y, 0);
                ball.transform.localRotation = new Quaternion(0, 0, Random.Range(0, 360f), Random.Range(0, 360f));

                Instantiate(ball);
                

            }

            int k = Random.Range(1,3);
            for(int l = 1; l <=k; l++)
            {
                    Destroy(GameObject.FindGameObjectWithTag("Ball"));
            }
            time = Random.Range(0.5f, 1.5f);
            yield return new WaitForSeconds(time);
        }

    }

    IEnumerator SpawnSquares(float time)
    {
        while (true)
        {

            Transform pointTransform = Spawn.transform;
            int j = Random.Range(1, 4);
            for (int i = 0; i <= j; i++)
            {
                GameObject square = Squares[Random.Range(0, NumBalls)];
                if (square == Squares[RoundSelection])
                {
                    square.transform.localScale = new Vector3(.2f, .2f, .2f);
                    
                }
                else
                {
                    square.transform.localScale = new Vector3(.1f, .1f, .1f);
                    
                }
                float x = Random.Range(-2.5f, 2.5f);
                float y = Random.Range(-4.5f, 4.5f);

                square.transform.position = pointTransform.position;
                square.transform.position = new Vector3(x, y, 0);
                square.transform.localRotation = new Quaternion(0, 0, Random.Range(0, 360f), Random.Range(0, 360f));


                Instantiate(square);


            }

            int k = Random.Range(1, 3);
            for (int l = 1; l <= k; l++)
            {
                Destroy(GameObject.FindGameObjectWithTag("Square"));
            }
            time = Random.Range(0.5f, 1.5f);
            yield return new WaitForSeconds(time);
        }

    }

    IEnumerator SpawnTriangles(float time)
    {
        while (true)
        {

            Transform pointTransform = Spawn.transform;
            int j = Random.Range(1, 4);
            for (int i = 0; i <= j; i++)
            {
                GameObject triangle = Triangles[Random.Range(0, NumBalls)];
                if (triangle == Triangles[RoundSelection])
                {
                    triangle.transform.localScale = new Vector3(.2f, .2f, .2f);
                    
                }
                else
                {
                    triangle.transform.localScale = new Vector3(.1f, .1f, .1f);
                    
                }
                float x = Random.Range(-2.5f, 2.5f);
                float y = Random.Range(-4.5f, 4.5f);

                triangle.transform.position = pointTransform.position;
                triangle.transform.position = new Vector3(x, y, 0);
                triangle.transform.localRotation = new Quaternion(0, 0, Random.Range(0, 360f), Random.Range(0, 360f));

                Instantiate(triangle);


            }

            int k = Random.Range(1, 3);
            for (int l = 1; l <= k; l++)
            {
                Destroy(GameObject.FindGameObjectWithTag("Triangle"));
            }
            time = Random.Range(0.5f, 1.5f);
            yield return new WaitForSeconds(time);
        }

    }
}
