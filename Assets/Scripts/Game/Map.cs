﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BlockScript.script = new List<int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SceneManager.LoadScene("GameOver");
    }
}
