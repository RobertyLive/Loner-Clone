
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  Vector3 angleVelocity;
  public Rigidbody rig;
  public float speed;
  public float speedRotate;

  Vector3 movimentPos;
  public float speedMove;

  private bool isReset = true;
  [SerializeField] private Vector3 rotationToReset;


  public Quaternion rotacaoAtual;

  private void Update()
  {
    angleVelocity.x = Input.GetAxis("Vertical") * speed;
    angleVelocity.z = Input.GetAxis("Horizontal") * -speedRotate;
    movimentPos.y = Input.GetAxisRaw("Vertical");

    if (movimentPos.y != 0 || angleVelocity.z != 0)
      StopAllCoroutines();

    rotacaoAtual = transform.rotation;
    rotationToReset = rotacaoAtual.eulerAngles;


    if (Input.GetKeyDown(KeyCode.Space))
    {
      ResetRotate();
    }

  }
  private void FixedUpdate()
  {
    Quaternion deltaRotation = Quaternion.Euler(angleVelocity * Time.fixedDeltaTime);
    rig.MoveRotation(rig.rotation * deltaRotation);

    rig.velocity = new Vector3(rig.velocity.x, movimentPos.y * -speedMove, rig.velocity.z);


  }
  private float NormalizeAngle(float angle)
  {
    if (angle > 180f)
      angle -= 360f;
    return angle;
  }
  IEnumerator ForceReset()
  {
    yield return new WaitForSeconds(.3f);

    Vector3 rotation = transform.eulerAngles;
    
    rotation.x = NormalizeAngle(rotation.x);
    rotation.y = NormalizeAngle(rotation.y);
    rotation.z = NormalizeAngle(rotation.z);

    //eixo z
    if (rotation.z > 0)
    {
      for (int i = 0; i < rotation.z; rotation.z -= .01f)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }

    }
    else
    {
      for (int i = 0; i > rotation.z; rotation.z += .01f)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }
    }

    //eixo y

    if (rotation.y > 0)
    {
      for (int i = 0; i < rotation.y; rotation.y -= .01f)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }

    }
    else
    {
      for (int i = 0; i > rotation.y; rotation.y += .01f)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }
    }



    //EIXO X
    if (rotation.x > 0)
    {
      for (int i = 0; i < rotation.x; rotation.x -= .01f)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }

    }
    else
    {
      for (int i = 0; i > rotation.x; rotation.x += .01f)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }
    }

    transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

  }

  private void ResetRotate()
  {
    StartCoroutine(ForceReset());
  }
}
