using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScenes : MonoBehaviour
{
    public GameObject Menu;
    public GameObject RestorauntMain;
    public GameObject FastFoodMenu;

    void Start()
    {
        //Menu.SetActive(true);
        ////RestorauntMain.SetActive(false);
        ////FastFoodMenu.SetActive(false);
    }
    public void LoadRestorauntMain()
    {
        Menu.SetActive(false);
        RestorauntMain.SetActive(true);
        //FastFoodMenu.SetActive(false);
    }
    public void BackMenu()
    {
        Menu.SetActive(true);
        RestorauntMain.SetActive(false);
        //FastFoodMenu.SetActive(false);
    }
    public void BackRestorauntMain()
    {
        //Menu.SetActive(false);
        RestorauntMain.SetActive(true);
        FastFoodMenu.SetActive(false);
    }
    public void LoadFastFoodMenu()
    {
        RestorauntMain.SetActive(false);
        //Menu.SetActive(false);
        FastFoodMenu.SetActive(true);
    }
}
