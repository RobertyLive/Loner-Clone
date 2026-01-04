using UnityEngine;
using UnityEngine.UIElements;

public class RotationHelice : MonoBehaviour
{
  public float speedRotation;
  public GameObject helice;

  void Update()
  {
    helice.transform.Rotate(new Vector3(0, speedRotation * Time.deltaTime, 0));
  }
}
