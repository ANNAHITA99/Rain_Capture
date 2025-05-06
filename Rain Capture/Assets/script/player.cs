using UnityEngine;

public class player : MonoBehaviour
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
        moveInput = Input.GetAxisRaw("Horizental");
    }

    void FixedUpdate()
    {
        rb.Velocity = new Vector2(moveInput * moveSpeed, rb.Velocity.y);
    }
    private void fixedUpdate()
    {
        public void movement()
        {
            float xInput = xInput.GetAxis("Horizental") * moveSpeed;

            float clampedPosition = Mathf.Clamp()












        }
    }
}