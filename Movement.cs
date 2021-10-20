// GENERATED AUTOMATICALLY FROM 'Assets/Movement/Movement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Movement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Movement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Movement"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""e10bb9b3-6bc6-4b03-87dd-e8118858f552"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""6ab27055-0c09-4765-bc88-d188569fa336"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""1c7904cb-decf-4248-9dab-5c01ba567e5d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""moveKB"",
                    ""id"": ""bc3bbe7f-89bb-4985-9e5e-1bd9188a9ded"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5f4f866b-3b2c-4fe3-94b5-60d5e6c6b86b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2ab14aef-34f5-4d7d-87de-399a987035e5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""moveCon"",
                    ""id"": ""c3e9576a-26b2-4539-8282-8a4edd42a3c6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""068058e7-b902-446e-a5be-b6aa88478d5d"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c5842d08-e8f6-4f45-a8ee-ad091b4b07c4"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""moveKB"",
                    ""id"": ""8bf3fabb-95d1-4116-a1cf-a1da42c6a8e2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""54f9805a-550c-45bd-bebe-2b114cccf9c0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a7e279de-042d-4567-950e-76e5bf3965c5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""moveCon"",
                    ""id"": ""16d43861-0be3-4bee-bb7f-740cafb21fa7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7404c177-6881-4a7a-93c0-f267b52f169c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a4e0f5dd-5b61-4df4-8d34-1c5c7cca9e71"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""192bffa1-8e29-493b-88ad-87802fa12434"",
            ""actions"": [
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Value"",
                    ""id"": ""f4ba66fa-d883-459b-98f3-719267be44b3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""644309b2-741c-4ae8-a8c7-02b38bbbd50b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3ec55683-de85-4d84-bd88-366c1fe05596"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a965e8a9-6560-4ee7-9d69-be715c7fda02"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66a0f198-f244-4102-9e3c-3a77227f2213"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8ebf7d8-fb60-4e73-813f-3dcbf184720f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""03197fb1-9268-4293-a80e-aa7f5690af08"",
            ""actions"": [
                {
                    ""name"": ""CameraX"",
                    ""type"": ""Value"",
                    ""id"": ""f704b91f-aca2-4734-ba38-4262e1425055"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraY"",
                    ""type"": ""Value"",
                    ""id"": ""9df7eadc-af24-47cd-a4fa-5572825d969c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce38bb80-2955-45c5-bc68-5cdf99d7d772"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b70ee021-c24d-47b7-b9d0-3dcd7980959a"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""418ee919-4869-40cd-a0bf-7f4a4eeeed85"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3e51c59-b299-452d-888e-86bb50834381"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Horizontal = m_Move.FindAction("Horizontal", throwIfNotFound: true);
        m_Move_Vertical = m_Move.FindAction("Vertical", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_Crouch = m_Actions.FindAction("Crouch", throwIfNotFound: true);
        m_Actions_Jump = m_Actions.FindAction("Jump", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_CameraX = m_Camera.FindAction("CameraX", throwIfNotFound: true);
        m_Camera_CameraY = m_Camera.FindAction("CameraY", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Horizontal;
    private readonly InputAction m_Move_Vertical;
    public struct MoveActions
    {
        private @Movement m_Wrapper;
        public MoveActions(@Movement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Move_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Move_Vertical;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnVertical;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_Crouch;
    private readonly InputAction m_Actions_Jump;
    public struct ActionsActions
    {
        private @Movement m_Wrapper;
        public ActionsActions(@Movement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Crouch => m_Wrapper.m_Actions_Crouch;
        public InputAction @Jump => m_Wrapper.m_Actions_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @Crouch.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnCrouch;
                @Jump.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_CameraX;
    private readonly InputAction m_Camera_CameraY;
    public struct CameraActions
    {
        private @Movement m_Wrapper;
        public CameraActions(@Movement wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraX => m_Wrapper.m_Camera_CameraX;
        public InputAction @CameraY => m_Wrapper.m_Camera_CameraY;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @CameraX.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraX;
                @CameraX.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraX;
                @CameraX.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraX;
                @CameraY.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraY;
                @CameraY.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraY;
                @CameraY.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCameraY;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraX.started += instance.OnCameraX;
                @CameraX.performed += instance.OnCameraX;
                @CameraX.canceled += instance.OnCameraX;
                @CameraY.started += instance.OnCameraY;
                @CameraY.performed += instance.OnCameraY;
                @CameraY.canceled += instance.OnCameraY;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);
    public interface IMoveActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnCrouch(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnCameraX(InputAction.CallbackContext context);
        void OnCameraY(InputAction.CallbackContext context);
    }
}
