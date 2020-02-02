using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComponentHandler : MonoBehaviour
{



    private float engineState = 100.0f;
    private float radarState = 100.0f;
    private float gunState = 100.0f;
    private float coreState = 100.0f;

    private bool brokenEngine = false;
    private bool brokenRadar = false;
    private bool brokenGun = false;
    private bool brokenCore = false;
    public int currentComponent = 0; //1 Engine, 2 Radar, 3 Gun, 4 Core
    public bool repairing = false;
    public float repairAmount = 25f;

    public GameObject topflame;
    public GameObject botflame;
    public GameObject rightflame;
    public GameObject leftflame;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(repairing)
        {
            healComponent(repairAmount * Time.time);
        }
    }

    public void breakComponent()
    {
        if(!brokenEngine)
        {
            brokenEngine = true;
            engineState = 0.0f;
            topflame.SetActive(true);
            Debug.Log("BROKE ENGINE");
        }
        else if (!brokenRadar)
        {
            brokenRadar = true;
            radarState = 0.0f;
            rightflame.SetActive(true);
            Debug.Log("BROKE RADARS");
        }
        else if(!brokenGun)
        {
            brokenGun = true;
            gunState = 0.0f;
            botflame.SetActive(true);
            Debug.Log("BROKE GUN");
        }
        else if(!brokenCore)
        {
            brokenCore = true;
            coreState = 0.0f;
            leftflame.SetActive(true);
            Debug.Log("BROKE cORE");
        }
        else
        {
            SceneManager.LoadScene("MainMenu" , LoadSceneMode.Single);
        }
    }

    public void healComponent(float t_fix)
    {
        if(currentComponent != 0)
        {
            if (currentComponent == 1 && brokenEngine)
            {
                engineState += t_fix;
                if(engineState >= 100.0f)
                {
                    brokenEngine = false;
                    engineState = 100.0f;
                    topflame.SetActive(false);
                    Debug.Log("Repaird Engine");
                }
            }
            else if (currentComponent == 2 && brokenRadar)
            {
                radarState += t_fix;
                if (radarState >= 100.0f)
                {
                    brokenRadar = false;
                    radarState = 100.0f;
                    rightflame.SetActive(false);
                    Debug.Log("Repaird Radar");
                }
            }
            else if (currentComponent == 3 && brokenGun)
            {
                gunState += t_fix;
                if (gunState >= 100.0f)
                {
                    brokenGun = false;
                    gunState = 100.0f;
                    botflame.SetActive(false);
                    Debug.Log("Repaird Gun");
                }
            }
            else if (currentComponent == 4 && brokenCore)
            {
                coreState += t_fix;
                if (coreState >= 100.0f)
                {
                    brokenCore = false;
                    coreState = 100.0f;
                    leftflame.SetActive(false);
                    Debug.Log("Repaird Core");
                }
            }
        }

    }
    public void setCurrentComponent(int t_int)
    {
        currentComponent = t_int;
    }


}
