using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class tanchuang : MonoBehaviour
{
    // Start is called before the first frame update
    
    public bool useClick = true; //�Ƿ�ʹ�õ��
    public bool useCollision = false; //�Ƿ�ʹ����ײ
    public bool goToNextScene = false; //�Ƿ������һ������
    public string nextSceneName = "Prototype2";//��һ������������
    public GameObject popup;// ������GameObject

    private void Update()
    {
        if(useClick&&Input.GetMouseButtonDown(0))//������������
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
            // ������������ײ�����룬��ͨ������OnCollisionEnter�Ⱥ����д���
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(useCollision&&collision.gameObject.CompareTag("Player"))//���������"Player"��ǩ
        {
            HandleInteraction();                                       
        }
    }
    private void HandleInteraction()
    {
        if(popup!=null)
        {
            popup.SetActive(true);//��ʾ����
        }
        if(goToNextScene)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("prototype2");
            //SceneManager.LoadScene(Prototype2);//������һ������
        }
    }
}

