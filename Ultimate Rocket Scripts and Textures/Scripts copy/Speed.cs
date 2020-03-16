using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public GameObject Cloud;
    public GameObject Asteroid;
    public GameObject CameraA;
    public GameObject Background;
    public GameObject cutOff;
    public float speed;
    public float acceleration;
    float spawnTime;
    float ySpawn;
    float yHeight;
    int asteroidChance;
    public float cSpawn;
    public float xAspect;

    public void Start()
    {
        Spawn();
        xAspect = Camera.main.aspect * 5f;
        cSpawn = Random.Range(xAspect, 10.93f - xAspect);
        Vector3 cameraPos = new Vector3(cSpawn, CameraA.transform.position.y, CameraA.transform.position.z);
        CameraA.transform.position = cameraPos;
        
    }
    public void Update()
    {
        yHeight = CameraA.transform.position.y;
        speed = speed + acceleration * Time.deltaTime;
        Vector3 speedUpCam = new Vector3(CameraA.transform.position.x, CameraA.transform.position.y + speed * Time.deltaTime, CameraA.transform.position.z);
        Vector2 speedUpBack = new Vector2(Background.transform.position.x, Background.transform.position.y + (speed - 0.1f) * Time.deltaTime);
        Vector2 speedUpCut = new Vector2(Background.transform.position.x, cutOff.transform.position.y + speed * Time.deltaTime);
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().gameOn == true)
        {
            CameraA.transform.position = speedUpCam;
            Background.transform.position = speedUpBack;
            cutOff.transform.position = speedUpCut;
        }
    }

    public void Spawn()
    {
        spawnTime = 6.67f / (speed + 1f);
        asteroidChance = Random.Range(0, 2);
        InvokeRepeating("SpawnCloud", spawnTime, 0f);
    }

    private void SpawnCloud()
    {
        ySpawn = CameraA.transform.position.y + 8f + Random.Range(-1f, 1.5f);
        Instantiate(Cloud, new Vector2(Random.Range(cSpawn - xAspect, cSpawn + xAspect) , ySpawn), Quaternion.identity);
        if (asteroidChance == 1)
        {
            SpawnAsteroid();
        }
        else
        {
            Spawn();
        }
    }

    void SpawnAsteroid()
    {
        if(yHeight >= 100f)
        {
            Instantiate(Asteroid, new Vector2(Random.Range(cSpawn - xAspect, cSpawn + xAspect), ySpawn + 10f), Quaternion.identity);
            Spawn();
        }
        else
        {
            Spawn();
        }  
    }
}
