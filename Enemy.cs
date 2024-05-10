using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 적 클래스
public class Enemy : MonoBehaviour
{
    private void Start()
    {
        // 적이 생성되었을 때 이벤트 매니저에 등록
        EventManager.OnEnemySpawned += EnemySpawnHandler;
        //적이 생성 되었을 때 호출 시 
        //Debug.Log("적이 생성되었습니다.");
        //UpdateUI();
        //EnemySpawnHandler();
        //이러한 방식대로 실행 될것이다.
        EventManager.SpawnEnemy();
    }

    private void OnDestroy()
    {
        // 적이 파괴될 때 이벤트 매니저에서 등록 해제
        EventManager.OnEnemySpawned -= EnemySpawnHandler;
    }

    // 적 생성 이벤트 핸들러
    private void EnemySpawnHandler()
    {
        Debug.Log("적 생성 이벤트를 받았습니다.");
        // 여기에 적 객체가 받을 동작을 구현합니다.
    }
}