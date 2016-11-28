using UnityEngine;
using System.Collections;

public class ControlThemes : MonoBehaviour {

    private GameObject theme1, theme2;


    public GameObject soundStage;

    private float timeSlowMo;

    private bool slowMo, onceAlertCollision, twiceAlertCollision;

	// Use this for initialization
	void Start () {
        timeSlowMo = .0f;

        slowMo = false;
        onceAlertCollision = false;     // For Theme 1
        twiceAlertCollision = false;    // For Theme 2

        theme1 = this.transform.GetChild(0).gameObject;
        theme2 = this.transform.GetChild(1).gameObject;
	}
	
	// Update is called once per frame
	void Update () {

        // Theme 1 Floor
        if (theme1.transform.GetChild(0).gameObject.GetComponent<Theme1Floor>().hasCollided && !onceAlertCollision)
        {
            if (Time.timeScale == 1.0f)
            {
                soundStage.GetComponent<AudioSource>().Play();
                Time.timeScale = 0.1f;

                onceAlertCollision = true;
            }
        }

        // Theme 2 Floor
        if (theme2.transform.GetChild(0).gameObject.GetComponent<Theme2Floor>().hasCollided && !twiceAlertCollision)
        {
            if (Time.timeScale == 1.0f)
            {
                soundStage.GetComponent<AudioSource>().Play();
                Time.timeScale = 0.1f;

                twiceAlertCollision = true;
            }
        }

        if (Time.timeScale != 1.0f)
        {
            timeSlowMo += Time.deltaTime;
            if(timeSlowMo >= 0.2f)
            {
                //Time.timeScale = 1.0f;
                timeSlowMo = .0f;
                slowMo = true;
            }
        }

        if (slowMo)
        {
            StepUpSlowMo();
        }
	}

    private void StepUpSlowMo(){
        if(Time.timeScale != 1.0f)
        {
            timeSlowMo += Time.deltaTime;
            if (timeSlowMo >= 0.1f)
            {
                Time.timeScale +=  0.04f;
                timeSlowMo = .0f;
            }
        }

        if (Time.timeScale >= 1.0f)
        {
            Time.timeScale = 1.0f;
            slowMo = false;
        }
    }
}
