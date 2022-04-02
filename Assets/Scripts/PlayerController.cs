using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public Rigidbody2D rb;
    public int jumpForce = 25;
    public bool isOnGround = true;
    public float gravityModifier;
    public bool hasPowerup = false; 
    private bool jumpHigh; 
    private bool destroyEnemy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed); 
        if (Input.GetKeyDown(KeyCode.UpArrow) && isOnGround)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            rb.AddForce(Vector2.left * 7, ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            rb.AddForce(Vector2.right * 7, ForceMode2D.Impulse);
        }
    }

    void KeepInBounds(){
        if (transform.position.x < -752)
        {
            transform.position = new Vector2(-752, transform.position.y);
        }

        if (transform.position.x > 1346)
        {
            transform.position = new Vector2(1346, transform.position.y);
        }
    }
}
