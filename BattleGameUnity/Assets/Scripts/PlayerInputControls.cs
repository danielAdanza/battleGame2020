// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputControls"",
    ""maps"": [
        {
            ""name"": ""controlersP1"",
            ""id"": ""43e1e3e7-ea6f-4eda-a111-2a30301b8448"",
            ""actions"": [
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""efd0f8ce-33fc-4f5a-9590-5bea2b6e029d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Backwards"",
                    ""type"": ""Button"",
                    ""id"": ""e61f4047-a81b-4624-b492-8658336ff28f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""60792946-a91f-4d11-86c9-60680a8dbdde"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""43e3371a-a0a1-4ab1-9a52-753d7dc3140a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3bc20875-a986-4dd6-add1-905df51014bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""e8899f4b-c172-4999-9495-a4abb3d94a04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""distantAttack"",
                    ""type"": ""Button"",
                    ""id"": ""9beebc0e-78fa-428a-a7d4-6ec8dcbc6fe3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""2838ff68-9fba-4546-8e36-c2983d042c8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Parry"",
                    ""type"": ""Button"",
                    ""id"": ""a4469ee2-5db1-4eb7-81e0-21bc30cffd85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3866ce40-c2d1-46b5-8a01-01f6045b5587"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc71ee2d-542f-4b6c-9c0b-ab0df4b71c59"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Backwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""102602d1-0c3e-42b4-9a06-f00b79816025"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc8802b0-1b0a-4252-a09f-dfa15e5bc832"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6da60c6-6a4c-41c6-b722-a7b47ecabc6f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8104b002-5ff9-4cec-8eba-e007775a7a65"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3142a3d-a613-47e7-934d-1ed2c674b428"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""distantAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b536d2c-6791-43bc-bbcd-4cdafb974ba3"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a4f8c7e-dd7d-490f-9219-c72af330aecd"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // controlersP1
        m_controlersP1 = asset.FindActionMap("controlersP1", throwIfNotFound: true);
        m_controlersP1_Forward = m_controlersP1.FindAction("Forward", throwIfNotFound: true);
        m_controlersP1_Backwards = m_controlersP1.FindAction("Backwards", throwIfNotFound: true);
        m_controlersP1_Right = m_controlersP1.FindAction("Right", throwIfNotFound: true);
        m_controlersP1_Left = m_controlersP1.FindAction("Left", throwIfNotFound: true);
        m_controlersP1_Jump = m_controlersP1.FindAction("Jump", throwIfNotFound: true);
        m_controlersP1_Melee = m_controlersP1.FindAction("Melee", throwIfNotFound: true);
        m_controlersP1_distantAttack = m_controlersP1.FindAction("distantAttack", throwIfNotFound: true);
        m_controlersP1_Run = m_controlersP1.FindAction("Run", throwIfNotFound: true);
        m_controlersP1_Parry = m_controlersP1.FindAction("Parry", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // controlersP1
    private readonly InputActionMap m_controlersP1;
    private IControlersP1Actions m_ControlersP1ActionsCallbackInterface;
    private readonly InputAction m_controlersP1_Forward;
    private readonly InputAction m_controlersP1_Backwards;
    private readonly InputAction m_controlersP1_Right;
    private readonly InputAction m_controlersP1_Left;
    private readonly InputAction m_controlersP1_Jump;
    private readonly InputAction m_controlersP1_Melee;
    private readonly InputAction m_controlersP1_distantAttack;
    private readonly InputAction m_controlersP1_Run;
    private readonly InputAction m_controlersP1_Parry;
    public struct ControlersP1Actions
    {
        private @PlayerInputControls m_Wrapper;
        public ControlersP1Actions(@PlayerInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forward => m_Wrapper.m_controlersP1_Forward;
        public InputAction @Backwards => m_Wrapper.m_controlersP1_Backwards;
        public InputAction @Right => m_Wrapper.m_controlersP1_Right;
        public InputAction @Left => m_Wrapper.m_controlersP1_Left;
        public InputAction @Jump => m_Wrapper.m_controlersP1_Jump;
        public InputAction @Melee => m_Wrapper.m_controlersP1_Melee;
        public InputAction @distantAttack => m_Wrapper.m_controlersP1_distantAttack;
        public InputAction @Run => m_Wrapper.m_controlersP1_Run;
        public InputAction @Parry => m_Wrapper.m_controlersP1_Parry;
        public InputActionMap Get() { return m_Wrapper.m_controlersP1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlersP1Actions set) { return set.Get(); }
        public void SetCallbacks(IControlersP1Actions instance)
        {
            if (m_Wrapper.m_ControlersP1ActionsCallbackInterface != null)
            {
                @Forward.started -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnForward;
                @Backwards.started -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnBackwards;
                @Backwards.performed -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnBackwards;
                @Backwards.canceled -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnBackwards;
                @Right.started -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnRight;
                @Left.started -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnLeft;
                @Jump.started -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnJump;
                @Melee.started -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnMelee;
                @distantAttack.started -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnDistantAttack;
                @distantAttack.performed -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnDistantAttack;
                @distantAttack.canceled -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnDistantAttack;
                @Run.started -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnRun;
                @Parry.started -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnParry;
                @Parry.performed -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnParry;
                @Parry.canceled -= m_Wrapper.m_ControlersP1ActionsCallbackInterface.OnParry;
            }
            m_Wrapper.m_ControlersP1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Backwards.started += instance.OnBackwards;
                @Backwards.performed += instance.OnBackwards;
                @Backwards.canceled += instance.OnBackwards;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
                @distantAttack.started += instance.OnDistantAttack;
                @distantAttack.performed += instance.OnDistantAttack;
                @distantAttack.canceled += instance.OnDistantAttack;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Parry.started += instance.OnParry;
                @Parry.performed += instance.OnParry;
                @Parry.canceled += instance.OnParry;
            }
        }
    }
    public ControlersP1Actions @controlersP1 => new ControlersP1Actions(this);
    public interface IControlersP1Actions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnBackwards(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
        void OnDistantAttack(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnParry(InputAction.CallbackContext context);
    }
}
