using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 이벤트 매니저 클래스
public class EventManager : MonoBehaviour
{
    // 적 생성 이벤트를 정의하는 대리자
    //public delegate void EnemySpawnedDelegate();
    // 적 생성 이벤트를 선언
    public static Action OnEnemySpawned;
    
    // 적 생성 이벤트를 발생시키는 메서드
    public static void SpawnEnemy()
    {
        Debug.Log("적이 생성되었습니다.");
        // 적 생성 이벤트 발생
        OnEnemySpawned?.Invoke();
    }
    
    
    
}