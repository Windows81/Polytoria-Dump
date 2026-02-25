namespace UnityEngine;

[NativeHeader("Runtime/Graphics/DisplayManager.h")]
[Token(Token = "0x20000A1")]
[UsedByNativeCode]
public class Display
{
	[Token(Token = "0x20000A2")]
	internal sealed class DisplaysUpdatedDelegate : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600035A")]
		public DisplaysUpdatedDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x2BC000", Offset = "0x2BB200", Length = "0x16A")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180288CC0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802891B0")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600035B")]
		public override void Invoke() { }

	}

	[Token(Token = "0x40001D5")]
	public static Display[] displays; //Field offset: 0x0
	[Token(Token = "0x40001D6")]
	private static Display _mainDisplay; //Field offset: 0x8
	[Token(Token = "0x40001D7")]
	private static int m_ActiveEditorGameViewTarget; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x40001D8")]
	private static DisplaysUpdatedDelegate onDisplaysUpdated; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001D4")]
	internal IntPtr nativeDisplay; //Field offset: 0x10

	[Token(Token = "0x17000094")]
	public RenderBuffer colorBuffer
	{
		[Address(RVA = "0x1927640", Offset = "0x1926840", Length = "0x9C")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000350")]
		 get { } //Length: 156
	}

	[Token(Token = "0x17000095")]
	public static Display main
	{
		[Address(RVA = "0x19276E0", Offset = "0x19268E0", Length = "0x4F")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000352")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000091")]
	public int renderingHeight
	{
		[Address(RVA = "0x1927730", Offset = "0x1926930", Length = "0x7F")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "get_screenRenderingHeight", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "Render", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600034D")]
		 get { } //Length: 127
	}

	[Token(Token = "0x17000090")]
	public int renderingWidth
	{
		[Address(RVA = "0x19277B0", Offset = "0x19269B0", Length = "0x7F")]
		[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "get_screenRenderingWidth", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "Render", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600034C")]
		 get { } //Length: 127
	}

	[Token(Token = "0x17000093")]
	public int systemHeight
	{
		[Address(RVA = "0x1927830", Offset = "0x1926A30", Length = "0x7F")]
		[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "GetRuntimeDisplayHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PanelEventHandler", "UnityEngine.EventSystems.PointerEventData", "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "ScreenBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600034F")]
		 get { } //Length: 127
	}

	[Token(Token = "0x17000092")]
	public int systemWidth
	{
		[Address(RVA = "0x19278B0", Offset = "0x1926AB0", Length = "0x7F")]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600034E")]
		 get { } //Length: 127
	}

	[Address(RVA = "0x1927440", Offset = "0x1926640", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000359")]
	private static Display() { }

	[Address(RVA = "0x1927600", Offset = "0x1926800", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600034A")]
	internal Display() { }

	[Address(RVA = "0x19275D0", Offset = "0x19267D0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034B")]
	internal Display(IntPtr nativeDisplay) { }

	[Address(RVA = "0x1926F70", Offset = "0x1926170", Length = "0x8C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000354")]
	internal static void FireDisplaysUpdated() { }

	[Address(RVA = "0x1927640", Offset = "0x1926840", Length = "0x9C")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000350")]
	public RenderBuffer get_colorBuffer() { }

	[Address(RVA = "0x19276E0", Offset = "0x19268E0", Length = "0x4F")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.PostProcessLayer", Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000352")]
	public static Display get_main() { }

	[Address(RVA = "0x1927730", Offset = "0x1926930", Length = "0x7F")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "get_screenRenderingHeight", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "getScreenRenderingHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "Render", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600034D")]
	public int get_renderingHeight() { }

	[Address(RVA = "0x19277B0", Offset = "0x19269B0", Length = "0x7F")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "get_screenRenderingWidth", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "getScreenRenderingWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "Render", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600034C")]
	public int get_renderingWidth() { }

	[Address(RVA = "0x1927830", Offset = "0x1926A30", Length = "0x7F")]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "ScreenBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelEventHandler+PointerEvent", Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.PanelEventHandler", "UnityEngine.EventSystems.PointerEventData", "UnityEngine.UIElements.PanelEventHandler+PointerEventType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "GetRuntimeDisplayHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.PanelRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600034F")]
	public int get_systemHeight() { }

	[Address(RVA = "0x19278B0", Offset = "0x1926AB0", Length = "0x7F")]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "LoadSettings", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.SettingsController", Member = "SetFullscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600034E")]
	public int get_systemWidth() { }

	[Address(RVA = "0x1927000", Offset = "0x1926200", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("UnityDisplayManager_GetRenderingBuffersWrapper")]
	[Token(Token = "0x6000357")]
	private static void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth) { }

	[Address(RVA = "0x1927060", Offset = "0x1926260", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	[Token(Token = "0x6000356")]
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[Address(RVA = "0x19270C0", Offset = "0x19262C0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	[Token(Token = "0x6000355")]
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[Address(RVA = "0x1927120", Offset = "0x1926320", Length = "0x1E4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000353")]
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[Address(RVA = "0x1927370", Offset = "0x1926570", Length = "0xC5")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Nullable`1<Int32>&"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "MultiDisplayToLocalScreenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Nullable`1<Int32>&"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(int)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "MultiDisplayBottomLeftToPanelPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Int32&)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider", Member = "MultiDisplayToLocalScreenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), "System.Nullable`1<Int32>&"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000351")]
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	[Address(RVA = "0x1927310", Offset = "0x1926510", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	[Token(Token = "0x6000358")]
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

}

