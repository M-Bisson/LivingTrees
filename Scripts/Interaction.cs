using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Interaction : MonoBehaviour

{
    GameObject bottle;
    GameObject takeout;
    GameObject candy;
    ParticleSystem smoke;
    AudioSource success;
    GameObject roots;
    GameObject endCharacter;
    PlayableDirector endTimeline;
    GameObject endingCameras;
    GameObject mainTimeline;
    GameObject gameCharacter;
    GameObject gamePlayCanvas;
    GameObject pressXToInteract;

    // Start is called before the first frame update
    void Start()
    {
        
        bottle = GameObject.Find("Bottle");
        takeout = GameObject.Find("TakeOut");
        candy = GameObject.Find("Candy");
        smoke = GameObject.Find("FirePit").GetComponent<ParticleSystem>();
        success = GameObject.Find("Success").GetComponent<AudioSource>();
        roots = GameObject.Find("GameRoots");
        endTimeline = GameObject.Find("End Cutscene Timeline").GetComponent<PlayableDirector>();
        endCharacter = GameObject.Find("Ending Character");
        endCharacter.SetActive(false);
        endingCameras = GameObject.Find("Ending Cameras");
        endingCameras.SetActive(false);
        mainTimeline = GameObject.Find("TIMELINE");
        gameCharacter = GameObject.Find("Character 3rd Person");
        gamePlayCanvas = GameObject.Find("Game Play Canvas");
        pressXToInteract = GameObject.Find("Interact");
        pressXToInteract.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Bottle")
        {
            if (!pressXToInteract.activeSelf)
            {
                pressXToInteract.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                success.Play(0);
                bottle.SetActive(false);
                pressXToInteract.SetActive(false);
            }
        }
        else if (collision.gameObject.name == "TakeOut")
        {
            if (!pressXToInteract.activeSelf)
            {
                pressXToInteract.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                success.Play(0);
                takeout.SetActive(false);
            }
        }
        else if (collision.gameObject.name == "Candy")
        {
            if (!pressXToInteract.activeSelf)
            {
                pressXToInteract.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                success.Play(0);
                candy.SetActive(false);
            }

        } 
        else if (collision.gameObject.name == "FirePit")
        {
            if (!pressXToInteract.activeSelf)
            {
                pressXToInteract.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                success.Play(0);
                smoke.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
            }
        }
        else if(collision.gameObject.name == "Game Roots")
        {
            if (!pressXToInteract.activeSelf)
            {
                pressXToInteract.SetActive(true);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                gamePlayCanvas.SetActive(false);
                gameCharacter.SetActive(false);
                mainTimeline.SetActive(false);
                endCharacter.SetActive(true);
                endingCameras.SetActive(true);
                endTimeline.Play();
            }
        } else
        {
            pressXToInteract.SetActive(false);
        }
    }
}
