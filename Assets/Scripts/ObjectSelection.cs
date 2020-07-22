using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    private Transform _selection;
    [SerializeField] private string selectableTag = "EnvPiece";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (_selection != null)
            {
                var selectionRenderer = _selection.GetComponent<Renderer>();
                HideOutline(_selection);
                _selection = null;
            }

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.CompareTag(selectableTag))
                {
                    var selectionComponent = hit.transform.gameObject;
                    var selectionRenderer = selection.GetComponent<Renderer>();
                    if (selectionRenderer != null)
                    {
                        ShowOutline(selection);
                        Debug.Log("Hit something");

                    }

                    _selection = selection;
                }

            }

        }
    }

    public void ShowOutline(Transform selection)
    {
        selection.GetComponent<MeshRenderer>().material.SetFloat("_Outline",0.033f);
        selection.GetComponent<Selected>().isSelected = true;
    }
    public void HideOutline(Transform selection)
    {
        selection.GetComponent<MeshRenderer>().material.SetFloat("_Outline",0f);
        selection.GetComponent<Selected>().isSelected = false;
    }
        
}
