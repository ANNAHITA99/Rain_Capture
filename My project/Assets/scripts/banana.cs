using UnityEngine;

public class Banana : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.AddHealth(2);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "ground")
        {
            GameManager.instance.AddHealth(-2);
            Destroy(gameObject);
        }
    }
}

