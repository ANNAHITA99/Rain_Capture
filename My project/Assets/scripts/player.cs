using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;  // سرعت حرکت پلیر

    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // دریافت ورودی افقی (چپ و راست)
        moveInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // اعمال حرکت به پلیر
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }
}
