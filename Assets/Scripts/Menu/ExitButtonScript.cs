using TMPro;
using UnityEngine;

public class ExitButtonScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textQuiting;
    [SerializeField] private KeyCode keyEscape = KeyCode.Escape;
    public float holdTime = 3.5f;
    private float holdTimer = 0f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            holdTimer += Time.deltaTime;
            if (holdTimer <= 0.5f) textQuiting.text = "Quitting.";
            else if (holdTimer >= 0.5f && holdTimer <= 1f) textQuiting.text = "Quitting..";
            else if (holdTimer >= 1f && holdTimer <= 1.5f) textQuiting.text = "Quitting...";
            if (holdTimer >= holdTime)
            {
                Exit();
                holdTimer = 0f;
            }
        }
        else
        {
            textQuiting.text = "Esc - Quit";
            holdTimer = 0f;
        }
    }

    private void Exit()
    {
        Application.Quit();
    }

    public void ChangeExitKey(KeyCode key)
    {
        keyEscape = key;
    }
}
