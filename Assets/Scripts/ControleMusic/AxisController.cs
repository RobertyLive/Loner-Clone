using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AxisController : MonoBehaviour
{
  public PlayerController playerAxis;
  public TextMeshProUGUI textHorizontal;
  public TextMeshProUGUI textVertical;


  public void SetAxisHorizontal(float volume)
  {
    playerAxis.speedRotate = volume;
    textHorizontal.text = "Horizontal axis - "+ volume.ToString("F2");
  }

  public void SetAxisVertical(float volume)
  {
    playerAxis.speedMove = volume;
    textVertical.text = "Vertical axis - "+ volume.ToString("F2");
  }
}
