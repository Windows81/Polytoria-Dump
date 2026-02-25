namespace UnityEngine;

[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
[NativeHeader("Runtime/Utilities/CopyPaste.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
[NativeHeader("Modules/IMGUI/GUIManager.h")]
[NativeHeader("Modules/IMGUI/GUIUtility.h")]
[Token(Token = "0x2000020")]
public class GUIUtility
{
	[Token(Token = "0x40000BE")]
	internal static int s_ControlCount; //Field offset: 0x0
	[Token(Token = "0x40000BF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int s_SkinMode; //Field offset: 0x4
	[Token(Token = "0x40000C0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int s_OriginalID; //Field offset: 0x8
	[Token(Token = "0x40000C1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action takeCapture; //Field offset: 0x10
	[Token(Token = "0x40000C2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action releaseCapture; //Field offset: 0x18
	[Token(Token = "0x40000C3")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Func<Int32, IntPtr, Boolean> processEvent; //Field offset: 0x20
	[Token(Token = "0x40000C4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action cleanupRoots; //Field offset: 0x28
	[Token(Token = "0x40000C5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Func<Exception, Boolean> endContainerGUIFromException; //Field offset: 0x30
	[Token(Token = "0x40000C6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static Action guiChanged; //Field offset: 0x38
	[Token(Token = "0x40000C7")]
	internal static Action<EventType, KeyCode, EventModifiers> beforeEventProcessed; //Field offset: 0x40
	[Token(Token = "0x40000C8")]
	private static Event m_Event; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000C9")]
	private static bool <guiIsExiting>k__BackingField; //Field offset: 0x50
	[Token(Token = "0x40000CA")]
	internal static Func<Boolean> s_HasCurrentWindowKeyFocusFunc; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40000CB")]
	private static bool <isUITK>k__BackingField; //Field offset: 0x60

	[StaticAccessor("InputBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000076")]
	internal static Vector2 compositionCursorPos
	{
		[Address(RVA = "0x19C0FE0", Offset = "0x19C01E0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001FC")]
		internal set { } //Length: 101
	}

	[StaticAccessor("InputBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000074")]
	internal static string compositionString
	{
		[Address(RVA = "0x19C0C00", Offset = "0x19BFE00", Length = "0xDE")]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayout), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "UpdateImeState", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "GeneratePreviewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "EnableCursorPreviewState", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001FA")]
		internal get { } //Length: 222
	}

	[NativeProperty("GetGUIState().m_OnGUIDepth", True, TargetType::Field (1))]
	[Token(Token = "0x17000070")]
	internal static int guiDepth
	{
		[Address(RVA = "0x19C0CE0", Offset = "0x19BFEE0", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001E9")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 42
	}

	[Token(Token = "0x17000077")]
	internal static bool guiIsExiting
	{
		[Address(RVA = "0x19C1050", Offset = "0x19C0250", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000208")]
		internal set { } //Length: 84
	}

	[Token(Token = "0x17000078")]
	public static int hotControl
	{
		[Address(RVA = "0x19C0D10", Offset = "0x19BFF10", Length = "0x5B")]
		[CalledBy(Type = "UnityEngine.UIElements.PointerDispatchState", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "DoRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(FocusType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000209")]
		 get { } //Length: 91
		[Address(RVA = "0x19C10B0", Offset = "0x19C02B0", Length = "0x62")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.PointerDispatchState", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "DoRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(FocusType)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "EndScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SliderHandler), Member = "OnRepaint", ReturnType = typeof(float))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600020A")]
		 set { } //Length: 98
	}

	[StaticAccessor("InputBindings", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x17000075")]
	internal static IMECompositionMode imeCompositionMode
	{
		[Address(RVA = "0x19C1120", Offset = "0x19C0320", Length = "0x31")]
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.FocusEvent"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BlurEvent"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001FB")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 49
	}

	[Token(Token = "0x1700007A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool isUITK
	{
		[Address(RVA = "0x19C0D70", Offset = "0x19BFF70", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x600021C")]
		internal get { } //Length: 79
		[Address(RVA = "0x19C1160", Offset = "0x19C0360", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x600021D")]
		internal set { } //Length: 84
	}

	[Token(Token = "0x17000079")]
	public static int keyboardControl
	{
		[Address(RVA = "0x19C0DC0", Offset = "0x19BFFC0", Length = "0x5B")]
		[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(bool), typeof(bool), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(GUILayout), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600020D")]
		 get { } //Length: 91
		[Address(RVA = "0x19C11C0", Offset = "0x19C03C0", Length = "0x62")]
		[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600020E")]
		 set { } //Length: 98
	}

	[NativeProperty("GetGUIState().m_CanvasGUIState.m_IsMouseUsed", True, TargetType::Field (1))]
	[Token(Token = "0x17000071")]
	internal static bool mouseUsed
	{
		[Address(RVA = "0x19C1230", Offset = "0x19C0430", Length = "0x33")]
		[CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001EA")]
		internal set { } //Length: 51
	}

	[NativeProperty("GetGUIState().m_PixelsPerPoint", True, TargetType::Field (1))]
	[Token(Token = "0x1700006F")]
	internal static float pixelsPerPoint
	{
		[Address(RVA = "0x19C0E20", Offset = "0x19C0020", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_scaledPixelsPerPoint_noChecks", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.Layout.LayoutNode&", typeof(float), "UnityEngine.UIElements.Layout.LayoutMeasureMode", typeof(float), "UnityEngine.UIElements.Layout.LayoutMeasureMode", "UnityEngine.UIElements.Layout.LayoutSize&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUILayoutUtility), Member = "LayoutFromEditorWindow", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GUIStyle), Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(MeshInfoBindings[]&), typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001E7")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 42
		[Address(RVA = "0x19C1270", Offset = "0x19C0470", Length = "0x3A")]
		[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001E8")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 58
	}

	[Token(Token = "0x17000073")]
	public static string systemCopyBuffer
	{
		[Address(RVA = "0x19C0E90", Offset = "0x19C0090", Length = "0xDE")]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "GetClipboardText", ReturnType = typeof(string))]
		[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_clipboard", ReturnType = typeof(string))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_clipboard", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "CanPaste", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextEditingUtilities), Member = "Paste", ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("GetCopyBuffer")]
		[Token(Token = "0x60001ED")]
		 get { } //Length: 222
		[Address(RVA = "0x19C12F0", Offset = "0x19C04F0", Length = "0x18B")]
		[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "SetClipboardText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("SetCopyBuffer")]
		[Token(Token = "0x60001EE")]
		 set { } //Length: 395
	}

	[StaticAccessor("GetInputManager()", StaticAccessorType::Dot (0))]
	[Token(Token = "0x17000072")]
	internal static bool textFieldInput
	{
		[Address(RVA = "0x19C0F70", Offset = "0x19C0170", Length = "0x2A")]
		[CalledBy(Type = typeof(EventInterests), Member = "WantsLayoutPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001EB")]
		internal get { } //Length: 42
		[Address(RVA = "0x19C1480", Offset = "0x19C0680", Length = "0x33")]
		[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60001EC")]
		internal set { } //Length: 51
	}

	[Address(RVA = "0x19C0B20", Offset = "0x19BFD20", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Event), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000225")]
	private static GUIUtility() { }

	[Address(RVA = "0x19BEBD0", Offset = "0x19BDDD0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F9")]
	public static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels) { }

	[Address(RVA = "0x19BEC70", Offset = "0x19BDE70", Length = "0xDC")]
	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000221")]
	public static Rect AlignRectToDevice(Rect rect) { }

	[Address(RVA = "0x19BEB60", Offset = "0x19BDD60", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022C")]
	private static void AlignRectToDevice_Injected(in Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret) { }

	[Address(RVA = "0x19BEE60", Offset = "0x19BE060", Length = "0x6F")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void BeginContainer(ObjectGUIState objectGUIState) { }

	[Address(RVA = "0x19BEE20", Offset = "0x19BE020", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022A")]
	private static void BeginContainer_Injected(IntPtr objectGUIState) { }

	[Address(RVA = "0x19BED90", Offset = "0x19BDF90", Length = "0x8C")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void BeginContainerFromOwner(ScriptableObject owner) { }

	[Address(RVA = "0x19BED50", Offset = "0x19BDF50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000229")]
	private static void BeginContainerFromOwner_Injected(IntPtr owner) { }

	[Address(RVA = "0x19BEED0", Offset = "0x19BE0D0", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "set_skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "Begin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000214")]
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[Address(RVA = "0x19BF0D0", Offset = "0x19BE2D0", Length = "0x6F")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int CheckForTabEvent(Event evt) { }

	[Address(RVA = "0x19BF090", Offset = "0x19BE290", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022B")]
	private static int CheckForTabEvent_Injected(IntPtr evt) { }

	[Address(RVA = "0x19BF140", Offset = "0x19BE340", Length = "0xB1")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021E")]
	internal static void CheckOnGUI() { }

	[Address(RVA = "0x19BF200", Offset = "0x19BE400", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "RemoveSelectedIdList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[RequiredByNativeCode]
	[Token(Token = "0x6000215")]
	internal static void DestroyGUI(int instanceID) { }

	[Address(RVA = "0x19BF2F0", Offset = "0x19BE4F0", Length = "0x7C")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "EndContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000213")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void EndContainer() { }

	[Address(RVA = "0x19BF250", Offset = "0x19BE450", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000218")]
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[Address(RVA = "0x19BF470", Offset = "0x19BE670", Length = "0x170")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayoutUtility), Member = "LayoutFromEditorWindow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_current", ReturnType = typeof(Event))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayoutUtility), Member = "SelectIDList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(LayoutCache))]
	[Calls(Type = typeof(GUIContent), Member = "ClearStaticCache", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1819BAA60")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000216")]
	internal static void EndGUI(int layoutType) { }

	[Address(RVA = "0x19BF370", Offset = "0x19BE570", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000217")]
	internal static bool EndGUIFromException(Exception exception) { }

	[Address(RVA = "0x19BF5F0", Offset = "0x19BE7F0", Length = "0x52")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ExitGUIException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000210")]
	public static void ExitGUI() { }

	[Address(RVA = "0x19C0C00", Offset = "0x19BFE00", Length = "0xDE")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayout), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "UpdateImeState", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "GeneratePreviewString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "EnableCursorPreviewState", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextEditor), Member = "DrawCursor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FA")]
	internal static string get_compositionString() { }

	[Address(RVA = "0x19C0BC0", Offset = "0x19BFDC0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022D")]
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x19C0CE0", Offset = "0x19BFEE0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static int get_guiDepth() { }

	[Address(RVA = "0x19C0D10", Offset = "0x19BFF10", Length = "0x5B")]
	[CalledBy(Type = "UnityEngine.UIElements.PointerDispatchState", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "DoRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(FocusType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000209")]
	public static int get_hotControl() { }

	[Address(RVA = "0x19C0D70", Offset = "0x19BFF70", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x600021C")]
	internal static bool get_isUITK() { }

	[Address(RVA = "0x19C0DC0", Offset = "0x19BFFC0", Length = "0x5B")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(bool), typeof(bool), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GUILayout), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "DrawWithTextSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020D")]
	public static int get_keyboardControl() { }

	[Address(RVA = "0x19C0E20", Offset = "0x19C0020", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "SaveGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_scaledPixelsPerPoint", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "get_scaledPixelsPerPoint_noChecks", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "Measure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", "UnityEngine.UIElements.Layout.LayoutNode&", typeof(float), "UnityEngine.UIElements.Layout.LayoutMeasureMode", typeof(float), "UnityEngine.UIElements.Layout.LayoutMeasureMode", "UnityEngine.UIElements.Layout.LayoutSize&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "AddStyleSheetPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "Layout", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUILayoutUtility), Member = "LayoutFromEditorWindow", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIStyle), Member = "GetMeshInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(Color), typeof(string), typeof(Rect), typeof(MeshInfoBindings[]&), typeof(Vector2&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static float get_pixelsPerPoint() { }

	[Address(RVA = "0x19C0E90", Offset = "0x19C0090", Length = "0xDE")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "CanPaste", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "get_clipboard", ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "TMPro.TMP_InputField+EditState")]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "Paste", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "PasteInstancesFromClipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "GetClipboardText", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextEditingUtilities), Member = "PerformOperation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextEditOp)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "get_clipboard", ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = "UnityEngine.Bindings.OutStringMarshaller", Member = "GetStringAndDispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Bindings.ManagedSpanWrapper"}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetCopyBuffer")]
	[Token(Token = "0x60001ED")]
	public static string get_systemCopyBuffer() { }

	[Address(RVA = "0x19C0E50", Offset = "0x19C0050", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000226")]
	private static void get_systemCopyBuffer_Injected(out ManagedSpanWrapper ret) { }

	[Address(RVA = "0x19C0F70", Offset = "0x19C0170", Length = "0x2A")]
	[CalledBy(Type = typeof(EventInterests), Member = "WantsLayoutPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventType)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001EB")]
	internal static bool get_textFieldInput() { }

	[Address(RVA = "0x19BF7D0", Offset = "0x19BE9D0", Length = "0xCE")]
	[CalledBy(Type = typeof(GUI), Member = "Button", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GUI), Member = "DoRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(FocusType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GUI), Member = "Slider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle), typeof(GUIStyle), typeof(bool), typeof(int), typeof(GUIStyle)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUI), Member = "Scroller", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(float), typeof(float), typeof(float), typeof(float), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GUI), Member = "EndScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusType)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FocusType), typeof(Rect)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FocusType)}, ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F0")]
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	[Address(RVA = "0x19BF8A0", Offset = "0x19BEAA0", Length = "0x133")]
	[CalledBy(Type = typeof(GUI), Member = "PasswordField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string), typeof(char), typeof(int), typeof(GUIStyle)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(GUILayout), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(bool), typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FocusType), typeof(Rect)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000204")]
	public static int GetControlID(FocusType focus) { }

	[Address(RVA = "0x19BF650", Offset = "0x19BE850", Length = "0x64")]
	[CalledBy(Type = typeof(GUI), Member = "PasswordField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(string), typeof(char), typeof(int), typeof(GUIStyle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FocusType), typeof(Rect)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000205")]
	public static int GetControlID(FocusType focus, Rect position) { }

	[Address(RVA = "0x19BF6C0", Offset = "0x19BE8C0", Length = "0x10D")]
	[CalledBy(Type = typeof(GUI), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(GUIUtility), Member = "GetControlID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(FocusType), typeof(Rect)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000206")]
	public static int GetControlID(int hint, FocusType focus) { }

	[Address(RVA = "0x19BF9E0", Offset = "0x19BEBE0", Length = "0x9E")]
	[CalledBy(Type = typeof(GUI), Member = "DoSetSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000211")]
	internal static GUISkin GetDefaultSkin() { }

	[Address(RVA = "0x19BFA80", Offset = "0x19BEC80", Length = "0x57")]
	[CalledBy(Type = typeof(GUI), Member = "DoTextField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "BeginScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Vector2), typeof(Rect), typeof(bool), typeof(bool), typeof(GUIStyle), typeof(GUIStyle), typeof(GUIStyle)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUIStateObjects), Member = "GetStateObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000207")]
	public static object GetStateObject(Type t, int controlID) { }

	[Address(RVA = "0x19BFAE0", Offset = "0x19BECE0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F7")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool HasFocusableControls() { }

	[Address(RVA = "0x19BFB10", Offset = "0x19BED10", Length = "0x11C")]
	[CalledBy(Type = typeof(GUIStyle), Member = "Draw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600020F")]
	internal static bool HasKeyFocus(int controlID) { }

	[Address(RVA = "0x19BFC30", Offset = "0x19BEE30", Length = "0x117")]
	[CalledBy(Type = typeof(GUI), Member = "DoControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(bool), typeof(bool), typeof(GUIContent), typeof(GUIStyle)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SliderHandler), Member = "OnMouseDown", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(SliderHandler), Member = "OnRepaint", ReturnType = typeof(float))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Event), Member = "get_mousePosition", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Event), Member = "get_isDirectManipulationDevice", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000224")]
	internal static bool HitTest(Rect rect, Event evt) { }

	[Address(RVA = "0x19BFDD0", Offset = "0x19BEFD0", Length = "0xB3")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "IsEventInsideLocalWindow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000223")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	[Address(RVA = "0x19BFD50", Offset = "0x19BEF50", Length = "0x76")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000222")]
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	[Address(RVA = "0x19BFE90", Offset = "0x19BF090", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("EndContainer")]
	[Token(Token = "0x60001F3")]
	internal static void Internal_EndContainer() { }

	[Address(RVA = "0x19BFEC0", Offset = "0x19BF0C0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000202")]
	private static void Internal_ExitGUI() { }

	[Address(RVA = "0x19BFF40", Offset = "0x19BF140", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("GetGUIState().GetControlID")]
	[Token(Token = "0x60001EF")]
	private static int Internal_GetControlID(int hint, FocusType focusType, Rect rect) { }

	[Address(RVA = "0x19BFEF0", Offset = "0x19BF0F0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000228")]
	private static int Internal_GetControlID_Injected(int hint, FocusType focusType, in Rect rect) { }

	[Address(RVA = "0x19BFFC0", Offset = "0x19BF1C0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000201")]
	private static object Internal_GetDefaultSkin(int skinMode) { }

	[Address(RVA = "0x19C0000", Offset = "0x19BF200", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FD")]
	private static int Internal_GetHotControl() { }

	[Address(RVA = "0x19C0030", Offset = "0x19BF230", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FE")]
	private static int Internal_GetKeyboardControl() { }

	[Address(RVA = "0x19C0060", Offset = "0x19BF260", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FF")]
	private static void Internal_SetHotControl(int value) { }

	[Address(RVA = "0x19C00A0", Offset = "0x19BF2A0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000200")]
	private static void Internal_SetKeyboardControl(int value) { }

	[Address(RVA = "0x19C00E0", Offset = "0x19BF2E0", Length = "0x7A")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.RenderTree", typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool IsExitGUIException(Exception exception) { }

	[Address(RVA = "0x19C0160", Offset = "0x19BF360", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000203")]
	private static void MarkGUIChanged() { }

	[Address(RVA = "0x19C01D0", Offset = "0x19BF3D0", Length = "0x31")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool OwnsId(int id) { }

	[Address(RVA = "0x19C0210", Offset = "0x19BF410", Length = "0x232")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Event), Member = "CopyFromPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Event), Member = "get_type", ReturnType = typeof(EventType))]
	[Calls(Type = typeof(Event), Member = "get_keyCode", ReturnType = typeof(KeyCode))]
	[Calls(Type = typeof(Event), Member = "get_modifiers", ReturnType = typeof(EventModifiers))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000212")]
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	[Address(RVA = "0x19C0450", Offset = "0x19BF650", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600020C")]
	internal static void RemoveCapture() { }

	[Address(RVA = "0x19C04C0", Offset = "0x19BF6C0", Length = "0x113")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "BeginContainerGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LayoutCache), typeof(Event), "UnityEngine.UIElements.IMGUIContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "set_skin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUISkin)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUI), Member = "set_changed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000219")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void ResetGlobalState() { }

	[Address(RVA = "0x19C05E0", Offset = "0x19BF7E0", Length = "0x3BD")]
	[CalledBy(Type = "LTRect", Member = "get_rect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUI), Member = "get_matrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GUI), Member = "set_matrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUIClip), Member = "Unclip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_FromEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Token(Token = "0x6000220")]
	public static void RotateAroundPivot(float angle, Vector2 pivotPoint) { }

	[Address(RVA = "0x19C0FE0", Offset = "0x19C01E0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FC")]
	internal static void set_compositionCursorPos(Vector2 value) { }

	[Address(RVA = "0x19C0FA0", Offset = "0x19C01A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600022E")]
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }

	[Address(RVA = "0x19C1050", Offset = "0x19C0250", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000208")]
	internal static void set_guiIsExiting(bool value) { }

	[Address(RVA = "0x19C10B0", Offset = "0x19C02B0", Length = "0x62")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "HandleIMGUIEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.PointerDispatchState", Member = "CapturePointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.IEventHandler", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "DoRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(FocusType)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "EndScrollView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SliderHandler), Member = "OnRepaint", ReturnType = typeof(float))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020A")]
	public static void set_hotControl(int value) { }

	[Address(RVA = "0x19C1120", Offset = "0x19C0320", Length = "0x31")]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "HandleEventBubbleUp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.EventBase"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnFocus", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.FocusEvent"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.KeyboardTextEditorEventHandler", Member = "OnBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BlurEvent"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001FB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_imeCompositionMode(IMECompositionMode value) { }

	[Address(RVA = "0x19C1160", Offset = "0x19C0360", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x600021D")]
	internal static void set_isUITK(bool value) { }

	[Address(RVA = "0x19C11C0", Offset = "0x19C03C0", Length = "0x62")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(string), typeof(char), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600020E")]
	public static void set_keyboardControl(int value) { }

	[Address(RVA = "0x19C1230", Offset = "0x19C0430", Length = "0x33")]
	[CalledBy(Type = typeof(GUI), Member = "BeginGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(GUIContent), typeof(GUIStyle), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001EA")]
	internal static void set_mouseUsed(bool value) { }

	[Address(RVA = "0x19C1270", Offset = "0x19C0470", Length = "0x3A")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "RestoreGlobals", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001E8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_pixelsPerPoint(float value) { }

	[Address(RVA = "0x19C12F0", Offset = "0x19C04F0", Length = "0x18B")]
	[CalledBy(Type = "Polytoria.Controllers.ClipboardController", Member = "SetClipboardText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_clipboard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSelectingUtilities), Member = "Copy", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("SetCopyBuffer")]
	[Token(Token = "0x60001EE")]
	public static void set_systemCopyBuffer(string value) { }

	[Address(RVA = "0x19C12B0", Offset = "0x19C04B0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000227")]
	private static void set_systemCopyBuffer_Injected(ref ManagedSpanWrapper value) { }

	[Address(RVA = "0x19C1480", Offset = "0x19C0680", Length = "0x33")]
	[CalledBy(Type = typeof(GUI), Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), typeof(GUIContent), typeof(bool), typeof(int), typeof(GUIStyle), typeof(TextEditor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001EC")]
	internal static void set_textFieldInput(bool value) { }

	[Address(RVA = "0x19C09A0", Offset = "0x19BFBA0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetKeyboardControlToFirstControlId() { }

	[Address(RVA = "0x19C09D0", Offset = "0x19BFBD0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.WorldSpaceInput", Member = "Pick_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIDocument", typeof(Ray), "System.Collections.Generic.List`1<VisualElement>"}, ReturnType = "UnityEngine.UIElements.VisualElement")]
	[CalledBy(Type = "UnityEngine.UIElements.IMGUIContainer", Member = "DoOnGUI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event), typeof(Matrix4x4), typeof(Rect), typeof(bool), typeof(Rect), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001F6")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetKeyboardControlToLastControlId() { }

	[Address(RVA = "0x19C0A00", Offset = "0x19BFC00", Length = "0xAA")]
	[CalledBy(Type = "UnityEngine.UIElements.UIEventRegistration", Member = "EndContainerGUIFromException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600021B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static bool ShouldRethrowException(Exception exception) { }

	[Address(RVA = "0x19C0AB0", Offset = "0x19BFCB0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600020B")]
	internal static void TakeCapture() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600021F")]
	internal static void WarnOnGUI() { }

}

