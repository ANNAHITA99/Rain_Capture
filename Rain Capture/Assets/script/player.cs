
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // سرعت حرکت پلیر
    public float moveSpeed = 5f;

    // متغیر برای ذخیره کردن جهت حرکت
    private Vector3 moveDirection;

    // متد آپدیت که هر فریم اجرا می‌شود
    void Update()
    {
        // دریافت ورودی‌های افقی و عمودی (WASD یا Arrow Keys)
        float horizontal = Input.GetAxis("Horizontal"); // A/D یا Left/Right Arrow
        float vertical = Input.GetAxis("Vertical");     // W/S یا Up/Down Arrow

        // تعیین جهت حرکت
        moveDirection = new Vector3(horizontal, 0, vertical);

        // حرکت دادن پلیر بر اساس ورودی‌ها
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }
}
