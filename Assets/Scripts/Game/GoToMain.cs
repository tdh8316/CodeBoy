using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMain : MonoBehaviour
{
    public void LoadMainScene()
    {
        BlockScript.script = new List<int>();
        SceneManager.LoadScene(0);
    }
}
