namespace UnityEngine;

[NativeClass("UI::CanvasRenderer")]
[NativeHeader("Modules/UI/CanvasRenderer.h")]
[Token(Token = "0x2000004")]
public sealed class CanvasRenderer : Component
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000001")]
	private bool <isMask>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000008")]
	public int absoluteDepth
	{
		[Address(RVA = "0x1CADFC0", Offset = "0x1CAD1C0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_depth", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster+<>c", Member = "<Raycast>b__27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Graphic", "UnityEngine.UI.Graphic"}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000016")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000C")]
	public Vector2 clippingSoftness
	{
		[Address(RVA = "0x1CAE390", Offset = "0x1CAD590", Length = "0x80")]
		[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "SetClipSoftness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600001F")]
		 set { } //Length: 128
	}

	[NativeProperty("ShouldCull", False, TargetType::Function (0))]
	[Token(Token = "0x1700000B")]
	public bool cull
	{
		[Address(RVA = "0x1CAE140", Offset = "0x1CAD340", Length = "0x76")]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateCulling", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "OnCullingChanged", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.CanvasUpdate"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600001A")]
		 get { } //Length: 118
		[Address(RVA = "0x1CAE550", Offset = "0x1CAD750", Length = "0x86")]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateCulling", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SelectionCaret", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600001B")]
		 set { } //Length: 134
	}

	[Token(Token = "0x1700000A")]
	public bool cullTransparentMesh
	{
		[Address(RVA = "0x1CAE080", Offset = "0x1CAD280", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000018")]
		 get { } //Length: 118
		[Address(RVA = "0x1CAE470", Offset = "0x1CAD670", Length = "0x86")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000019")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000009")]
	public bool hasMoved
	{
		[Address(RVA = "0x1CAE200", Offset = "0x1CAD400", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000017")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000005")]
	public bool hasPopInstruction
	{
		[Address(RVA = "0x1CAE630", Offset = "0x1CAD830", Length = "0x86")]
		[CalledBy(Type = "UnityEngine.UI.Mask", Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Mask", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Mask", Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000012")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000006")]
	public int materialCount
	{
		[Address(RVA = "0x1CAE2C0", Offset = "0x1CAD4C0", Length = "0x76")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000013")]
		 get { } //Length: 118
		[Address(RVA = "0x1CAE700", Offset = "0x1CAD900", Length = "0x83")]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000014")]
		 set { } //Length: 131
	}

	[Token(Token = "0x17000007")]
	public int popMaterialCount
	{
		[Address(RVA = "0x1CAE7D0", Offset = "0x1CAD9D0", Length = "0x83")]
		[CalledBy(Type = "UnityEngine.UI.Mask", Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Mask", Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000015")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	public CanvasRenderer() { }

	[Address(RVA = "0x1CACCB0", Offset = "0x1CABEB0", Length = "0x62")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[Address(RVA = "0x1CACD60", Offset = "0x1CABF60", Length = "0x76")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000029")]
	public void Clear() { }

	[Address(RVA = "0x1CACD20", Offset = "0x1CABF20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	private static void Clear_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CACDE0", Offset = "0x1CABFE0", Length = "0x62")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[Address(RVA = "0x1CACDE0", Offset = "0x1CABFE0", Length = "0x62")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000031")]
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	[Address(RVA = "0x1CACE90", Offset = "0x1CAC090", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "SetClipRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	public void DisableRectClipping() { }

	[Address(RVA = "0x1CACE50", Offset = "0x1CAC050", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000041")]
	private static void DisableRectClipping_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CACF60", Offset = "0x1CAC160", Length = "0x85")]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "SetClipRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001E")]
	public void EnableRectClipping(Rect rect) { }

	[Address(RVA = "0x1CACF10", Offset = "0x1CAC110", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003F")]
	private static void EnableRectClipping_Injected(IntPtr _unity_self, in Rect rect) { }

	[Address(RVA = "0x1CADFC0", Offset = "0x1CAD1C0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_depth", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster+<>c", Member = "<Raycast>b__27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Graphic", "UnityEngine.UI.Graphic"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	public int get_absoluteDepth() { }

	[Address(RVA = "0x1CADF80", Offset = "0x1CAD180", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000037")]
	private static int get_absoluteDepth_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAE140", Offset = "0x1CAD340", Length = "0x76")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateCulling", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "OnCullingChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.CanvasUpdate"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Canvas), typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001A")]
	public bool get_cull() { }

	[Address(RVA = "0x1CAE100", Offset = "0x1CAD300", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003B")]
	private static bool get_cull_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAE080", Offset = "0x1CAD280", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000018")]
	public bool get_cullTransparentMesh() { }

	[Address(RVA = "0x1CAE040", Offset = "0x1CAD240", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	private static bool get_cullTransparentMesh_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAE200", Offset = "0x1CAD400", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "PerformClipping", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000017")]
	public bool get_hasMoved() { }

	[Address(RVA = "0x1CAE1C0", Offset = "0x1CAD3C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	private static bool get_hasMoved_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAE2C0", Offset = "0x1CAD4C0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public int get_materialCount() { }

	[Address(RVA = "0x1CAE280", Offset = "0x1CAD480", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000034")]
	private static int get_materialCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1CAD040", Offset = "0x1CAC240", Length = "0x8E")]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "CrossFadeColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(float), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Toggle", Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	public Color GetColor() { }

	[Address(RVA = "0x1CACFF0", Offset = "0x1CAC1F0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003E")]
	private static void GetColor_Injected(IntPtr _unity_self, out Color ret) { }

	[Address(RVA = "0x1CAD1B0", Offset = "0x1CAC3B0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	public Material GetMaterial(int index) { }

	[Address(RVA = "0x1CAD110", Offset = "0x1CAC310", Length = "0x92")]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "GetSharedMaterial", ReturnType = typeof(Material))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = "UnityEngine.Bindings.Unmarshal", Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	public Material GetMaterial() { }

	[Address(RVA = "0x1CAD0D0", Offset = "0x1CAC2D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000043")]
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x1CAE390", Offset = "0x1CAD590", Length = "0x80")]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "SetClipSoftness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001F")]
	public void set_clippingSoftness(Vector2 value) { }

	[Address(RVA = "0x1CAE340", Offset = "0x1CAD540", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000040")]
	private static void set_clippingSoftness_Injected(IntPtr _unity_self, in Vector2 value) { }

	[Address(RVA = "0x1CAE550", Offset = "0x1CAD750", Length = "0x86")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateCulling", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SelectionCaret", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "UpdateCull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001B")]
	public void set_cull(bool value) { }

	[Address(RVA = "0x1CAE500", Offset = "0x1CAD700", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	private static void set_cull_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1CAE470", Offset = "0x1CAD670", Length = "0x86")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	public void set_cullTransparentMesh(bool value) { }

	[Address(RVA = "0x1CAE420", Offset = "0x1CAD620", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003A")]
	private static void set_cullTransparentMesh_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1CAE630", Offset = "0x1CAD830", Length = "0x86")]
	[CalledBy(Type = "UnityEngine.UI.Mask", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Mask", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Mask", Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000012")]
	public void set_hasPopInstruction(bool value) { }

	[Address(RVA = "0x1CAE5E0", Offset = "0x1CAD7E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	private static void set_hasPopInstruction_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x1CAE700", Offset = "0x1CAD900", Length = "0x83")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000014")]
	public void set_materialCount(int value) { }

	[Address(RVA = "0x1CAE6C0", Offset = "0x1CAD8C0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000035")]
	private static void set_materialCount_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x1CAE7D0", Offset = "0x1CAD9D0", Length = "0x83")]
	[CalledBy(Type = "UnityEngine.UI.Mask", Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Mask", Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000015")]
	public void set_popMaterialCount(int value) { }

	[Address(RVA = "0x1CAE790", Offset = "0x1CAD990", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000036")]
	private static void set_popMaterialCount_Injected(IntPtr _unity_self, int value) { }

	[Address(RVA = "0x1CAD2A0", Offset = "0x1CAC4A0", Length = "0xBA")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	public void SetAlphaTexture(Texture texture) { }

	[Address(RVA = "0x1CAD250", Offset = "0x1CAC450", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000048")]
	private static void SetAlphaTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	[Address(RVA = "0x1CAD3B0", Offset = "0x1CAC5B0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001C")]
	public void SetColor(Color color) { }

	[Address(RVA = "0x1CAD360", Offset = "0x1CAC560", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003D")]
	private static void SetColor_Injected(IntPtr _unity_self, in Color color) { }

	[Address(RVA = "0x1CAD4A0", Offset = "0x1CAC6A0", Length = "0x243")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "EnableMasking", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetOutlineThickness", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600002A")]
	public void SetMaterial(Material material, Texture texture) { }

	[Address(RVA = "0x1CAD6F0", Offset = "0x1CAC8F0", Length = "0xD0")]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SubMeshUI", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	public void SetMaterial(Material material, int index) { }

	[Address(RVA = "0x1CAD440", Offset = "0x1CAC640", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	[Address(RVA = "0x1CAD820", Offset = "0x1CACA20", Length = "0xBA")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "DoLegacyMeshGeneration", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "DoMeshGeneration", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "Rebuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.CanvasUpdate"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetMeshArrays", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TMPro.TMP_VertexDataUpdateFlags"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateGeometry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "ClearMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	public void SetMesh(Mesh mesh) { }

	[Address(RVA = "0x1CAD7D0", Offset = "0x1CAC9D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000049")]
	private static void SetMesh_Injected(IntPtr _unity_self, IntPtr mesh) { }

	[Address(RVA = "0x1CAD940", Offset = "0x1CACB40", Length = "0xD0")]
	[CalledBy(Type = "UnityEngine.UI.Mask", Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000023")]
	public void SetPopMaterial(Material material, int index) { }

	[Address(RVA = "0x1CAD8E0", Offset = "0x1CACAE0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000044")]
	private static void SetPopMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	[Address(RVA = "0x1CADB50", Offset = "0x1CACD50", Length = "0x1F1")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "SetSecondaryTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasRenderer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	public void SetSecondaryTexture(int index, string name, Texture2D texture) { }

	[Address(RVA = "0x1CADAF0", Offset = "0x1CACCF0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000047")]
	private static void SetSecondaryTexture_Injected(IntPtr _unity_self, int index, ref ManagedSpanWrapper name, IntPtr texture) { }

	[Address(RVA = "0x1CADA60", Offset = "0x1CACC60", Length = "0x83")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "SetSecondaryTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CanvasRenderer)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	public void SetSecondaryTextureCount(int size) { }

	[Address(RVA = "0x1CADA20", Offset = "0x1CACC20", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	private static void SetSecondaryTextureCount_Injected(IntPtr _unity_self, int size) { }

	[Address(RVA = "0x1CADDA0", Offset = "0x1CACFA0", Length = "0xBA")]
	[CalledBy(Type = "UnityEngine.UI.Graphic", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000024")]
	public void SetTexture(Texture texture) { }

	[Address(RVA = "0x1CADD50", Offset = "0x1CACF50", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000045")]
	private static void SetTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	[Address(RVA = "0x1CADE60", Offset = "0x1CAD060", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x600002F")]
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[Address(RVA = "0x1CADEB0", Offset = "0x1CAD0B0", Length = "0xCF")]
	[CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "AddUIVertexTriangleStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<UIVertex>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Outline", Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600002C")]
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[Address(RVA = "0x1CACCB0", Offset = "0x1CABEB0", Length = "0x62")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	[Token(Token = "0x6000030")]
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

}

