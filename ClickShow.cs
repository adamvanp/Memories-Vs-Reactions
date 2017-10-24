//Adam Van Peelen 2017
//    Used to show the graphic on screen when a user clicks the objects
//    03/10/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickShow : MonoBehaviour {
    public GameObject ClickIcon;
    // Use this for initialization
 
    public void ActivateIcon(Vector2 touchPos)
    {
        ClickIcon.SetActive(true);
        ClickIcon.transform.position = touchPos;

        StartCoroutine(ShowClick(.1f));
    }


    IEnumerator ShowClick(float time)
    {
        yield return new WaitForSeconds(time);
        ClickIcon.SetActive(false);
        
        

    }
}
