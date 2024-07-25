using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.InputSystem;

public class CommandingUnitsInput : MonoBehaviour
{
    private StarterAssets.StarterAssets _controls;
    private InputAction _commandInput;
    [SerializeField] private UnitReferenceContainer _unitContainer;

    private void Awake()
    {
        _controls = new StarterAssets.StarterAssets();
        _controls.Enable();
        SetPlayer();
    }

    private void OnCommandForward(InputAction.CallbackContext context)
    {
        Debug.Log("GO!");
        _unitContainer.ListOfUnits.GetRandomUnit().GetComponent<BehaviourToPlayer>().GoForward();
    }
    private void OnEnable()
    {
        ConnectActions();
    }
    private void OnDisable()
    {
        DisconnectActions();
    }
    public void ConnectActions()
    {
        if (_commandInput != null)
            _commandInput.performed += OnCommandForward;
    }

    public void DisconnectActions()
    {
        if (_commandInput != null)
            _commandInput.performed -= OnCommandForward;
    }
    public void DisableControls()
    {
        _controls.Disable();
    }
    public void EnableControls()
    {
        _controls.Enable();
    }
    public void SetPlayer()
    {
        DisconnectActions();
        _commandInput = _controls.Units.ForwardSingle;
        ConnectActions();
    }
}
