using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Utilities/SerializableDictionary/InputActionEvent")]
public class InputActionEventDictionary : SerializableDictionary<InputActionPhase, UnityInputActionEvent> { }