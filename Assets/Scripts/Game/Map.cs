using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Init
        BlockScript.script = new List<int>();
        GameObject.Find("scriptText").GetComponent<Text>().text = "";
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
