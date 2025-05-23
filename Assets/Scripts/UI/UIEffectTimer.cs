using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEffectTimer : MonoBehaviour
{
    //[Header("UI Parents")]
    //public GameObject speedEffectUI;
    //public GameObject doubleJumpEffectUI;

    //[Header("UI Fills")]
    //public Image speedEffectFill;
    //public Image doubleJumpEffectFill;

    //private void Start() // 게임 시작 시, 두 효과 UI를 모두 비활성화해서 화면에 보이지 않도록 설정
    //{
    //    speedEffectUI.SetActive(false);
    //    doubleJumpEffectUI.SetActive(false);
    //}

    //public void ShowSpeedEffect(float duration) // 속도 증가 효과 UI를 보여주고, 지속시간 동안 fill 이미지가 점점 줄어드는 애니메이션을 실행
    //{
    //    StartCoroutine(AnimateFill(speedEffectUI, speedEffectFill, duration)); // 코루틴 AnimateFill을 실행해서 fill 애니메이션과 UI 활성화
    //}

    //public void ShowDoubleJumpEffect(float duration) // 더블 점프 효과 UI도 같은 방식
    //{
    //    StartCoroutine(AnimateFill(doubleJumpEffectUI, doubleJumpEffectFill, duration));
    //}

    //private IEnumerator AnimateFill(GameObject uiObject, Image fillImage, float duration) // 실제 UI fill 애니메이션을 담당하는 코루틴
    //{                                                                                     // uiObject는 해당 효과 UI GameObject, fillImage는 UI의 이미지 컴포넌트, duration은 지속시간
    //    uiObject.SetActive(true);     // UI 오브젝트를 활성화해서 화면에 보이게 함
    //    fillImage.fillAmount = 1f;    // fill 이미지를 처음엔 꽉 찬 상태로 설정

    //    float timer = 0f;

    //    while (timer < duration) // duration 동안 반복하면서 fillAmount를 줄여나감
    //    {
    //        timer += Time.deltaTime; // 경과 시간 누적
    //        fillImage.fillAmount = Mathf.Clamp01(1f - timer / duration); // 남은 시간 비율에 맞게 fill 조절
    //        yield return null; // 다음 프레임까지 대기
    //    }

    //    fillImage.fillAmount = 0f; // 시간이 끝나면 fill을 0으로 만들고 UI를 다시 숨김
    //    uiObject.SetActive(false);
    //}
}
