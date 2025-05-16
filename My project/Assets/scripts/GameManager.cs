using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Slider healthBar;
    public int health = 50;

    private void Awake()
    {
        // Singleton pattern
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        if (healthBar != null)
        {
            healthBar.value = 50;
        }
        else
        {
            Debug.LogError("healthBar is not assigned in the inspector!");
        }
    }

    public void AddHealth(int amount)
    {
        health += amount;
        health = Mathf.Clamp(health, 0, 100);
        healthBar.value = health;
    }
}

