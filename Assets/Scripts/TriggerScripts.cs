using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class TriggerScripts : MonoBehaviour
{
    public PlayableDirector ghostTimeline;
    public PlayableDirector fireTimeline;
    public PlayableDirector nathanielTimeline;

    public GameObject ghostTrigger;
    public GameObject fireTrigger;
    public GameObject nathanielTrigger;

    public GameObject JunkPileObj;

    private void Start()
    {
        fireTimeline.Stop();
        ghostTimeline.Stop();
        nathanielTimeline.Stop();
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

            nathanielTimeline.Play();

            nathanielTrigger.SetActive(false);
        }

        if (other.gameObject.CompareTag("NathanielTrigger"))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
