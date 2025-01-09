using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwTrilas : MonoBehaviour
{
  public GameObject trails;
  private void Start()
  {
    InvokeRepeating("GerarTrails", 1f, .2f);
  }

  void GerarTrails()
  {
    int x = Random.Range(-20, 21);
    int y = Random.Range(-20, 21);

    Instantiate(trails, new Vector3(x, y, 100f), Quaternion.identity);
  }
}
