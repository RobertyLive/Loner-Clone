<<<<<<< HEAD
so causes self-z-fighting on xbox 360, regardless of any ISOLATE usage
	FMaterialVertexParameters VertexParameters = GetMaterialVertexParameters(Input, VFIntermediates, WorldPos.xyz, float3x3(float3(0,0,0),float3(0,0,0),float3(0,0,0)));
#else
	float3x3 TangentBasis = VertexFactoryGetTangentBasis(Input, VFIntermediates);
	FMaterialVertexParameters VertexParameters = GetMaterialVertexParameters(Input, VFIntermediates, WorldPos.xyz, TangentBasis);
#endif
	// Isolate instructions used for world position offset on xbox 360, 
	// As these cause the optimizer to generate different position calcu
=======
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
>>>>>>> 0a4af3f404ac9ab9e0b083c4a219a4d93d01bc02
