namespace UnityEngine;

[NativeHeader("Modules/IMGUI/Event.bindings.h")]
[StaticAccessor("GUIEvent", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000002")]
public sealed class Event
{
	[Token(Token = "0x2000003")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x7CE590", Offset = "0x7CD790", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000059")]
		public static IntPtr ConvertToNative(Event e) { }

	}

	[Token(Token = "0x4000002")]
	internal const float scrollWheelDeltaPerTick = 3; //Field offset: 0x0
	[Token(Token = "0x4000003")]
	internal static bool ignoreGuiDepth; //Field offset: 0x0
	[Token(Token = "0x4000004")]
	private static Event s_Current; //Field offset: 0x8
	[Token(Token = "0x4000005")]
	private static Event s_MasterEvent; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000014")]
	public bool alt
	{
		[Address(RVA = "0x199FFF0", Offset = "0x199F1F0", Length = "0x56")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600002C")]
		 get { } //Length: 86
	}

	[NativeProperty("button", False, TargetType::Field (1))]
	[Token(Token = "0x17000005")]
	public int button
	{
		[Address(RVA = "0x19A0090", Offset = "0x199F290", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CallerCount(Count = 4)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000007")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000016")]
	public bool capsLock
	{
		[Address(RVA = "0x19A00F0", Offset = "0x199F2F0", Length = "0x56")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600002E")]
		 get { } //Length: 86
	}

	[NativeProperty("character", False, TargetType::Field (1))]
	[Token(Token = "0x1700000C")]
	public char character
	{
		[Address(RVA = "0x19A0190", Offset = "0x199F390", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UI.InputField+EditState")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
		[CallerCount(Count = 8)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000F")]
		 get { } //Length: 81
		[Address(RVA = "0x19A1290", Offset = "0x19A0490", Length = "0x5A")]
		[CalledBy(Type = "UnityEngine.UIElements.KeyDownEvent", Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
		[CallerCount(Count = 10)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000010")]
		 set { } //Length: 90
	}

	[NativeProperty("clickCount", False, TargetType::Field (1))]
	[Token(Token = "0x1700000B")]
	public int clickCount
	{
		[Address(RVA = "0x19A0230", Offset = "0x199F430", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000E")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000015")]
	public bool command
	{
		[Address(RVA = "0x19A03B0", Offset = "0x199F5B0", Length = "0x56")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600002D")]
		 get { } //Length: 86
	}

	[Token(Token = "0x17000011")]
	public string commandName
	{
		[Address(RVA = "0x19A02E0", Offset = "0x199F4E0", Length = "0xCE")]
		[CalledBy(Type = "UnityEngine.UIElements.CommandEventBase`1", Member = "get_commandName", ReturnType = typeof(string))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = "UnityEngine.InputForUI.CommandEvent")]
		[CallerCount(Count = 6)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
		[Token(Token = "0x6000019")]
		 get { } //Length: 206
		[Address(RVA = "0x19A1340", Offset = "0x19A0540", Length = "0x1A9")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
		[Token(Token = "0x600001A")]
		 set { } //Length: 425
	}

	[Token(Token = "0x17000013")]
	public bool control
	{
		[Address(RVA = "0x19A0410", Offset = "0x199F610", Length = "0x56")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600002B")]
		 get { } //Length: 86
	}

	[Token(Token = "0x17000019")]
	public static Event current
	{
		[Address(RVA = "0x19A0470", Offset = "0x199F670", Length = "0x37")]
		[CallerCount(Count = 59)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000031")]
		 get { } //Length: 55
		[Address(RVA = "0x19A14F0", Offset = "0x19A06F0", Length = "0xAB")]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000032")]
		 set { } //Length: 171
	}

	[NativeProperty("delta", False, TargetType::Field (1))]
	[Token(Token = "0x17000003")]
	public Vector2 delta
	{
		[Address(RVA = "0x19A0500", Offset = "0x199F700", Length = "0x62")]
		[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.WheelEvent")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000004")]
		 get { } //Length: 98
		[Address(RVA = "0x19A15F0", Offset = "0x19A07F0", Length = "0x5B")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__28_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Event)}, ReturnType = "UnityEngine.UIElements.EventBase")]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000005")]
		 set { } //Length: 91
	}

	[NativeProperty("displayIndex", False, TargetType::Field (1))]
	[Token(Token = "0x1700000F")]
	public int displayIndex
	{
		[Address(RVA = "0x19A05B0", Offset = "0x199F7B0", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000015")]
		 get { } //Length: 81
		[Address(RVA = "0x19A1690", Offset = "0x19A0890", Length = "0x58")]
		[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000016")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000018")]
	public bool functionKey
	{
		[Address(RVA = "0x19A0610", Offset = "0x199F810", Length = "0x56")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000030")]
		 get { } //Length: 86
	}

	[NativeProperty("keycode", False, TargetType::Field (1))]
	[Token(Token = "0x1700000D")]
	private KeyCode Internal_keyCode
	{
		[Address(RVA = "0x199FF90", Offset = "0x199F190", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000011")]
		private get { } //Length: 81
		[Address(RVA = "0x19A11E0", Offset = "0x19A03E0", Length = "0x58")]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000012")]
		private set { } //Length: 88
	}

	[Token(Token = "0x1700001D")]
	internal bool isDirectManipulationDevice
	{
		[Address(RVA = "0x19A0670", Offset = "0x199F870", Length = "0xCC")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Event)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000036")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 204
	}

	[Token(Token = "0x1700001A")]
	public bool isKey
	{
		[Address(RVA = "0x19A0740", Offset = "0x199F940", Length = "0x7F")]
		[CalledBy(Type = typeof(Event), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000033")]
		 get { } //Length: 127
	}

	[Token(Token = "0x1700001B")]
	public bool isMouse
	{
		[Address(RVA = "0x19A07C0", Offset = "0x199F9C0", Length = "0x89")]
		[CalledBy(Type = typeof(Event), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000034")]
		 get { } //Length: 137
	}

	[Token(Token = "0x1700001C")]
	public bool isScrollWheel
	{
		[Address(RVA = "0x19A0850", Offset = "0x199FA50", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000035")]
		 get { } //Length: 87
	}

	[Token(Token = "0x1700000E")]
	public KeyCode keyCode
	{
		[Address(RVA = "0x19A08B0", Offset = "0x199FAB0", Length = "0x249")]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = "UnityEngine.InputForUI.KeyEvent")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIUtility), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(bool), typeof(bool), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(Event), Member = "GetHashCode", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UI.InputField+EditState")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardEventExtensions", Member = "ShouldSendNavigationMoveEventRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = typeof(Event), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 7)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000013")]
		 get { } //Length: 585
		[Address(RVA = "0x19A11E0", Offset = "0x19A03E0", Length = "0x58")]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000014")]
		 set { } //Length: 88
	}

	[NativeProperty("modifiers", False, TargetType::Field (1))]
	[Token(Token = "0x17000006")]
	public EventModifiers modifiers
	{
		[Address(RVA = "0x19A0B40", Offset = "0x199FD40", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Focusable"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditor), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GUIUtility), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(Boolean&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UI.InputField+EditState")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000008")]
		 get { } //Length: 81
		[Address(RVA = "0x19A1730", Offset = "0x19A0930", Length = "0x58")]
		[CalledBy(Type = "UnityEngine.UIElements.KeyDownEvent", Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditor), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 14)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000009")]
		 set { } //Length: 88
	}

	[NativeProperty("mousePosition", False, TargetType::Field (1))]
	[Token(Token = "0x17000002")]
	public Vector2 mousePosition
	{
		[Address(RVA = "0x19A0BF0", Offset = "0x199FDF0", Length = "0x62")]
		[CalledBy(Type = "UnityEngine.UIElements.EventBase", Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIEvent", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.IMGUIEvent")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Event)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SliderHandler), Member = "CurrentScrollTroughSide", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(SliderHandler), Member = "ValueForCurrentMousePosition", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(SliderHandler), Member = "MousePosition", ReturnType = typeof(float))]
		[CallerCount(Count = 13)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000002")]
		 get { } //Length: 98
		[Address(RVA = "0x19A17E0", Offset = "0x19A09E0", Length = "0x5B")]
		[CalledBy(Type = "UnityEngine.UIElements.EventBase", Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__28_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Event)}, ReturnType = "UnityEngine.UIElements.EventBase")]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000003")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000017")]
	public bool numeric
	{
		[Address(RVA = "0x19A0C60", Offset = "0x199FE60", Length = "0x56")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600002F")]
		 get { } //Length: 86
	}

	[NativeProperty("penStatus", False, TargetType::Field (1))]
	[Token(Token = "0x1700000A")]
	public PenStatus penStatus
	{
		[Address(RVA = "0x19A0D00", Offset = "0x199FF00", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CallerCount(Count = 3)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000D")]
		 get { } //Length: 81
	}

	[NativeProperty("pointerType", False, TargetType::Field (1))]
	[Token(Token = "0x17000004")]
	public PointerType pointerType
	{
		[Address(RVA = "0x19A0DA0", Offset = "0x199FFA0", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000006")]
		 get { } //Length: 81
	}

	[NativeProperty("pressure", False, TargetType::Field (1))]
	[Token(Token = "0x17000007")]
	public float pressure
	{
		[Address(RVA = "0x19A0E40", Offset = "0x19A0040", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CallerCount(Count = 2)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000A")]
		 get { } //Length: 81
	}

	[NativeProperty("type", False, TargetType::Field (1))]
	[Token(Token = "0x17000001")]
	public EventType rawType
	{
		[Address(RVA = "0x19A0EE0", Offset = "0x19A00E0", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GUILayoutGroup), Member = "GetNext", ReturnType = typeof(GUILayoutEntry))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.EventBase")]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.EventBase")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "GetCurrentTransformAndClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IMGUIContainer", typeof(Event), typeof(Matrix4x4&), typeof(Rect&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerMoveEvent", Member = "GetPooledCompatibilityMouseEvent", ReturnType = "UnityEngine.UIElements.IMouseEvent")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "IsTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "IsMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.EventDispatchUtilities", Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 34)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000001")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000012")]
	public bool shift
	{
		[Address(RVA = "0x19A0F40", Offset = "0x19A0140", Length = "0x56")]
		[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventModifiers)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Focusable"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), "UnityEngine.UIElements.Focusable"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "MoveCursorToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600002A")]
		 get { } //Length: 86
	}

	[NativeProperty("tilt", False, TargetType::Field (1))]
	[Token(Token = "0x17000009")]
	public Vector2 tilt
	{
		[Address(RVA = "0x19A0FF0", Offset = "0x19A01F0", Length = "0x62")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000C")]
		 get { } //Length: 98
	}

	[NativeProperty("twist", False, TargetType::Field (1))]
	[Token(Token = "0x17000008")]
	public float twist
	{
		[Address(RVA = "0x19A10A0", Offset = "0x19A02A0", Length = "0x51")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
		[CallerCount(Count = 1)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600000B")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000010")]
	public EventType type
	{
		[Address(RVA = "0x19A1140", Offset = "0x19A0340", Length = "0x51")]
		[CallerCount(Count = 52)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
		[Token(Token = "0x6000017")]
		 get { } //Length: 81
		[Address(RVA = "0x19A1880", Offset = "0x19A0A80", Length = "0x58")]
		[CalledBy(Type = "UnityEngine.UIElements.KeyDownEvent", Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 9)]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
		[Token(Token = "0x6000018")]
		 set { } //Length: 88
	}

	[Address(RVA = "0x199FF00", Offset = "0x199F100", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	public Event(int displayIndex) { }

	[Address(RVA = "0x199FEC0", Offset = "0x199F0C0", Length = "0x3D")]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "get_legacyInputProcessor", ReturnType = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DefaultEventSystem+UpdateMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.DefaultEventSystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIEvent", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.IMGUIEvent")]
	[CalledBy(Type = "UnityEngine.UIElements.EventBase", Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.TextElement", typeof(TextEditingUtilities)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	public Event() { }

	[Address(RVA = "0x199D010", Offset = "0x199C210", Length = "0x6B")]
	[CalledBy(Type = "UnityEngine.UIElements.EventBase", Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyDownEvent", Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIEvent", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.IMGUIEvent")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "EndContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000029")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void CopyFrom(Event e) { }

	[Address(RVA = "0x199CFB0", Offset = "0x199C1B0", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "UnityEngine.UIElements.IUIElementsUtility.ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GUIUtility), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = True, HasExplicitThis = True)]
	[Token(Token = "0x600001F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void CopyFromPtr(IntPtr ptr) { }

	[Address(RVA = "0x199CF60", Offset = "0x199C160", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000056")]
	private static void CopyFromPtr_Injected(IntPtr _unity_self, IntPtr ptr) { }

	[Address(RVA = "0x199D080", Offset = "0x199C280", Length = "0x2E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Event), Member = "get_isKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_isMouse", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000039")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x199D370", Offset = "0x199C570", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x199FFF0", Offset = "0x199F1F0", Length = "0x56")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002C")]
	public bool get_alt() { }

	[Address(RVA = "0x19A0090", Offset = "0x199F290", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CallerCount(Count = 4)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public int get_button() { }

	[Address(RVA = "0x19A0050", Offset = "0x199F250", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	private static int get_button_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A00F0", Offset = "0x199F2F0", Length = "0x56")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002E")]
	public bool get_capsLock() { }

	[Address(RVA = "0x19A0190", Offset = "0x199F390", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UI.InputField+EditState")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	public char get_character() { }

	[Address(RVA = "0x19A0150", Offset = "0x199F350", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	private static char get_character_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A0230", Offset = "0x199F430", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	public int get_clickCount() { }

	[Address(RVA = "0x19A01F0", Offset = "0x199F3F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000049")]
	private static int get_clickCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A03B0", Offset = "0x199F5B0", Length = "0x56")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002D")]
	public bool get_command() { }

	[Address(RVA = "0x19A02E0", Offset = "0x199F4E0", Length = "0xCE")]
	[CalledBy(Type = "UnityEngine.UIElements.CommandEventBase`1", Member = "get_commandName", ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = "UnityEngine.InputForUI.CommandEvent")]
	[CallerCount(Count = 6)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
	[Token(Token = "0x6000019")]
	public string get_commandName() { }

	[Address(RVA = "0x19A0290", Offset = "0x199F490", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000052")]
	private static void get_commandName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x19A0410", Offset = "0x199F610", Length = "0x56")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002B")]
	public bool get_control() { }

	[Address(RVA = "0x19A0470", Offset = "0x199F670", Length = "0x37")]
	[CallerCount(Count = 59)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000031")]
	public static Event get_current() { }

	[Address(RVA = "0x19A0500", Offset = "0x199F700", Length = "0x62")]
	[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.WheelEvent", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.WheelEvent")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	public Vector2 get_delta() { }

	[Address(RVA = "0x19A04B0", Offset = "0x199F6B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	private static void get_delta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x19A05B0", Offset = "0x199F7B0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000015")]
	public int get_displayIndex() { }

	[Address(RVA = "0x19A0570", Offset = "0x199F770", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	private static int get_displayIndex_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A0610", Offset = "0x199F810", Length = "0x56")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000030")]
	public bool get_functionKey() { }

	[Address(RVA = "0x199FF90", Offset = "0x199F190", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	private KeyCode get_Internal_keyCode() { }

	[Address(RVA = "0x199FF50", Offset = "0x199F150", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	private static KeyCode get_Internal_keyCode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A0670", Offset = "0x199F870", Length = "0xCC")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Event)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000036")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool get_isDirectManipulationDevice() { }

	[Address(RVA = "0x19A0740", Offset = "0x199F940", Length = "0x7F")]
	[CalledBy(Type = typeof(Event), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000033")]
	public bool get_isKey() { }

	[Address(RVA = "0x19A07C0", Offset = "0x199F9C0", Length = "0x89")]
	[CalledBy(Type = typeof(Event), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000034")]
	public bool get_isMouse() { }

	[Address(RVA = "0x19A0850", Offset = "0x199FA50", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000035")]
	public bool get_isScrollWheel() { }

	[Address(RVA = "0x19A08B0", Offset = "0x199FAB0", Length = "0x249")]
	[CalledBy(Type = typeof(Event), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardEventExtensions", Member = "ShouldSendNavigationMoveEventRuntime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
	[CalledBy(Type = typeof(Event), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Event), Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UI.InputField+EditState")]
	[CalledBy(Type = typeof(GUIUtility), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = "UnityEngine.InputForUI.KeyEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(bool), typeof(bool), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000013")]
	public KeyCode get_keyCode() { }

	[Address(RVA = "0x19A0B40", Offset = "0x199FD40", Length = "0x51")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
	[CalledBy(Type = typeof(GUIUtility), Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(IntPtr), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditor), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Focusable"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UI.InputField+EditState")]
	[CallerCount(Count = 23)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	public EventModifiers get_modifiers() { }

	[Address(RVA = "0x19A0B00", Offset = "0x199FD00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000043")]
	private static EventModifiers get_modifiers_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A0BF0", Offset = "0x199FDF0", Length = "0x62")]
	[CalledBy(Type = "UnityEngine.UIElements.EventBase", Member = "set_imguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.MouseEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIEvent", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.IMGUIEvent")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = "HitTest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SliderHandler), Member = "CurrentScrollTroughSide", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SliderHandler), Member = "ValueForCurrentMousePosition", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(SliderHandler), Member = "MousePosition", ReturnType = typeof(float))]
	[CallerCount(Count = 13)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000002")]
	public Vector2 get_mousePosition() { }

	[Address(RVA = "0x19A0BA0", Offset = "0x199FDA0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	private static void get_mousePosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x19A0C60", Offset = "0x199FE60", Length = "0x56")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002F")]
	public bool get_numeric() { }

	[Address(RVA = "0x19A0D00", Offset = "0x199FF00", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000D")]
	public PenStatus get_penStatus() { }

	[Address(RVA = "0x19A0CC0", Offset = "0x199FEC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000048")]
	private static PenStatus get_penStatus_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A0DA0", Offset = "0x199FFA0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public PointerType get_pointerType() { }

	[Address(RVA = "0x19A0D60", Offset = "0x199FF60", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	private static PointerType get_pointerType_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A0E40", Offset = "0x19A0040", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	public float get_pressure() { }

	[Address(RVA = "0x19A0E00", Offset = "0x19A0000", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000045")]
	private static float get_pressure_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A0EE0", Offset = "0x19A00E0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "Dispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel", "UnityEngine.UIElements.DispatchMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatcher", Member = "ProcessEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.EventDispatchUtilities", Member = "PropagateToRemainingIMGUIContainerRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", "UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "IsMouse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "IsTouch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerMoveEvent", Member = "GetPooledCompatibilityMouseEvent", ReturnType = "UnityEngine.UIElements.IMouseEvent")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "GetCurrentTransformAndClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IMGUIContainer", typeof(Event), typeof(Matrix4x4&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.EventBase")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "CreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UIElements.EventBase")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutGroup), Member = "GetNext", ReturnType = typeof(GUILayoutEntry))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 34)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000001")]
	public EventType get_rawType() { }

	[Address(RVA = "0x19A0EA0", Offset = "0x19A00A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	private static EventType get_rawType_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A0F40", Offset = "0x19A0140", Length = "0x56")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(EventModifiers)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Focusable"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ProcessTabEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), "UnityEngine.UIElements.Focusable"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "MoveCursorToPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "UpdateEventModifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002A")]
	public bool get_shift() { }

	[Address(RVA = "0x19A0FF0", Offset = "0x19A01F0", Length = "0x62")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public Vector2 get_tilt() { }

	[Address(RVA = "0x19A0FA0", Offset = "0x19A01A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000047")]
	private static void get_tilt_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x19A10A0", Offset = "0x19A02A0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerEventBase`1", Member = "GetPooled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "T")]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	public float get_twist() { }

	[Address(RVA = "0x19A1060", Offset = "0x19A0260", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	private static float get_twist_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19A1140", Offset = "0x19A0340", Length = "0x51")]
	[CallerCount(Count = 52)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
	[Token(Token = "0x6000017")]
	public EventType get_type() { }

	[Address(RVA = "0x19A1100", Offset = "0x19A0300", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000050")]
	private static EventType get_type_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x199D400", Offset = "0x199C600", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.ClickDetector", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "ProcessPointerDown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IPointerEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseVerticalCollectionView", Member = "ProcessPointerUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IPointerEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+Input", Member = "get_doubleClickTime", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.TextSelectingManipulator", Member = "OnPointerDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PointerDownEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.PointerState", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.InputForUIModule"})]
	internal static int GetDoubleClickTime() { }

	[Address(RVA = "0x199D470", Offset = "0x199C670", Length = "0x9C")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.InputForUIModule"})]
	internal static void GetEventAtIndex(int index, Event outEvent) { }

	[Address(RVA = "0x199D430", Offset = "0x199C630", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000058")]
	private static void GetEventAtIndex_Injected(int index, IntPtr outEvent) { }

	[Address(RVA = "0x199D510", Offset = "0x199C710", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	public static int GetEventCount() { }

	[Address(RVA = "0x199D540", Offset = "0x199C740", Length = "0x180")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000038")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x199D710", Offset = "0x199C910", Length = "0x58")]
	[CalledBy(Type = typeof(SliderHandler), Member = "Handle", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(SliderHandler), Member = "CurrentEventType", ReturnType = typeof(EventType))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = True)]
	[Token(Token = "0x600001E")]
	public EventType GetTypeForControl(int controlID) { }

	[Address(RVA = "0x199D6D0", Offset = "0x199C8D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000055")]
	private static EventType GetTypeForControl_Injected(IntPtr _unity_self, int controlID) { }

	[Address(RVA = "0x199D770", Offset = "0x199C970", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = True)]
	[Token(Token = "0x600001C")]
	private static IntPtr Internal_Create(int displayIndex) { }

	[Address(RVA = "0x199D7B0", Offset = "0x199C9B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = True)]
	[Token(Token = "0x600001D")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x199D7F0", Offset = "0x199C9F0", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000024")]
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	[Address(RVA = "0x199D970", Offset = "0x199CB70", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000023")]
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[Address(RVA = "0x199D9F0", Offset = "0x199CBF0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("Use")]
	[Token(Token = "0x600001B")]
	private void Internal_Use() { }

	[Address(RVA = "0x199D9B0", Offset = "0x199CBB0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	private static void Internal_Use_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x199DA50", Offset = "0x199CC50", Length = "0x1A95")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "MapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "MapKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextSelectOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "InitKeyActions", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "set_modifiers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventModifiers)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Event), Member = "set_character", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 62)]
	[CallsUnknownMethods(Count = 36)]
	[Token(Token = "0x6000037")]
	public static Event KeyboardEvent(string key) { }

	[Address(RVA = "0x199F530", Offset = "0x199E730", Length = "0x8F")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor", Member = "SendIMGUIEvents", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnUpdateSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.BaseEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler", Member = "ProcessImguiEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Focusable"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	public static bool PopEvent(Event outEvent) { }

	[Address(RVA = "0x199F4F0", Offset = "0x199E6F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000057")]
	private static bool PopEvent_Injected(IntPtr outEvent) { }

	[Address(RVA = "0x19A1290", Offset = "0x19A0490", Length = "0x5A")]
	[CalledBy(Type = "UnityEngine.UIElements.KeyDownEvent", Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
	[CallerCount(Count = 10)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	public void set_character(char value) { }

	[Address(RVA = "0x19A1240", Offset = "0x19A0440", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	private static void set_character_Injected(IntPtr _unity_self, char value) { }

	[Address(RVA = "0x19A1340", Offset = "0x19A0540", Length = "0x1A9")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
	[Token(Token = "0x600001A")]
	public void set_commandName(string value) { }

	[Address(RVA = "0x19A12F0", Offset = "0x19A04F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	private static void set_commandName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x19A14F0", Offset = "0x19A06F0", Length = "0xAB")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000032")]
	public static void set_current(Event value) { }

	[Address(RVA = "0x19A15F0", Offset = "0x19A07F0", Length = "0x5B")]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__28_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Event)}, ReturnType = "UnityEngine.UIElements.EventBase")]
	[CallerCount(Count = 1)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000005")]
	public void set_delta(Vector2 value) { }

	[Address(RVA = "0x19A15A0", Offset = "0x19A07A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000040")]
	private static void set_delta_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x19A1690", Offset = "0x19A0890", Length = "0x58")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	public void set_displayIndex(int value) { }

	[Address(RVA = "0x19A1650", Offset = "0x19A0850", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004F")]
	private static void set_displayIndex_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x19A11E0", Offset = "0x19A03E0", Length = "0x58")]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	private void set_Internal_keyCode(KeyCode value) { }

	[Address(RVA = "0x19A11A0", Offset = "0x19A03A0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	private static void set_Internal_keyCode_Injected(IntPtr _unity_self, KeyCode value) { }

	[Address(RVA = "0x19A11E0", Offset = "0x19A03E0", Length = "0x58")]
	[CallerCount(Count = 5)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	public void set_keyCode(KeyCode value) { }

	[Address(RVA = "0x19A1730", Offset = "0x19A0930", Length = "0x58")]
	[CalledBy(Type = "UnityEngine.UIElements.KeyDownEvent", Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Event), Member = "KeyboardEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Event))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditor), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "HandleKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	public void set_modifiers(EventModifiers value) { }

	[Address(RVA = "0x19A16F0", Offset = "0x19A08F0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000044")]
	private static void set_modifiers_Injected(IntPtr _unity_self, EventModifiers value) { }

	[Address(RVA = "0x19A17E0", Offset = "0x19A09E0", Length = "0x5B")]
	[CalledBy(Type = "UnityEngine.UIElements.EventBase", Member = "set_currentTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.DefaultEventSystem+LegacyInputProcessor+<>c", Member = "<SendIMGUIEvents>b__28_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Event)}, ReturnType = "UnityEngine.UIElements.EventBase")]
	[CallerCount(Count = 3)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000003")]
	public void set_mousePosition(Vector2 value) { }

	[Address(RVA = "0x19A1790", Offset = "0x19A0990", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	private static void set_mousePosition_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x19A1880", Offset = "0x19A0A80", Length = "0x58")]
	[CalledBy(Type = "UnityEngine.UIElements.KeyDownEvent", Member = "GetEquivalentImguiEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SendEventToIMGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase", typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
	[Token(Token = "0x6000018")]
	public void set_type(EventType value) { }

	[Address(RVA = "0x19A1840", Offset = "0x19A0A40", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000051")]
	private static void set_type_Injected(IntPtr _unity_self, EventType value) { }

	[Address(RVA = "0x199F5C0", Offset = "0x199E7C0", Length = "0x76B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Event), Member = "get_commandName", ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003A")]
	public virtual string ToString() { }

	[Address(RVA = "0x199FD30", Offset = "0x199EF30", Length = "0x18E")]
	[CalledBy(Type = typeof(SliderHandler), Member = "OnMouseUp", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(SliderHandler), Member = "OnMouseDown", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUI), Member = "EndScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(bool), typeof(bool), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SliderHandler), Member = "OnMouseDrag", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "DoRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(FocusType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600003B")]
	public void Use() { }

}

