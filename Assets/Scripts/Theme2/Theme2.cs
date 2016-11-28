using UnityEngine;
using System.Collections;

public class Theme2 : MonoBehaviour {

    private GameObject[] themeCh;
    private GameObject floor;

    private bool once, isOver;

    private int currLoop;

    // Use this for initialization
    void Start () {
        themeCh = new GameObject[9];        // SARI: edw osa children exeis ektos apo duo prwta

        for (int i = 0; i < themeCh.Length; ++i)
        {
            themeCh[i] = this.transform.GetChild(i + 2).gameObject;
            themeCh[i].SetActive(false);
        }

        floor = this.transform.GetChild(0).gameObject;

        once = false;
        isOver = true;

        currLoop = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (floor.GetComponent<Theme2Floor>().hasCollided && !once)
        {
            if (currLoop < themeCh.Length)
            {
                if (isOver)
                    StartCoroutine(SpawnThemeParts(0.08f));
            }
            else
            {
                once = true;
            }
        }
    }

    IEnumerator SpawnThemeParts(float timer)
    {
        themeCh[currLoop++].SetActive(true);
        isOver = false;
        yield return new WaitForSeconds(timer);
        isOver = true;
    }
}
