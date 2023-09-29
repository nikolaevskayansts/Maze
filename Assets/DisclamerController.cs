using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisclamerController : MonoBehaviour
{
    float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 15;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            SceneManager.LoadScene("SampleScene");
        }

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyUp(KeyCode.Escape))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
