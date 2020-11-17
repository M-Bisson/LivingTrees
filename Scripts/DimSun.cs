using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimSun : MonoBehaviour
{
    GameObject bottle;
    GameObject takeout;
    GameObject candy;
    GameObject cutsceneSun;
    GameObject roots;
    Light sun;
    ParticleSystem smoke;
    AudioSource rootCrackle;
    bool complete;
    bool gotBottle;
    bool gotTakeOut;
    bool gotCandy;
    bool putOutFire;
    bool rootsGrown;

    // Start is called before the first frame update
    void Start()
    {
        // turn off the cutscene sun
        cutsceneSun = GameObject.Find("Sun");
        cutsceneSun.SetActive(false);
        bottle = GameObject.Find("Bottle");
        takeout = GameObject.Find("TakeOut");
        candy = GameObject.Find("Candy");
        sun = GameObject.Find("GameSun").GetComponent<Light>();
        smoke = GameObject.Find("FirePit").GetComponent<ParticleSystem>();
        roots = GameObject.Find("Game Roots");
        roots.SetActive(false);
        rootCrackle = GameObject.Find("RootCrackle").GetComponent<AudioSource>();

        complete = false;
        sun.intensity = .2F;
        gotBottle = false;
        gotCandy = false;
        gotTakeOut = false;
        putOutFire = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gotBottle && gotCandy && gotTakeOut && putOutFire && !complete)
        {
            roots.SetActive(true);
            rootCrackle.Play(0);
            complete = true;
        }

        if (!complete)
        {
            if(bottle.activeSelf == false && gotBottle == false)
            {
                gotBottle = true;
                sun.intensity += .4F;
            }
            if(takeout.activeSelf == false && gotTakeOut == false)
            {
                gotTakeOut = true;
                sun.intensity += .4F;
            }
            if(candy.activeSelf == false && gotCandy == false)
            {
                gotCandy = true;
                sun.intensity += .4F;
            }
            if(smoke.isStopped && putOutFire == false)
            {
                putOutFire = true;
                sun.intensity += .4F;
            }
        }
    }
}
