using UnityEngine;

public class Timer
{
    private float startTime = -1f;

    public void StartTimer()
    {
        startTime = Time.time;
    }

    public float StopTimer()
    {
        float score = Time.time - startTime;
        startTime = -1f;
        return score;
    }
}
