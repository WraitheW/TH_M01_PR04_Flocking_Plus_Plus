using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    Toggle obstacleToggle;
    public GameObject[] obstacles;
    // Start is called before the first frame update
    void Start()
    {
        obstacleToggle = Toggle.FindObjectOfType<Toggle>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (obstacleToggle.isOn == true)
        {
            foreach (GameObject go in obstacles)
            {
                go.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject go in obstacles)
            {
                go.SetActive(false);
            }
        }
    }
}
