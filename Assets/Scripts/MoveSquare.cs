using UnityEngine;

public class MoveSquare : MonoBehaviour
{
  public float speed;
  void Update()
  {
    transform.Translate(new Vector3(0, 0, 1 * -speed * Time.deltaTime));
    if(transform.position.z < -20)
    {
      Destroy(this.gameObject);
      Debug.Log("Ojb Destroyed");
    }
  }

  
}
