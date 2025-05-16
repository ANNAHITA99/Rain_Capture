
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Slider healthSlider;
    public Image fillImage;

    void Update()
    {
        if (healthSlider.value > 50)
            fillImage.color = Color.green;
        else if (healthSlider.value > 30)
            fillImage.color = Color.yellow;
        else
            fillImage.color = Color.red;
    }
}


