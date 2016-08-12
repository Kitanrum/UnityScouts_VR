using UnityEngine;
using System.Collections;

public class LeftSpawn : MonoBehaviour {

    public GameObject[] pokemon;
    public GameObject[] spawn;
    public Transform[] spawnPoint;
    public float timer;

    // Use this for initialization
    void Awake()
    {

        timer = Time.time + 4;
        spawn = GameObject.FindGameObjectsWithTag("LeftSpawn");

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (timer < Time.time)
        {

            Spawn();

            timer = Time.time + 120;

        }

    }

    void Spawn()
    {

        Transform spawnPoint = spawn[Random.Range(0, 7)].transform;
        GameObject instance = (GameObject)Instantiate(pokemon[Random.Range(0, 2)], spawnPoint.transform.position, spawnPoint.transform.rotation);

        Destroy(instance, 110);

    }

}
