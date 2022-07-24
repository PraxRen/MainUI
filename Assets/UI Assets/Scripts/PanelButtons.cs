using System.Linq;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(GridLayoutGroup))]
public class PanelButtons : MonoBehaviour
{
    private System.Random random = new System.Random();
    public void ChangeOrderExitButton()
    {
        var buttons = gameObject.GetComponentsInChildren<ServiceButton>(true).ToList();
        var dictionaryButton = buttons.ToDictionary(button => buttons.IndexOf(button));
        var dictionaryButtonNoExit = dictionaryButton.Where(button => button.Value.IsExit == false);
        var keyValueButton = dictionaryButtonNoExit.ElementAt(random.Next(0, dictionaryButtonNoExit.Count()));
        var keyValueExitButton = dictionaryButton.FirstOrDefault(button => button.Value.IsExit == true);
        keyValueButton.Value.transform.SetSiblingIndex(keyValueExitButton.Key);
        keyValueExitButton.Value.transform.SetSiblingIndex(keyValueButton.Key);
    }
}