using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int timeLeft = 120;

    [SerializeField] private Text timerText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Clock"))
        {
            Destroy(collision.gameObject);
            timeLeft += 20;
            UpdateTimerText();
        }
    }

    private void Start()
    {
        // Start the countdown and repeat it every second (1f second delay, 1f interval)
        InvokeRepeating(nameof(Countdown), 1f, 1f);
    }

    private void Countdown()
    {
        if (timeLeft > 0)
        {
            timeLeft--;
            UpdateTimerText();
        }
        else
        {
            // Countdown completed, do something here later for player timeout.
            Debug.Log("Countdown completed!");
            // Stop the repeating countdown
            CancelInvoke(nameof(Countdown));
        }
    }

    private void UpdateTimerText()
    {
        timerText.text = "Time Left: " + timeLeft + " sec";
    }
}
