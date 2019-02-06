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
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            playerPos.x += speed;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            playerPos.y -= speedV;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            playerPos.y += speedV;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            playerPos.x -= speed;
        }
        playerTf.position = playerPos;
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
