using UnityEngine;
using System.Collections;

public class GuiManager : MonoBehaviour
{

    public GuiTab[] Tabs;



    public void ToggleActiveByName(string _name, bool state)
    {
        for (int i = 0; i < Tabs.Length; i++)
        {
            if (Tabs[i].name == _name)
            {
                Tabs[i].GuiItems.SetActive(state);
                break;
            }
            
        }
    }

    public void ToggleActiveByID(int _ID, bool state)
    {
        for (int i = 0; i < Tabs.Length; i++)
        {
            if (Tabs[i].ID == _ID)
            {
                Tabs[i].GuiItems.SetActive(state);
                break;
            }
        }
    }

    void Awake()
    {
        for (int i = 0; i < Tabs.Length; i++)
        {
            Tabs[i].GuiItems.gameObject.SetActive(Tabs[i].DefaultState);
        }
    }


    [System.Serializable]
    public struct GuiTab
    {

        public GameObject GuiItems;
        public string name;
        public int ID;
        public bool DefaultState;
    }

}
