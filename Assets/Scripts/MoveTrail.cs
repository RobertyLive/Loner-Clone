using UnityEngine;

public class MoveTrail : MonoBehaviour
{
  public float speed;
  void Update()
  {
    transform.Translate(Vector3.back * speed * Time.deltaTime);


    if (transform.position.z < -5)
    {
      Destroy(this.gameObject);
    }
  }
}
