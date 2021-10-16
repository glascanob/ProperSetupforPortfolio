using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flicker : MonoBehaviour
{
    public float onTime = 1f;
    public float offTime = 1f; // 1 second
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();
        StartCoroutine("TimerCoroutine");
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    IEnumerator TimerCoroutine()
    {
        while (true) 
        {
            ///fix this, the renderer needs to be turned off, not set active.
            ///set active turns off the object, and it stops responding to the coroutine.
            ///        var tmp = gameObject.GetComponent<Renderer>();

            //          gameObject.SetActive(false);
            rend.enabled = true;
            yield return new WaitForSeconds(onTime);

  //          gameObject.SetActive(true);
            yield return new WaitForSeconds(offTime);
            rend.enabled = false;
        }
    }

}
