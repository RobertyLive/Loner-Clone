using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TimeTravel : MonoBehaviour
{
  public float time = 0.2f;
  public TextMeshProUGUI text;

  private void Start()
  {
    Cronometro();
    InvokeRepeating("Cronometro", 1, Random.Range(3f, 8f));
  }


  void Cronometro()
  {
    text.text = time.ToString("F1", System.Globalization.CultureInfo.InvariantCulture) +" " + "KM";//contador.ToString();
    time += Random.Range(.1f, .5f);
  }

}
