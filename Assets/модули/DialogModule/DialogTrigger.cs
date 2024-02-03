using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
        gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        TriggerDialog();
    }
}
