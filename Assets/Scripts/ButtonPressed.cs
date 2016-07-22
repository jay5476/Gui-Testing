using UnityEngine;
using System.Collections;

public class ButtonPressed : MonoBehaviour {

    public GuiManager Manager;

    public void ViewHud()
    {
        Manager.ToggleActiveByID(0, true);
    }
}
