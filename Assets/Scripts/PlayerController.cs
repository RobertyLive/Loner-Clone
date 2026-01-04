<<<<<<< HEAD
﻿; Adapter launcher registration for V3 debugger
[$RootKey$\CLSID\{21d902f4-d9da-4330-8ed3-05fa62305f4b}]
"Assembly"="Microsoft.VisualStudio.JavaScript.Diagnostics.JSDebugger"
"Class"="Microsoft.VisualStudio.WebClient.Diagnostics.AdapterLauncher"
"CodeBase"="$PackageFolder$\Microsoft.VisualStudio.JavaScript.Diagnostics.JSDebugger.dll"

; Custom Protocol Extension
[$RootKey$\CLSID\{D136063F-F239-4BFC-93CE-C0CF4C4BCFAC}]
"Assembly"="Microsoft.VisualStudio.JavaScript.Diagnostics.JSDebugger"
"Class"="Microsoft.VisualStudio.WebClient.Diagnostics.JavascriptDebuggersProtocolExtension"
"CodeBase"="$PackageFolder$\Microsoft.VisualStudio.JavaScript.Diagnostics.JSDebugger.dll"

[$RootKey$\AD7Metrics\PortSupplier\{61D1E397-7AA6-4ED9-815A-0C5CA0E728B4}]
"Name"="Chrome devtools protocol websocket (V3)"
"CLSID"="{0C142B5E-FE7D-4C6B-8193-71AF0D3A810C}"

; ------- AD7 Debug Port Provider registration (for attach scenarios) ---------
[$RootKey$\CLSID\{0C142B5E-FE7D-4C6B-8193-71AF0D3A810C}]
"Assembly"="Microsoft.VisualStudio.JavaScript.Diagnostics.JSDebugger"
"Class"="Microsoft.VisualStudio.WebClient.WKDebug.Engine.AD7.AD7DebugPortSupplier"
"InprocServer32"="$WinDir$\SYSTEM32\MSCOREE.DLL"
"CodeBase"="$PackageFolder$\Microsoft.VisualStudio.JavaScript.Diagnostics.JSDebugger.dll"
"ThreadingModel"="Free"

; ------------------Program Provider Registration--------------------
[$RootKey$\CLSID\{A303A8ED-17D9-496D-8983-D3E35D9CA62C}]
"Assembly"="Microsoft.VisualStudio.JavaScript.Diagnostics.JSDebugger"
"Class"="Microsoft.VisualStudio.JavaScript.Diagnostics.AD7.AD7JSTSProgramProvider"
"InprocServer32"="$WinDir$\SYSTEM32\MSCOREE.DLL"
"CodeBase"="$PackageFolder$\Microsoft.VisualStudio.JavaScript.Diagnostics.JSDebugger.dll"
"ThreadingModel"="Free"

; -------ASP.Net Framework, ASP.Net Core, and Websites Registration-------
; Engine registration for launching ASP.NET project
[$RootKey$\AD7Metrics\Engine\{394120B6-2FF9-4D0D-8953-913EF5CD0BCD}]
"CLSID"="{DAB324E9-7B35-454C-ACA8-F6BB0D5C8673}"
"AlwaysLoadLocal"=dword:00000001
"Attach"=dword:00000001
"AddressBP"=dword:00000000
"AutoSelectPriority"=dword:00000004
"CallstackBP"=dword:00000000
"ConditionalBP"=dword:00000001
"Exceptions"=dword:00000001
"ExceptionBreakpointCategory"="{1ce4d9f7-faac-42ee-b352-87fdfb6fb37b}"
"Name"="JavaScript and TypeScript"
"AdapterTelemetryEventsNamespace"="vs/bpt/diagnostics/v3debugadapter/"
"AdapterTelemetryPropertiesNamespace"="VS.BPT.Diagnostics.DebugAdapter."
"LocalsScopeName"="Local"
"AdapterLauncher"="{21d902f4-d9da-4330-8ed3-05fa62305f4b}"
"CustomProtocolExtension"="{D136063F-F239-4BFC-93CE-C0CF4C4BCFAC}"
"PortSupplier"="{61D1E397-7AA6-4ED9-815A-0C5CA0E728B4}"
"DebugEngineType"="javascript"

; Set to "1" if the debug adapter should be used to launch the target process in non-debugging scenarios such as
;  Ctrl-F5 by setting the "noDebug" field to "true" in the launch configuration.  If this value is not set to "1",
;  the project system in VS must launch the process itself or call IVsDebugger4.LaunchDebugTargets4 with a
;  VsDebugTargetInfo4 where "bstrExe" must contain a valid path to an executable and "LaunchFlags" must include
;  the "DBGLAUNCH_NoDebug" flag.
"UseEngineForNonDebugLaunch"=dword:00000001

@="VSCode Debugger Host"

; Map exceptions codes so they'll work on locales other than US - For launch debugger
[$RootKey$\AD7Metrics\Engine\{394120B6-2FF9-4D0D-8953-913EF5CD0BCD}\ExceptionBreakpointMappings]
"All Exceptions"="all"
"Uncaught Exceptions"="uncaught"

; Custom expressions to support hit count breakpoints
; These should be removed when this bug fix is ported to debug adapters inside VS:
; https://github.com/Microsoft/vscode-chrome-debug-core/issues/291
[$RootKey$\AD7Metrics\Engine\{394120B6-2FF9-4D0D-8953-913EF5CD0BCD}\HitCountBreakpointExpressions]
"Equal"="= {0}"
"EqualOrGreater"=">= {0}"
"Mod"="% {0}"

; Register launching Chrome/PineZorro as supporting JavaScript debugging with VS debugger
[$RootKey$\Debugger\JavaScript Engines\{394120B6-2FF9-4D0D-8953-913EF5CD0BCD}]

; -------Debug attach and program provider-------
;Debugger engine for providing a program provider for msedge and chrome
[$RootKey$\AD7Metrics\Engine\{3FBCC828-6272-46D4-B5FA-B7E643672113}]
"CLSID"="{DAB324E9-7B35-454C-ACA8-F6BB0D5C8673}"
"AlwaysLoadLocal"=dword:00000001
"Attach"=dword:00000001
"AddressBP"=dword:00000000
"AutoSelectPriority"=dword:00000004
"CallstackBP"=dword:00000000
"Cond
=======

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
>>>>>>> 0a4af3f404ac9ab9e0b083c4a219a4d93d01bc02
