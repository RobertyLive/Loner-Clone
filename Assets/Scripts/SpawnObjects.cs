using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class SpawnObjects : MonoBehaviour
{
  public float timerate = .2f;
  public float timeToInstantiar = 1;
  public GameObject[] objets;

  private void Start()
  {
    InvokeRepeating("GerarObjects", timeToInstantiar, timerate);
  }

  void GerarObjects()
  {
    //int x = Random.Range(-10, 11);
    //int y = Random.Range(-10, 11);

    Instantiate(objets[Random.Range(0, objets.Length)], transform.position, Quaternion.identity);
  }
}
