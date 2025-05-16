using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private float moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal"); // اصلاح نوشتار
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        rb.linearVelocity = movement; // اعمال سرعت جدید
        // یا می‌توانید از MovePosition استفاده کنید:
        // rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
    }
}
