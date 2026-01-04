using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{

  public bool starting;
  public float left, right;
  public float valueLeftInGameX, valueRightInGameY;
  public Animator CanvaAnimatorControler;
  public GameObject contador;
  public PlayerController player;

  public CinemachineVirtualCamera camCM_initial;
  public CinemachineVirtualCamera camCM_2_gameplay;
  public CinemachineVirtualCamera camCM_3_menuGame;
  


  [Header("Menu")]
  public bool activeMenu = false;
  public Material material;
  public Animator animText;
  public GameObject menu;
  public bool canOFFmenu = false;
  public Animator settings;


  private void Awake()
  {
    DontDestroyOnLoad(this);
    menu.SetActive(false);
  }

  private void Update()
  {
    //Debug.Log(menu.activeSelf);
    Menu();

    if (canOFFmenu && Input.GetKeyDown(KeyCode.Escape)) HideMenu();

    if (Input.GetKey(KeyCode.A) && starting)
    {
      
      camCM_2_gameplay.m_Lens.Dutch += .3f;
    }else if (Input.GetKey(KeyCode.D) && starting)
    {
      
      camCM_2_gameplay.m_Lens.Dutch -= .3f;
    }



    if (starting) return;

    if (Input.GetKeyDown(KeyCode.Space))
    {
      canOFFmenu = false;
      starting = true;
      CanvaAnimatorControler.SetTrigger("starting");
      PressSpace();
    }
  }



  public void PressSpace()
  {
    //iniciar o game...
    //Debug.Log("Iniciando o game");
    camCM_2_gameplay.m_Lens.Dutch = 0;
    player.enabled = true;
    camCM_initial.enabled = false;
    Invoke(nameof(ActiveContador), 4f);
  }

  public void ActiveContador()
  {
    contador.SetActive(true);
  }


  private void RotateWithDucth()
  {
    if (Input.GetKeyDown(KeyCode.A))
    {
      camCM_initial.m_Lens.Dutch = -10f;
    }
  }


  private void Menu()
  {
    if (Input.GetKeyDown(KeyCode.Escape))
    {
      if (activeMenu || !starting) return;

      activeMenu = true;
      player.enabled = false;
      
      StartCoroutine(VisiblePainel());

    }
  }

  IEnumerator VisiblePainel()
  {
    //DESABITLITAR AS PAREDES
    camCM_2_gameplay.enabled = false;
    menu.SetActive(true);
    for(float i = 0; i < 1; i += 0.025f)
    {
      yield return new WaitForSeconds(.001f);
      material.color = new Color(.3f,.2f,.4f,i);
    }

    yield return new WaitForSeconds(.5f);
    animText.SetTrigger("ShowCanva");

    yield return new WaitForSeconds(2f);
    settings.SetTrigger("options");
    yield return new WaitForSeconds(3f);
    canOFFmenu = true;

    //start corrotina para ativar o menuSecundario;
  }

  void HideMenu()
  {
    if (!canOFFmenu) return;

    if (menu.activeSelf)
    {
      camCM_2_gameplay.enabled = true;
      canOFFmenu = false;
      activeMenu = false;
    }

    player.enabled = true;
    Invoke("Desligar", 2f);
    StartCoroutine(InviblePainel());
    Debug.Log("MENU DESATIVADO");
  }

  void Desligar()
  {
    settings.SetBool("reset", true);
  }

  public void ActiveMenu()
  {
    menu.SetActive(false);

  }
  
  IEnumerator InviblePainel()
  {
    for (float i = 1; i > 0; i -= 0.025f)
    {
      yield return new WaitForSeconds(.001f);
      material.color = new Color(.3f, .2f, .4f, i);
    }

    ActiveMenu();
    Debug.Log("PAINEL DESATIVADO");
  }

  //DESABILITAR MENU
}
