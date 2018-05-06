using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemPickup : MonoBehaviour {

    public GameObject itemPickupPrefab;
    private AudioSource itemPickupAudio;
    private GameObject instantiateObject;
    public float time;

    void Awake()
    {
        itemPickupAudio = GameObject.FindGameObjectWithTag("itemPickupAudio").GetComponent<AudioSource>();
    }
            
    public void itemPickupInstantinate (Vector3 position)
    {
        itemPickupAudio.Play();
        instantiateObject = Instantiate(itemPickupPrefab, position, Quaternion.identity);
        Destroy(instantiateObject, time);
    }
}
