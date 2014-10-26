using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

    public GameObject UI_splash;
    public GameObject UI_menu;
    public GameObject UI_setting;
    public GameObject UI_about;
    public GameObject UI_help;


    IEnumerator Start()
    {
        UI_splash.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        ToMenu();
    }

   public void ToMenu() {
       Debug.Log("tomenu");
        UI_splash.SetActive(false);
        UI_menu.SetActive(true);
    }
   public void ToSetting() {
       UI_menu.SetActive(false);
       UI_setting.SetActive(true);
   }
   public void ToAbout()
   {
       UI_menu.SetActive(false);
       UI_about.SetActive(true);
   }
   public void ToHelp()
   {
       UI_menu.SetActive(false);
       UI_help.SetActive(true);
   }
   public void Exit() {
       Application.Quit();
   }
   public void Back() {
       UI_menu.SetActive(true);
       UI_setting.SetActive(false);
       UI_help.SetActive(false);
       UI_about.SetActive(false);

   }
}
