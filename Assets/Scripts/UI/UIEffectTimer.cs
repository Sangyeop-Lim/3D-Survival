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

    //private void Start() // ���� ���� ��, �� ȿ�� UI�� ��� ��Ȱ��ȭ�ؼ� ȭ�鿡 ������ �ʵ��� ����
    //{
    //    speedEffectUI.SetActive(false);
    //    doubleJumpEffectUI.SetActive(false);
    //}

    //public void ShowSpeedEffect(float duration) // �ӵ� ���� ȿ�� UI�� �����ְ�, ���ӽð� ���� fill �̹����� ���� �پ��� �ִϸ��̼��� ����
    //{
    //    StartCoroutine(AnimateFill(speedEffectUI, speedEffectFill, duration)); // �ڷ�ƾ AnimateFill�� �����ؼ� fill �ִϸ��̼ǰ� UI Ȱ��ȭ
    //}

    //public void ShowDoubleJumpEffect(float duration) // ���� ���� ȿ�� UI�� ���� ���
    //{
    //    StartCoroutine(AnimateFill(doubleJumpEffectUI, doubleJumpEffectFill, duration));
    //}

    //private IEnumerator AnimateFill(GameObject uiObject, Image fillImage, float duration) // ���� UI fill �ִϸ��̼��� ����ϴ� �ڷ�ƾ
    //{                                                                                     // uiObject�� �ش� ȿ�� UI GameObject, fillImage�� UI�� �̹��� ������Ʈ, duration�� ���ӽð�
    //    uiObject.SetActive(true);     // UI ������Ʈ�� Ȱ��ȭ�ؼ� ȭ�鿡 ���̰� ��
    //    fillImage.fillAmount = 1f;    // fill �̹����� ó���� �� �� ���·� ����

    //    float timer = 0f;

    //    while (timer < duration) // duration ���� �ݺ��ϸ鼭 fillAmount�� �ٿ�����
    //    {
    //        timer += Time.deltaTime; // ��� �ð� ����
    //        fillImage.fillAmount = Mathf.Clamp01(1f - timer / duration); // ���� �ð� ������ �°� fill ����
    //        yield return null; // ���� �����ӱ��� ���
    //    }

    //    fillImage.fillAmount = 0f; // �ð��� ������ fill�� 0���� ����� UI�� �ٽ� ����
    //    uiObject.SetActive(false);
    //}
}
