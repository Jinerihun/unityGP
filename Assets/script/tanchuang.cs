using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class tanchuang : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool useClick = true; //是否使用点击
    public bool useCollision = false; //是否使用碰撞
    public bool goToNextScene = false; //是否进入下一个场景
    public string nextSceneName = "Prototype2";//下一个场景的名称
    public GameObject popup;// 弹窗的GameObject

    private void Update()
    {
        if(useClick&&Input.GetMouseButtonDown(0))//检测鼠标左键点击
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if(Physics.Raycast(ray,out hit))
            {
                if(hit.collider.gameObject==this.gameObject)
                {
                    HandleInteraction();
                }
            }
        }
        if(useCollision)
        {
            // 这里可以添加碰撞检测代码，但通常会在OnCollisionEnter等函数中处理
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(useCollision&&collision.gameObject.CompareTag("Player"))//假设玩家有"Player"标签
        {
            HandleInteraction();                                       
        }
    }
    private void HandleInteraction()
    {
        if(popup!=null)
        {
            popup.SetActive(true);//显示弹窗
        }
        if(goToNextScene)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("prototype2");
            //SceneManager.LoadScene(Prototype2);//加载下一个场景
        }
    }
}

