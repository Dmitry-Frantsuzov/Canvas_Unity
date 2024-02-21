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
        MessageBox.Instante.SetText("Вы ввели текст");
    }

    private void OnDisable()
    {
        //в момент закрытия обьекта после выполнения его работы
        _settingsButton.onClick.RemoveAllListeners();
    }

}
