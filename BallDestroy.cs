//Adam Van Peelen 2017
//    Used When a player touches the object and will destroy it and effect the score
//    03/10/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    public SpawnManager EditSpawnManager;
    GameObject found;
    
    Collider2D collider2;
    // Use this for initialization
    public int Colour;
    public Audio _audioScript;
    ClickShow showIcon;

    void Start()
    {
        found = GameObject.FindGameObjectWithTag("BallManager");
        EditSpawnManager = found.GetComponent<SpawnManager>();
        collider2 = this.GetComponent<Collider2D>();
        _audioScript = GameObject.FindGameObjectWithTag("Audio Manager").GetComponent<Audio>();
        showIcon = GameObject.FindGameObjectWithTag("ClickIcon").GetComponent<ClickShow>();

    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            //Store the first touch detected.
            Touch myTouch = Input.touches[0];
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(worldPos.x, worldPos.y);
            //Check if the phase of that touch equals Began
            if (myTouch.phase == TouchPhase.Began)
            {
                
                if (collider2 == Physics2D.OverlapPoint(touchPos))
                {
                    _audioScript.PlayBlip();
                    if (Colour == 1)
                    {
                        EditSpawnManager.blue++;
                    }
                    if (Colour == 2)
                    {
                        EditSpawnManager.green++;
                    }
                    if (Colour == 3)
                    {
                        EditSpawnManager.red++;
                    }
                    if (Colour == 4)
                    {
                        EditSpawnManager.yellow++;
                    }
                    if (Colour == 5)
                    {
                        EditSpawnManager.purple++;
                    }
                    showIcon.ActivateIcon(touchPos);
                    EditSpawnManager.Total++;
                    Destroy(this.gameObject);
                }
            }
        }
    }
}


