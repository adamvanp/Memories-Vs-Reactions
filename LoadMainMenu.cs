//Adam Van Peelen 2017
//    Used to load the menu and get all object to its position
//    03/10/2017

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMainMenu : MonoBehaviour {
    public GameObject MenuItem;
    public Transform StartPoint;
    public Transform EndPoint;
    Vector3 EndPointVec;
    public float speed;

	// Use this for initialization
	void Start () {

        Transform pointTransform = StartPoint.transform;


        GameObject item = MenuItem;
        item.transform.position = pointTransform.position;
        

        
        SetEndPoint(EndPoint.position);

    }

    // Update is called once per frame
    void Update () {
        //speed = Mathf.Lerp(speed, .5f, 0.5f);
        transform.position = Vector3.Lerp(transform.position, EndPointVec, speed * .5f * Time.deltaTime);
        

    }

    void SetEndPoint(Vector3 transform)
    {
        EndPointVec = transform;
    }
    
    public void ResetStartPoint()
    {
        Transform pointTransform = StartPoint.transform;


        GameObject item = MenuItem;
        item.transform.position = pointTransform.position;



        SetEndPoint(EndPoint.position);
    }
}
