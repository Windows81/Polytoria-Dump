namespace UnityEngine;

[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
[Token(Token = "0x2000183")]
public class TouchScreenKeyboard
{
	[Token(Token = "0x2000186")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B01")]
		public static IntPtr ConvertToNative(TouchScreenKeyboard touchScreenKeyboard) { }

	}

	[Token(Token = "0x2000185")]
	internal enum InputFieldAppearance
	{
		Customizable = 0,
		AlwaysVisible = 1,
		AlwaysHidden = 2,
	}

	[Token(Token = "0x2000184")]
	internal enum Status
	{
		Visible = 0,
		Done = 1,
		Canceled = 2,
		LostFocus = 3,
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40005BD")]
	private static bool <disableInPlaceEditing>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005BC")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x170001D2")]
	public bool active
	{
		[Address(RVA = "0x1972320", Offset = "0x1971520", Length = "0x51")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_shouldHideSoftKeyboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "isKeyboardUsingEvents", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("IsActive")]
		[Token(Token = "0x6000AEE")]
		 get { } //Length: 81
		[Address(RVA = "0x1972870", Offset = "0x1971A70", Length = "0x5B")]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_shouldHideSoftKeyboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DeactivateInputField", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SetActive")]
		[Token(Token = "0x6000AEF")]
		 set { } //Length: 91
	}

	[Token(Token = "0x170001D5")]
	public bool canGetSelection
	{
		[Address(RVA = "0x19723C0", Offset = "0x19715C0", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("CanGetSelection")]
		[Token(Token = "0x6000AF2")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170001D6")]
	public bool canSetSelection
	{
		[Address(RVA = "0x1972460", Offset = "0x1971660", Length = "0x51")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("CanSetSelection")]
		[Token(Token = "0x6000AF3")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170001D4")]
	public int characterLimit
	{
		[Address(RVA = "0x1972910", Offset = "0x1971B10", Length = "0x58")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SetCharacterLimit")]
		[Token(Token = "0x6000AF1")]
		 set { } //Length: 88
	}

	[Token(Token = "0x170001CD")]
	internal static bool disableInPlaceEditing
	{
		[Address(RVA = "0x19724C0", Offset = "0x19716C0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000AE5")]
		internal get { } //Length: 54
	}

	[Token(Token = "0x170001D0")]
	public static bool hideInput
	{
		[Address(RVA = "0x1972970", Offset = "0x1971B70", Length = "0x33")]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SetInputHidden")]
		[Token(Token = "0x6000AEC")]
		 set { } //Length: 51
	}

	[Token(Token = "0x170001D1")]
	public static InputFieldAppearance inputFieldAppearance
	{
		[Address(RVA = "0x1972500", Offset = "0x1971700", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.get_hideMobileInput", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.set_hideMobileInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetInputFieldAppearance")]
		[Token(Token = "0x6000AED")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001CE")]
	public static bool isInPlaceEditingAllowed
	{
		[Address(RVA = "0x1972530", Offset = "0x1971730", Length = "0x60")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.GUI", Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), "UnityEngine.GUIContent", typeof(bool), typeof(int), "UnityEngine.GUIStyle", typeof(string), typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUI", Member = "PasswordField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string), typeof(char), typeof(int), "UnityEngine.GUIStyle"}, ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "PollTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AE6")]
		 get { } //Length: 96
	}

	[Token(Token = "0x170001CC")]
	public static bool isSupported
	{
		[Address(RVA = "0x1972590", Offset = "0x1971790", Length = "0x80")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Token(Token = "0x6000AE4")]
		 get { } //Length: 128
	}

	[Token(Token = "0x170001D7")]
	public RangeInt selection
	{
		[Address(RVA = "0x1972610", Offset = "0x1971810", Length = "0x42")]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AF4")]
		 get { } //Length: 66
		[Address(RVA = "0x19729B0", Offset = "0x1971BB0", Length = "0x11F")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OnPointerDownEvent", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000AF5")]
		 set { } //Length: 287
	}

	[Token(Token = "0x170001D3")]
	public Status status
	{
		[Address(RVA = "0x19726A0", Offset = "0x19718A0", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "SendTouchScreenKeyboardStatusChanged", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUI", Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), "UnityEngine.GUIContent", typeof(bool), typeof(int), "UnityEngine.GUIStyle", typeof(string), typeof(char), "UnityEngine.TextEditor"}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetKeyboardStatus")]
		[Token(Token = "0x6000AF0")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170001CF")]
	public string text
	{
		[Address(RVA = "0x1972750", Offset = "0x1971950", Length = "0xCE")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OnPointerDownEvent", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.UpdateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.GUI", Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), "UnityEngine.GUIContent", typeof(bool), typeof(int), "UnityEngine.GUIStyle", typeof(string), typeof(char), "UnityEngine.TextEditor"}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("GetText")]
		[Token(Token = "0x6000AEA")]
		 get { } //Length: 206
		[Address(RVA = "0x1972B20", Offset = "0x1971D20", Length = "0x1A9")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ForwardSpace", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Backspace", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "Backspace", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "DeleteKey", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.UpdateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("SetText")]
		[Token(Token = "0x6000AEB")]
		 set { } //Length: 425
	}

	[Address(RVA = "0x19721D0", Offset = "0x19713D0", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "TouchScreenKeyboard_InternalConstructorHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboard_InternalConstructorHelperArguments&), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000AE2")]
	public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[Address(RVA = "0x19719E0", Offset = "0x1970BE0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AE0")]
	private void Destroy() { }

	[Address(RVA = "0x1971A70", Offset = "0x1970C70", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AE1")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x1972320", Offset = "0x1971520", Length = "0x51")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_shouldHideSoftKeyboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "isKeyboardUsingEvents", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("IsActive")]
	[Token(Token = "0x6000AEE")]
	public bool get_active() { }

	[Address(RVA = "0x19722E0", Offset = "0x19714E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AFB")]
	private static bool get_active_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19723C0", Offset = "0x19715C0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("CanGetSelection")]
	[Token(Token = "0x6000AF2")]
	public bool get_canGetSelection() { }

	[Address(RVA = "0x1972380", Offset = "0x1971580", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AFF")]
	private static bool get_canGetSelection_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1972460", Offset = "0x1971660", Length = "0x51")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("CanSetSelection")]
	[Token(Token = "0x6000AF3")]
	public bool get_canSetSelection() { }

	[Address(RVA = "0x1972420", Offset = "0x1971620", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B00")]
	private static bool get_canSetSelection_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19724C0", Offset = "0x19716C0", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000AE5")]
	internal static bool get_disableInPlaceEditing() { }

	[Address(RVA = "0x1972500", Offset = "0x1971700", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.get_hideMobileInput", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.set_hideMobileInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetInputFieldAppearance")]
	[Token(Token = "0x6000AED")]
	public static InputFieldAppearance get_inputFieldAppearance() { }

	[Address(RVA = "0x1972530", Offset = "0x1971730", Length = "0x60")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "PollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "PasswordField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string), typeof(char), typeof(int), "UnityEngine.GUIStyle"}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), "UnityEngine.GUIContent", typeof(bool), typeof(int), "UnityEngine.GUIStyle", typeof(string), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AE6")]
	public static bool get_isInPlaceEditingAllowed() { }

	[Address(RVA = "0x1972590", Offset = "0x1971790", Length = "0x80")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Token(Token = "0x6000AE4")]
	public static bool get_isSupported() { }

	[Address(RVA = "0x1972610", Offset = "0x1971810", Length = "0x42")]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateStringPositionFromKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF4")]
	public RangeInt get_selection() { }

	[Address(RVA = "0x19726A0", Offset = "0x19718A0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "SendTouchScreenKeyboardStatusChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), "UnityEngine.GUIContent", typeof(bool), typeof(int), "UnityEngine.GUIStyle", typeof(string), typeof(char), "UnityEngine.TextEditor"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetKeyboardStatus")]
	[Token(Token = "0x6000AF0")]
	public Status get_status() { }

	[Address(RVA = "0x1972660", Offset = "0x1971860", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AFD")]
	private static Status get_status_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1972750", Offset = "0x1971950", Length = "0xCE")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenKeyboard), Member = "set_selection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RangeInt)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.UpdateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OnPointerDownEvent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), "UnityEngine.GUIContent", typeof(bool), typeof(int), "UnityEngine.GUIStyle", typeof(string), typeof(char), "UnityEngine.TextEditor"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "DoPollTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(OutStringMarshaller), Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManagedSpanWrapper)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetText")]
	[Token(Token = "0x6000AEA")]
	public string get_text() { }

	[Address(RVA = "0x1972700", Offset = "0x1971900", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF9")]
	private static void get_text_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x1971B40", Offset = "0x1970D40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF6")]
	private static void GetSelection(out int start, out int length) { }

	[Address(RVA = "0x1971B90", Offset = "0x1970D90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = True)]
	[Token(Token = "0x6000ADF")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x1971BD0", Offset = "0x1970DD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AE7")]
	private static bool IsInPlaceEditingAllowed() { }

	[Address(RVA = "0x1971D40", Offset = "0x1970F40", Length = "0x159")]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), "UnityEngine.GUIContent", typeof(bool), typeof(int), "UnityEngine.GUIStyle", typeof(string), typeof(char), "UnityEngine.TextEditor"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "TouchScreenKeyboard_InternalConstructorHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboard_InternalConstructorHelperArguments&), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000AE9")]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	[Address(RVA = "0x1971C00", Offset = "0x1970E00", Length = "0x138")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "TouchScreenKeyboard_InternalConstructorHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchScreenKeyboard_InternalConstructorHelperArguments&), typeof(string), typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000AE8")]
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[Address(RVA = "0x1972870", Offset = "0x1971A70", Length = "0x5B")]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_shouldHideSoftKeyboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "DeactivateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "DeactivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetActive")]
	[Token(Token = "0x6000AEF")]
	public void set_active(bool value) { }

	[Address(RVA = "0x1972820", Offset = "0x1971A20", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AFC")]
	private static void set_active_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1972910", Offset = "0x1971B10", Length = "0x58")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_characterLimit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetCharacterLimit")]
	[Token(Token = "0x6000AF1")]
	public void set_characterLimit(int value) { }

	[Address(RVA = "0x19728D0", Offset = "0x1971AD0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AFE")]
	private static void set_characterLimit_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x1972970", Offset = "0x1971B70", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "CloseTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetInputHidden")]
	[Token(Token = "0x6000AEC")]
	public static void set_hideInput(bool value) { }

	[Address(RVA = "0x19729B0", Offset = "0x1971BB0", Length = "0x11F")]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OpenTouchScreenKeyboard", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TouchScreenTextEditorEventHandler", Member = "OnPointerDownEvent", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "DrawNativeHighlighting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateKeyboardCaret", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateKeyboardStringPosition", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(TouchScreenKeyboard), Member = "get_text", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000AF5")]
	public void set_selection(RangeInt value) { }

	[Address(RVA = "0x1972B20", Offset = "0x1971D20", Length = "0x1A9")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.TextElement", Member = "UnityEngine.UIElements.ITextEdition.UpdateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "DeleteKey", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "SetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Backspace", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ForwardSpace", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("SetText")]
	[Token(Token = "0x6000AEB")]
	public void set_text(string value) { }

	[Address(RVA = "0x1972AD0", Offset = "0x1971CD0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AFA")]
	private static void set_text_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x1971EA0", Offset = "0x19710A0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF7")]
	private static void SetSelection(int start, int length) { }

	[Address(RVA = "0x1971F40", Offset = "0x1971140", Length = "0x28C")]
	[CalledBy(Type = typeof(TouchScreenKeyboard), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(int)}, ReturnType = typeof(TouchScreenKeyboard))]
	[CalledBy(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TouchScreenKeyboardType), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(TouchScreenKeyboard))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	[Token(Token = "0x6000AE3")]
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	[Address(RVA = "0x1971EE0", Offset = "0x19710E0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AF8")]
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper_Injected(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ref ManagedSpanWrapper text, ref ManagedSpanWrapper textPlaceholder) { }

}

