using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SSVEP : MonoBehaviour
{
    public Image img;
    public float ssvepFrequency = 10.0f; // SSVEP frequency in Hz
    private float lastToggleTime = 0.0f; // Time of last visibility toggle
    private float oneSecCount = 0.0f;
    private int toggleCount = 0;
    private UnityEngine.Color __alpha;
    // Start is called before the first frame update
    void Start()
    {
        img.enabled = true;
        __alpha = img.color;
        __alpha.a = (1+Mathf.Sin(2 * Mathf.PI * ssvepFrequency * Time.time))/2;
        img.color = __alpha;
        oneSecCount = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        // Calculate the time since the last stimulus toggle
        float timeSinceLastToggle = Time.time - lastToggleTime;
        float elapsedTime = Time.time - oneSecCount;
        // Check if it's time to toggle the stimulus
        if (timeSinceLastToggle >= 1.0f / (2.0f * ssvepFrequency))
        {
          //  print(timeSinceLastToggle);
            // Toggle the stimulus
            img.enabled = !img.enabled;
            toggleCount++;
            // Record the time of the toggle
            lastToggleTime = Time.time;
        }
        if(elapsedTime >= 1)
        {
            print(toggleCount);
            oneSecCount = Time.time;
            toggleCount = 0;

        }*/
        __alpha.a = (1 + Mathf.Sin(2 * Mathf.PI * ssvepFrequency * Time.time)) / 2;
        img.color = __alpha;

    }
}
