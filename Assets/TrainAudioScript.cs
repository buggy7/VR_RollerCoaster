using UnityEngine;
using System.Collections;

public class TrainAdudioScript : MonoBehaviour
{
    public GameObject wtever;
    // Use this for initialization
    void Start()
    {
        AudioSource TrainAudio = wtever.GetComponent<AudioSource>();
        TrainAudio.loop = true;
        TrainAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}