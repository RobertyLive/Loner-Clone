
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

  //private bool isReset = true;
  [SerializeField] private Vector3 rotationToReset;


  public Quaternion rotacaoAtual;
  public float adjustRotate;


  [SerializeField]
  private float limiteRot;
  [SerializeField]
  private float limiteRotx;
  private void Update()
  {
    angleVelocity.x = Input.GetAxis("Vertical") * speed;
    angleVelocity.z = Input.GetAxis("Horizontal") * -speedRotate;
    movimentPos.y = Input.GetAxisRaw("Vertical");

    if (movimentPos.y != 0 || angleVelocity.z != 0)
      StopAllCoroutines();

    if (movimentPos.y == 0 || angleVelocity.z == 0)
      ResetRotate();



  }
  private void FixedUpdate()
  {
    Quaternion deltaRotation = Quaternion.Euler(angleVelocity * Time.fixedDeltaTime);
    //rig.MoveRotation(rig.rotation * deltaRotation);

    Quaternion newRotation = rig.rotation * deltaRotation;

    Vector3 angles = newRotation.eulerAngles;

    angles.x = NormalizeAngle(angles.x);
    angles.y = NormalizeAngle(angles.y);
    angles.z = NormalizeAngle(angles.z);

    angles.x = Mathf.Clamp(angles.x, -limiteRot, limiteRot);
    angles.y = Mathf.Clamp(angles.y, -5, 5);
    //angles.z = Mathf.Clamp(angles.x, -5, 5);

    newRotation = Quaternion.Euler(angles);

    rig.MoveRotation(newRotation);

    //restringindo a rotacao
    //float rotacaoX = deltaRotation.eulerAngles.x;
    //if (rotacaoX > 180)
    //{
    //  rotacaoX -= 360;
    //}
    //rotacaoX = Mathf.Clamp(rotacaoX, -limiteRot, limiteRot);
    //transform.eulerAngles = new Vector3(rotacaoX, transform.eulerAngles.y, transform.eulerAngles.z);


    //rig.velocity = new Vector3(rig.velocity.x, movimentPos.y * -speedMove, rig.velocity.z);
    transform.position += new Vector3(0, -movimentPos.y * Time.deltaTime * speedMove, 0);        
    float novaPosicaoY = Mathf.Clamp(transform.position.y, -limiteRotx, limiteRotx);
    transform.position = new Vector3(transform.position.x, novaPosicaoY, transform.position.z);


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

    //x
    if (rotation.x > 0)
    {
      for (int i = 0; i < rotation.x; rotation.x -= adjustRotate)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }

    }
    else
    {
      for (int i = 0; i > rotation.x; rotation.x += adjustRotate)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }
    }
    //eixo y

    if (rotation.y > 0)
    {
      for (int i = 0; i < rotation.y; rotation.y -= adjustRotate)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }

    }
    else
    {
      for (int i = 0; i > rotation.y; rotation.y += adjustRotate)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }
    }


    //eixo z
    if (rotation.z > 0)
    {
      for (int i = 0; i < rotation.z; rotation.z -= adjustRotate)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }

    }
    else
    {
      for (int i = 0; i > rotation.z; rotation.z += adjustRotate)
      {
        transform.rotation = Quaternion.Euler(new Vector3(rotation.x, rotation.y, rotation.z));
        yield return new WaitForSeconds(.01f);
      }
    }

    



    //EIXO X
    

    transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

  }

  private void ResetRotate()
  {
    StartCoroutine(ForceReset());
  }



}
