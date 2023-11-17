using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using RPG;

namespace RPG.Control
{
    public class PlayerController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                //MoveToCursor();
            }
        }
    }
    /*private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            MoveTo(hit.point);
        }
    }*/
}