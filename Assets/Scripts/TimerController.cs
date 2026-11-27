using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour {

    [SerializeField]
    private float m_TimeLeft = 10f;

    [SerializeField]
    private TextMeshProUGUI m_Text;

    private bool m_IsRunning = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (m_IsRunning) {
            m_TimeLeft -= Time.deltaTime;
            m_Text.text = Mathf.Round(m_TimeLeft).ToString();

            if (m_TimeLeft < 0) {
                m_TimeLeft = 0;
                m_IsRunning = false;
                m_Text.text = "Terminé !";
                m_Text.color = Color.red;
            }
        }
    }

    public void StartTimer() {
        m_IsRunning = true;
    }
}
