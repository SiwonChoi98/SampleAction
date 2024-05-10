using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// UI 매니저 클래스
public class UIManager : MonoBehaviour
{
    public Text enemySpawnedText;

    public int enemyCount;
    private void Start()
    {
        // 적 생성 이벤트를 감지하여 UI를 업데이트
        EventManager.OnEnemySpawned += UpdateUI;
    }

    private void OnDestroy()
    {
        // 이벤트 해제
        EventManager.OnEnemySpawned -= UpdateUI;
    }

    // UI 업데이트 메서드
    private void UpdateUI()
    {
        enemyCount++;
        enemySpawnedText.text = "적이 생성되었습니다! count : " + enemyCount;
    }
}
