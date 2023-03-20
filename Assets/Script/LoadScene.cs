using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour //�� �̵� ��ũ��Ʈ
{
    [SerializeField]
    string sceneName;
    public AudioSource aud;
    public AudioClip clickS;
    public void Start()
    {
        this.aud = GetComponent<AudioSource>();

    }
    public void Load()//�� �̵�
    {
        this.aud.PlayOneShot(this.clickS);
        if (sceneName == "rHome")
        {
            biggerAnimation.combo = 0;
        }

        SceneManager.LoadScene(sceneName);
    }
}