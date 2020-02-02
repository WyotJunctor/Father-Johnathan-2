using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Timer : MonoBehaviour
{
    public AudioSource cuckoo_source;

    const float day_length = 60f;

    const float minute_length = day_length / 1440f;
    float next_minute = minute_length;
    int minutes_elapsed;

    const int total_days = 30;
    int days_elapsed;

    const float total_time = total_days * day_length;
    float time_elapsed = 0f;

    float days_progress = 0f;

    int hours = 0;
    int minutes = 0;

    // Start is called before the first frame update
    void Start()
    {

        if (!cuckoo_source)
            throw new System.Exception("no cuckoo-clock audio source.");

        if (!cuckoo_source.clip)
            throw new System.Exception("cuckoo-clock audio source does not have cuckoo sound");
    }

    // Update is called once per frame
    void Update()
    {
        time_elapsed += Time.deltaTime;
        days_progress = time_elapsed / total_time;

        if (time_elapsed >= next_minute)
        {
            minutes++;
            if (minutes >= 60)
            {
                hours++;
                minutes = 0;
            }
            if (hours >= 24)
            {
                days_elapsed++;
                hours = 0;
                cuckoo_source.Play();
            }
        }
        print(days_progress.ToString());
    }
}
