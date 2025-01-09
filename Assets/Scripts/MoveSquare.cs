using UnityEngine;

public class MoveSquare : MonoBehaviour
{
  public float speed;
  private void Start()
  {
    //fazer um fade no elemento para aparece transgressal
  }
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


//Vector2 velocity = new Vector3(rig.velocity.x, movimentPos.y, rig.velocity.z);

//float clampedY = Mathf.Clamp(rig.velocity.y, -maxBound, maxBound);

//rig.velocity = new Vector3(rig.velocity.x, clampedY, rig.velocity.z);