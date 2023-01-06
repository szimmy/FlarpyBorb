using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTrigger : MonoBehaviour
{
    public LogicManager logic;
    private AudioSource triggerSound;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        triggerSound = GameObject.FindGameObjectWithTag("Ping").GetComponent<AudioSource>();
        triggerSound.time = 0.3F;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            BirdScript bird = collision.gameObject.GetComponent<BirdScript>();
            if (bird.isAlive)
            {
                triggerSound.Play(0);
                triggerSound.SetScheduledEndTime(AudioSettings.dspTime + 0.65);
                logic.AddScore(1);
            }
        }
    }
}
