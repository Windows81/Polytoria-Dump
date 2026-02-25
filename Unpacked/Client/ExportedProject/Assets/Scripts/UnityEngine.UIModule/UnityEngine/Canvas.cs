namespace UnityEngine;

[NativeClass("UI::Canvas")]
[NativeHeader("Modules/UI/UIStructs.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000008")]
public sealed class Canvas : Behaviour
{
	[Token(Token = "0x2000009")]
	internal sealed class WillRenderCanvases : MulticastDelegate
	{

		[Address(RVA = "0x2D8810", Offset = "0x2D7A10", Length = "0xA5")]
		[CallerCount(Count = 285)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000099")]
		public WillRenderCanvases(object object, IntPtr method) { }

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
		[Token(Token = "0x600009A")]
		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400000E")]
	private static WillRenderCanvases preWillRenderCanvases; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x400000F")]
	private static WillRenderCanvases willRenderCanvases; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000010")]
	private static Action<Int32> <externBeginRenderOverlays>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000011")]
	private static Action<Int32, Int32> <externRenderOverlaysBefore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000012")]
	private static Action<Int32> <externEndRenderOverlays>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x14000001")]
	public static event WillRenderCanvases preWillRenderCanvases
	{
		[Address(RVA = "0x1CAEC10", Offset = "0x1CADE10", Length = "0xB4")]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnEnable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600005B")]
		 add { } //Length: 180
		[Address(RVA = "0x1CAF930", Offset = "0x1CAEB30", Length = "0xB4")]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600005C")]
		 remove { } //Length: 180
	}

	[Token(Token = "0x14000002")]
	public static event WillRenderCanvases willRenderCanvases
	{
		[Address(RVA = "0x1CAECD0", Offset = "0x1CADED0", Length = "0xB8")]
		[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_UpdateManager", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_UpdateRegistry", Member = "get_instance", ReturnType = "TMPro.TMP_UpdateRegistry")]
		[CalledBy(Type = "TMPro.TMP_UpdateRegistry", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "SubscribeOnWillRenderCanvases", ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600005D")]
		 add { } //Length: 184
		[Address(RVA = "0x1CAF9F0", Offset = "0x1CAEBF0", Length = "0xB8")]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "UnsubscribeFromWillRenderCanvases", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600005E")]
		 remove { } //Length: 184
	}

	[Token(Token = "0x17000017")]
	public AdditionalCanvasShaderChannels additionalShaderChannels
	{
		[Address(RVA = "0x1CAEDD0", Offset = "0x1CADFD0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "FixTexCoordsInCanvas", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "FixTexCoordsInCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006E")]
		 get { } //Length: 118
		[Address(RVA = "0x1CAFAF0", Offset = "0x1CAECF0", Length = "0x83")]
		[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "FixTexCoordsInCanvas", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "FixTexCoordsInCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006F")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700001A")]
	internal static Action<Int32> externBeginRenderOverlays
	{
		[Address(RVA = "0x1CAEE50", Offset = "0x1CAE050", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000072")]
		internal get { } //Length: 55
		[Address(RVA = "0x1CAFB80", Offset = "0x1CAED80", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000073")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 86
	}

	[Token(Token = "0x1700001C")]
	internal static Action<Int32> externEndRenderOverlays
	{
		[Address(RVA = "0x1CAEE90", Offset = "0x1CAE090", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000076")]
		internal get { } //Length: 55
		[Address(RVA = "0x1CAFBE0", Offset = "0x1CAEDE0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000077")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 86
	}

	[Token(Token = "0x1700001B")]
	internal static Action<Int32, Int32> externRenderOverlaysBefore
	{
		[Address(RVA = "0x1CAEED0", Offset = "0x1CAE0D0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000074")]
		internal get { } //Length: 55
		[Address(RVA = "0x1CAFC40", Offset = "0x1CAEE40", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000075")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal set { } //Length: 86
	}

	[Token(Token = "0x1700000E")]
	public bool isRootCanvas
	{
		[Address(RVA = "0x1CAEF50", Offset = "0x1CAE150", Length = "0x76")]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "Handle", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000060")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000013")]
	public bool overrideSorting
	{
		[Address(RVA = "0x1CAF010", Offset = "0x1CAE210", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMasksForClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.RectMask2D", "System.Collections.Generic.List`1<RectMask2D>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
		[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
		[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMaskForClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.IClippable"}, ReturnType = "UnityEngine.UI.RectMask2D")]
		[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SoftMasking.SoftMask", "SoftMasking.SoftMask"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "SoftMasking.SoftMaskable", Member = "NearestMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Boolean&), typeof(bool)}, ReturnType = "SoftMasking.ISoftMask")]
		[CalledBy(Type = "SoftMasking.SoftMaskable", Member = "IsOverridingSortingCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000067")]
		 get { } //Length: 118
		[Address(RVA = "0x1CAFCF0", Offset = "0x1CAEEF0", Length = "0x86")]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetupTemplate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000068")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000011")]
	public bool pixelPerfect
	{
		[Address(RVA = "0x1CAF0D0", Offset = "0x1CAE2D0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000065")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000010")]
	public float referencePixelsPerUnit
	{
		[Address(RVA = "0x1CAF190", Offset = "0x1CAE390", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "SpriteToCanvasScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000063")]
		 get { } //Length: 118
		[Address(RVA = "0x1CAFDD0", Offset = "0x1CAEFD0", Length = "0x86")]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetReferencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000064")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000019")]
	public Vector2 renderingDisplaySize
	{
		[Address(RVA = "0x1CAF3E0", Offset = "0x1CAE5E0", Length = "0x87")]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000071")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700000D")]
	public RenderMode renderMode
	{
		[Address(RVA = "0x1CAF250", Offset = "0x1CAE450", Length = "0x76")]
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005F")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000012")]
	public int renderOrder
	{
		[Address(RVA = "0x1CAF310", Offset = "0x1CAE510", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000066")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000018")]
	public Canvas rootCanvas
	{
		[Address(RVA = "0x1CAF4B0", Offset = "0x1CAE6B0", Length = "0x90")]
		[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SoftMasking.SoftMask", "SoftMasking.SoftMask"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCanvasSpaceClippingRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "GetRootCanvasTransform", ReturnType = typeof(Transform))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "FillCommonParameters", ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "WorldToMask", ReturnType = typeof(Matrix4x4))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000070")]
		 get { } //Length: 144
	}

	[Token(Token = "0x1700000F")]
	public float scaleFactor
	{
		[Address(RVA = "0x1CAF590", Offset = "0x1CAE790", Length = "0x76")]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "Battlehub.UIControls.ItemDropMarker", Member = "SetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.TreeViewDropMarker", Member = "SetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemDropMarker", Member = "SetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000061")]
		 get { } //Length: 118
		[Address(RVA = "0x1CAFEB0", Offset = "0x1CAF0B0", Length = "0x86")]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetScaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000062")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000016")]
	public int sortingLayerID
	{
		[Address(RVA = "0x1CAF650", Offset = "0x1CAE850", Length = "0x76")]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006C")]
		 get { } //Length: 118
		[Address(RVA = "0x1CAFF80", Offset = "0x1CAF180", Length = "0x83")]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006D")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000014")]
	public int sortingOrder
	{
		[Address(RVA = "0x1CAF710", Offset = "0x1CAE910", Length = "0x76")]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_sortOrderPriority", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000069")]
		 get { } //Length: 118
		[Address(RVA = "0x1CB0050", Offset = "0x1CAF250", Length = "0x83")]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetupTemplate", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006A")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000015")]
	public int targetDisplay
	{
		[Address(RVA = "0x1CAF7D0", Offset = "0x1CAE9D0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006B")]
		 get { } //Length: 118
	}

	[NativeProperty("Camera", False, TargetType::Function (0))]
	[Token(Token = "0x1700001D")]
	public Camera worldCamera
	{
		[Address(RVA = "0x1CAF890", Offset = "0x1CAEA90", Length = "0x90")]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Awake", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.MenuControl.ContextMenuTrigger", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnContextMenuTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000079")]
		 get { } //Length: 144
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000082")]
	public Canvas() { }

	[Address(RVA = "0x1CAEC10", Offset = "0x1CADE10", Length = "0xB4")]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600005B")]
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	[Address(RVA = "0x1CAECD0", Offset = "0x1CADED0", Length = "0xB8")]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_UpdateManager", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_UpdateRegistry", Member = "get_instance", ReturnType = "TMPro.TMP_UpdateRegistry")]
	[CalledBy(Type = "TMPro.TMP_UpdateRegistry", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "SubscribeOnWillRenderCanvases", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600005D")]
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	[Address(RVA = "0x1CAE860", Offset = "0x1CADA60", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600007F")]
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[Address(RVA = "0x1CAE8C0", Offset = "0x1CADAC0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000081")]
	private static void EndRenderExtraOverlays(int displayIndex) { }

	[Address(RVA = "0x1CAE920", Offset = "0x1CADB20", Length = "0x8F")]
	[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "scrollViewToBottom", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "PushChat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "<set_state>b__22_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.UI.ChatWindow", Member = "<set_state>b__22_3", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.UI.UISpeechBubble", Member = "set_Message", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "EnsureLayoutHasRebuilt", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "OnScroll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "SetNormalizedPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.TreeView", Member = "FixScrollRect", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600007C")]
	public static void ForceUpdateCanvases() { }

	[Address(RVA = "0x1CAEDD0", Offset = "0x1CADFD0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "FixTexCoordsInCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "FixTexCoordsInCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006E")]
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	[Address(RVA = "0x1CAED90", Offset = "0x1CADF90", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000092")]
	private static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAEE50", Offset = "0x1CAE050", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000072")]
	internal static Action<Int32> get_externBeginRenderOverlays() { }

	[Address(RVA = "0x1CAEE90", Offset = "0x1CAE090", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000076")]
	internal static Action<Int32> get_externEndRenderOverlays() { }

	[Address(RVA = "0x1CAEED0", Offset = "0x1CAE0D0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000074")]
	internal static Action<Int32, Int32> get_externRenderOverlaysBefore() { }

	[Address(RVA = "0x1CAEF50", Offset = "0x1CAE150", Length = "0x76")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.AspectRatioFitter", Member = "IsComponentValidOnObject", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "Handle", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000060")]
	public bool get_isRootCanvas() { }

	[Address(RVA = "0x1CAEF10", Offset = "0x1CAE110", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000084")]
	private static bool get_isRootCanvas_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF010", Offset = "0x1CAE210", Length = "0x76")]
	[CalledBy(Type = "SoftMasking.SoftMaskable", Member = "IsOverridingSortingCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "SoftMasking.SoftMaskable", Member = "NearestMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Boolean&), typeof(bool)}, ReturnType = "SoftMasking.ISoftMask")]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMaskForClippable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.IClippable"}, ReturnType = "UnityEngine.UI.RectMask2D")]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SoftMasking.SoftMask", "SoftMasking.SoftMask"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[CalledBy(Type = "TMPro.TMP_MaterialManager", Member = "GetStencilID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMasksForClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.RectMask2D", "System.Collections.Generic.List`1<RectMask2D>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000067")]
	public bool get_overrideSorting() { }

	[Address(RVA = "0x1CAEFD0", Offset = "0x1CAE1D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008B")]
	private static bool get_overrideSorting_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF0D0", Offset = "0x1CAE2D0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000065")]
	public bool get_pixelPerfect() { }

	[Address(RVA = "0x1CAF090", Offset = "0x1CAE290", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000089")]
	private static bool get_pixelPerfect_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF190", Offset = "0x1CAE390", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "SpriteToCanvasScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000063")]
	public float get_referencePixelsPerUnit() { }

	[Address(RVA = "0x1CAF150", Offset = "0x1CAE350", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000087")]
	private static float get_referencePixelsPerUnit_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF3E0", Offset = "0x1CAE5E0", Length = "0x87")]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000071")]
	public Vector2 get_renderingDisplaySize() { }

	[Address(RVA = "0x1CAF390", Offset = "0x1CAE590", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000095")]
	private static void get_renderingDisplaySize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x1CAF250", Offset = "0x1CAE450", Length = "0x76")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005F")]
	public RenderMode get_renderMode() { }

	[Address(RVA = "0x1CAF210", Offset = "0x1CAE410", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000083")]
	private static RenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF310", Offset = "0x1CAE510", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000066")]
	public int get_renderOrder() { }

	[Address(RVA = "0x1CAF2D0", Offset = "0x1CAE4D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	private static int get_renderOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF4B0", Offset = "0x1CAE6B0", Length = "0x90")]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "WorldToMask", ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "FillCommonParameters", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "GetRootCanvasTransform", ReturnType = typeof(Transform))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GetCanvasSpaceClippingRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "AreCompeting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SoftMasking.SoftMask", "SoftMasking.SoftMask"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_renderOrderPriority", ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	public Canvas get_rootCanvas() { }

	[Address(RVA = "0x1CAF470", Offset = "0x1CAE670", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000094")]
	private static IntPtr get_rootCanvas_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF590", Offset = "0x1CAE790", Length = "0x76")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UI.Text", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "Battlehub.UIControls.ItemDropMarker", Member = "SetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.TreeViewDropMarker", Member = "SetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemDropMarker", Member = "SetPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000061")]
	public float get_scaleFactor() { }

	[Address(RVA = "0x1CAF550", Offset = "0x1CAE750", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000085")]
	private static float get_scaleFactor_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF650", Offset = "0x1CAE850", Length = "0x76")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006C")]
	public int get_sortingLayerID() { }

	[Address(RVA = "0x1CAF610", Offset = "0x1CAE810", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000090")]
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF710", Offset = "0x1CAE910", Length = "0x76")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_sortOrderPriority", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000069")]
	public int get_sortingOrder() { }

	[Address(RVA = "0x1CAF6D0", Offset = "0x1CAE8D0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008D")]
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF7D0", Offset = "0x1CAE9D0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006B")]
	public int get_targetDisplay() { }

	[Address(RVA = "0x1CAF790", Offset = "0x1CAE990", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008F")]
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAF890", Offset = "0x1CAEA90", Length = "0x90")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Battlehub.UIControls.MenuControl.ContextMenuTrigger", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnContextMenuTriggered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000079")]
	public Camera get_worldCamera() { }

	[Address(RVA = "0x1CAF850", Offset = "0x1CAEA50", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000096")]
	private static IntPtr get_worldCamera_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAE9E0", Offset = "0x1CADBE0", Length = "0x54")]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_defaultGraphicMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_defaultMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = "SoftMasking.SoftMask+MaterialReplacerImpl", Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "SoftMasking.SoftMaskable", Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "SoftMasking.Extensions.MaterialOps", Member = "HasDefaultUIShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("UI::GetDefaultUIMaterial")]
	[Token(Token = "0x600007A")]
	public static Material GetDefaultCanvasMaterial() { }

	[Address(RVA = "0x1CAE9B0", Offset = "0x1CADBB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000097")]
	private static IntPtr GetDefaultCanvasMaterial_Injected() { }

	[Address(RVA = "0x1CAEA70", Offset = "0x1CADC70", Length = "0x54")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_defaultETC1GraphicMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_material", ReturnType = typeof(Material))]
	[CalledBy(Type = "SoftMasking.SoftMask+MaterialReplacerImpl", Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = "SoftMasking.Extensions.MaterialOps", Member = "HasDefaultETC1UIShader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	[Token(Token = "0x600007B")]
	public static Material GetETC1SupportedCanvasMaterial() { }

	[Address(RVA = "0x1CAEA40", Offset = "0x1CADC40", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000098")]
	private static IntPtr GetETC1SupportedCanvasMaterial_Injected() { }

	[Address(RVA = "0x1CAF930", Offset = "0x1CAEB30", Length = "0xB4")]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600005C")]
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	[Address(RVA = "0x1CAF9F0", Offset = "0x1CAEBF0", Length = "0xB8")]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "UnsubscribeFromWillRenderCanvases", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600005E")]
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	[Address(RVA = "0x1CAEAD0", Offset = "0x1CADCD0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x6000080")]
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[Address(RVA = "0x1CAEB30", Offset = "0x1CADD30", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600007D")]
	private static void SendPreWillRenderCanvases() { }

	[Address(RVA = "0x1CAEB80", Offset = "0x1CADD80", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600007E")]
	private static void SendWillRenderCanvases() { }

	[Address(RVA = "0x1CAFAF0", Offset = "0x1CAECF0", Length = "0x83")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "FixTexCoordsInCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "FixTexCoordsInCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006F")]
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	[Address(RVA = "0x1CAFAB0", Offset = "0x1CAECB0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000093")]
	private static void set_additionalShaderChannels_Injected(IntPtr _unity_self, AdditionalCanvasShaderChannels value) { }

	[Address(RVA = "0x1CAFB80", Offset = "0x1CAED80", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000073")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externBeginRenderOverlays(Action<Int32> value) { }

	[Address(RVA = "0x1CAFBE0", Offset = "0x1CAEDE0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000077")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externEndRenderOverlays(Action<Int32> value) { }

	[Address(RVA = "0x1CAFC40", Offset = "0x1CAEE40", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000075")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void set_externRenderOverlaysBefore(Action<Int32, Int32> value) { }

	[Address(RVA = "0x1CAFCF0", Offset = "0x1CAEEF0", Length = "0x86")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetupTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000068")]
	public void set_overrideSorting(bool value) { }

	[Address(RVA = "0x1CAFCA0", Offset = "0x1CAEEA0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008C")]
	private static void set_overrideSorting_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1CAFDD0", Offset = "0x1CAEFD0", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetReferencePixelsPerUnit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000064")]
	public void set_referencePixelsPerUnit(float value) { }

	[Address(RVA = "0x1CAFD80", Offset = "0x1CAEF80", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000088")]
	private static void set_referencePixelsPerUnit_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x1CAFEB0", Offset = "0x1CAF0B0", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleWorldCanvas", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPixelSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleConstantPhysicalSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "SetScaleFactor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000062")]
	public void set_scaleFactor(float value) { }

	[Address(RVA = "0x1CAFE60", Offset = "0x1CAF060", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000086")]
	private static void set_scaleFactor_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x1CAFF80", Offset = "0x1CAF180", Length = "0x83")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "Show", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006D")]
	public void set_sortingLayerID(int value) { }

	[Address(RVA = "0x1CAFF40", Offset = "0x1CAF140", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000091")]
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x1CB0050", Offset = "0x1CAF250", Length = "0x83")]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "SetupTemplate", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006A")]
	public void set_sortingOrder(int value) { }

	[Address(RVA = "0x1CB0010", Offset = "0x1CAF210", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008E")]
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x1CAEBD0", Offset = "0x1CADDD0", Length = "0x33")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RegisterCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "UnityEngine.UIElements.IPanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RemoveCachedPanelInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("UI::CanvasManager::SetExternalCanvasEnabled")]
	[Token(Token = "0x6000078")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void SetExternalCanvasEnabled(bool enabled) { }

}

