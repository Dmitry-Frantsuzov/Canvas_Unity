using UnityEngine;
using UnityEngine.UI;

public class ButtonSettings : MonoBehaviour
{
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Transform _settingsPanel;

    // Start is called before the first frame update
    void Start()
    {
        _settingsButton.onClick.AddListener(SettingsClick);
    }


    private void SettingsClick()
    {
        MessageBox.Instante.gameObject.SetActive(true);
        MessageBox.Instante.SetText("�� ����� �����");
    }

    private void OnDisable()
    {
        //� ������ �������� ������� ����� ���������� ��� ������
        _settingsButton.onClick.RemoveAllListeners();
    }

}
