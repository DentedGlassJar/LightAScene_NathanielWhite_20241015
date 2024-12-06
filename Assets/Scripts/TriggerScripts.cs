using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScripts : MonoBehaviour
{
    public PlayableDirector ghostTimeline;
    public PlayableDirector fireTimeline;

    private void Start()
    {
        fireTimeline.Stop();
        ghostTimeline.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            ghostTimeline.Play();
            Debug.Log("Timeline is playing!");
        }

        if (other.gameObject.CompareTag("Trigger2"))
        {
            fireTimeline.Play();
            Debug.Log("Timeline is playing!");
        }


    }
}
