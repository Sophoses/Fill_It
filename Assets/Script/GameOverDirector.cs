using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverDirector : MonoBehaviour // 게임 오버 씬에서 점수 출력
{
    public Text sc;
    // Start is called before the first frame update
    void Start()
    {
        sc.text = myScore.storedScore.ToString();
    }
}
