using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDeath : MonoBehaviour {

    public GameObject enemyDeathPrefab;
    private AudioSource enemyDeathAudio;
    private GameObject instantiateObject;
    public float time;

    void Awake()
    {
        enemyDeathAudio = GameObject.FindGameObjectWithTag("enemyDeathAudio").GetComponent<AudioSource>();
    }

    public void enemyDeathInstantinate(Vector3 position)
    {
        enemyDeathAudio.Play();
        instantiateObject = Instantiate(enemyDeathPrefab, position, Quaternion.identity);
        Destroy(instantiateObject, time);
    }
}
