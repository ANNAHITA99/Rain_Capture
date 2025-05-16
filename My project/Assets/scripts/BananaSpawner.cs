using UnityEngine;

public class BananaSpawner : MonoBehaviour
{
    public GameObject bananaPrefab;  // پیش‌ساخته موز
    public float spawnInterval = 1.5f;  // فاصله زمانی بین اسپان
    public float minX = -7f;
    public float maxX = 7f;
    public float spawnY = 5f;

    void Start()
    {
        // هر چند ثانیه یک بار متد اسپانر رو صدا بزن
        InvokeRepeating("SpawnBanana", 1f, spawnInterval);
    }

    void SpawnBanana()
    {
        // موقعیت تصادفی در محور X
        float randomX = Random.Range(minX, maxX);
        Vector2 spawnPosition = new Vector2(randomX, spawnY);

        // ساختن موز در موقعیت جدید
        Instantiate(bananaPrefab, spawnPosition, Quaternion.identity);
    }
}
