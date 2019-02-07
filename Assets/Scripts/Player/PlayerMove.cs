using System.Collections;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed = 1.25f; // 타일 가로
    public float speedV = 1.28f; // 타일 세로
    private Transform playerTf;
    private Vector3 playerPos;

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

    IEnumerator Move()
    {
        foreach (int element in BlockScript.script)
        {
            if (element == BlockScript.UP) { MoveUp(); }
            else if (element == BlockScript.DOWN) { MoveDown(); }
            else if (element == BlockScript.LEFT) { MoveLeft(); }
            else if (element == BlockScript.RIGHT) { MoveRight(); }
            yield return new WaitForSeconds(0.5f);
        }
    }

    public void MoveRight()
    {
        playerPos.x += speed;
    }
    public void MoveLeft()
    {
        playerPos.x -= speed;
    }
    public void MoveUp()
    {
        playerPos.y += speedV;
    }
    public void MoveDown()
    {
        playerPos.y -= speedV;
    }
}
