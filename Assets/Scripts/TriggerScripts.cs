using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScripts : MonoBehaviour
{
    public PlayableDirector ghostTimeline;
    public PlayableDirector fireTimeline;
    public PlayableDirector roomTimeline;

    public GameObject ghostTrigger;
    public GameObject fireTrigger;
    public GameObject roomTrigger;

    public GameObject JunkPileObj;

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
            ghostTrigger.SetActive(false);
        }

        if (other.gameObject.CompareTag("Trigger2"))
        {
            fireTimeline.Play();
            Debug.Log("Timeline is playing!");
            fireTrigger.SetActive(false);
        }

        if(other.gameObject.CompareTag("Trigger3"))
        {
            JunkPileObj.SetActive(true);

            roomTrigger.SetActive(false);
        }
    }
}
