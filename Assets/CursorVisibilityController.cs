using UnityEngine;

public class CursorVisibilityController : MonoBehaviour
{
    private bool isCursorVisible = false;

    private void Start()
    {
        // Hide the cursor initially
        HideCursor();
    }

    private void Update()
    {
        // Check if the mouse is over the UI element
        bool isMouseOverUI = IsMouseOverUIElement();

        // Toggle cursor visibility based on whether the mouse is over the UI element
        if (isMouseOverUI && !isCursorVisible)
        {
            ShowCursor();
        }
        else if (!isMouseOverUI && isCursorVisible)
        {
            HideCursor();
        }
    }

    private bool IsMouseOverUIElement()
    {
        // Raycast to check if the mouse is over any UI element
        return UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject();
    }

    private void ShowCursor()
    {
        Cursor.visible = true;
        isCursorVisible = true;
    }

    private void HideCursor()
    {
        Cursor.visible = false;
        isCursorVisible = false;
    }
}
