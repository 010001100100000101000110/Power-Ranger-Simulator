using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OnClickMain()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void OnClickPic1()
    {
        SceneManager.LoadScene("1stTalkScene");
    }

    public void OnClickPic2()
    {
        SceneManager.LoadScene("2ndTalkScene");
    }

    public void OnClickPic3()
    {
        SceneManager.LoadScene("3rdTalkScene");
    }
    public void OnClickPhoneRing()
    {
        SceneManager.LoadScene("PhoneRing");
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("StartScene");
    }

}
