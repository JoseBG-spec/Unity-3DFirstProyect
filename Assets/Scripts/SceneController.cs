using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private float timer;
    [SerializeField]
    private GameObject text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timerT();
    }
    private void timerT()
    {
        timer -= 1*Time.deltaTime;
        if (timer <= 0)
        {
            DoThing();
        }

    }
    private void DoThing()
    {
        text.active = false;
    }
}
