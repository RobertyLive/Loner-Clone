using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DutchControler : MonoBehaviour
{
  public TextMeshProUGUI dutchText;
  public GameManager gameManagerDutch;

  private void Update()
  {
    dutchText.text = "Dutch: " + gameManagerDutch.camCM_2_gameplay.m_Lens.Dutch.ToString("F1");
  }
}
