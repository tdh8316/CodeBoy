using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour {

    public static float speed = 1.25f; // 타일 가로
    public static float speedV = 1.28f; // 타일 세로
    private static Transform playerTf;
    private static Vector3 playerPos;

    private void Awake()
    {
        playerTf = transform;
    }

    private void Start()
    {
        playerPos = playerTf.position;
    }

    private void Update()
    {
        // Or Serial?
        if (Input.GetKeyUp(KeyCode.F5))
        {
            StartCoroutine(Move());
        }
        playerTf.position = playerPos;
    }
    
    public static IEnumerator Move()
    {
        foreach (int element in BlockScript.script)
        {
            if (element == BlockScript.UP) { MoveUp(); }
            else if (element == BlockScript.DOWN) { MoveDown(); }
            else if (element == BlockScript.LEFT) { MoveLeft(); }
            else if (element == BlockScript.RIGHT) { MoveRight(); }
            playerTf.position = playerPos;
            yield return new WaitForSeconds(0.5f);
        }
        SceneManager.LoadScene("GameOver");
    }

    public static void MoveRight()
    {
        playerPos.x += speed;
        playerTf.position = playerPos;
    }
    public static void MoveLeft()
    {
        playerPos.x -= speed;
        playerTf.position = playerPos;
    }
    public static void MoveUp()
    {
        playerPos.y += speedV;
        playerTf.position = playerPos;
    }
    public static void MoveDown()
    {
        playerPos.y -= speedV;
        playerTf.position = playerPos;
    }
}
