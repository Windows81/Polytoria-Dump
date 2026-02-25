namespace SoftMasking;

[AddComponentMenu(null)]
[ExecuteInEditMode]
[Token(Token = "0x200001E")]
public class SoftMaskable : UIBehaviour, IMaterialModifier
{
	[Token(Token = "0x4000076")]
	private static List<ISoftMask> s_softMasks; //Field offset: 0x0
	[Token(Token = "0x4000077")]
	private static List<Canvas> s_canvases; //Field offset: 0x8
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000070")]
	private ISoftMask _mask; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000071")]
	private Graphic _graphic; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000072")]
	private Material _replacement; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000073")]
	private bool _affectedByMask; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000074")]
	private bool _destroyed; //Field offset: 0x39
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3A")]
	[Token(Token = "0x4000075")]
	private bool <shaderIsNotSupported>k__BackingField; //Field offset: 0x3A

	[Token(Token = "0x17000025")]
	private Graphic graphic
	{
		[Address(RVA = "0x1569950", Offset = "0x1568B50", Length = "0x9B")]
		[CalledBy(Type = typeof(SoftMaskable), Member = "get_isMaskingEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "Invalidate", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "get_isGraphicMaskable", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "SetShaderNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60000C1")]
		private get { } //Length: 155
	}

	[Token(Token = "0x17000024")]
	public bool isDestroyed
	{
		[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B5")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000026")]
	private bool isGraphicMaskable
	{
		[Address(RVA = "0x15699F0", Offset = "0x1568BF0", Length = "0x10F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000C2")]
		private get { } //Length: 271
	}

	[Token(Token = "0x17000022")]
	public bool isMaskingEnabled
	{
		[Address(RVA = "0x1569B00", Offset = "0x1568D00", Length = "0x188")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000B2")]
		 get { } //Length: 392
	}

	[Token(Token = "0x17000023")]
	public private ISoftMask mask
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B3")]
		 get { } //Length: 5
		[Address(RVA = "0x1569C90", Offset = "0x1568E90", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SoftMaskable), Member = "set_replacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SoftMaskable), Member = "Invalidate", ReturnType = typeof(void))]
		[Token(Token = "0x60000B4")]
		private set { } //Length: 135
	}

	[Token(Token = "0x17000027")]
	private Material replacement
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C3")]
		private get { } //Length: 95
		[Address(RVA = "0x1569D20", Offset = "0x1568F20", Length = "0x149")]
		[CalledBy(Type = typeof(SoftMaskable), Member = "set_mask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISoftMask)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "OnDisable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SoftMaskable), Member = "FindMaskOrDie", ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000C4")]
		private set { } //Length: 329
	}

	[Token(Token = "0x17000021")]
	public private bool shaderIsNotSupported
	{
		[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B0")]
		 get { } //Length: 5
		[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000B1")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x1569860", Offset = "0x1568A60", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000CD")]
	private static SoftMaskable() { }

	[Address(RVA = "0x3B01C0", Offset = "0x3AF3C0", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CC")]
	public SoftMaskable() { }

	[Address(RVA = "0x15689E0", Offset = "0x1567BE0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000B9")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1568A10", Offset = "0x1567C10", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000C7")]
	private void DestroySelf() { }

	[Address(RVA = "0x1568AB0", Offset = "0x1567CB0", Length = "0x1BA")]
	[CalledBy(Type = "SoftMasking.SoftMask+<>c", Member = "<NotifyChildrenThatMaskMightChanged>b__102_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMaskable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "MaskMightChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMaskable), Member = "Invalidate", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SoftMaskable), Member = "NearestMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(ISoftMask))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMaskable), Member = "set_replacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000C5")]
	private bool FindMaskOrDie() { }

	[Address(RVA = "0x1569950", Offset = "0x1568B50", Length = "0x9B")]
	[CalledBy(Type = typeof(SoftMaskable), Member = "get_isMaskingEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "Invalidate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "get_isGraphicMaskable", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "SetShaderNotSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000C1")]
	private Graphic get_graphic() { }

	[Address(RVA = "0x53B940", Offset = "0x53AB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B5")]
	public bool get_isDestroyed() { }

	[Address(RVA = "0x15699F0", Offset = "0x1568BF0", Length = "0x10F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C2")]
	private bool get_isGraphicMaskable() { }

	[Address(RVA = "0x1569B00", Offset = "0x1568D00", Length = "0x188")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B2")]
	public bool get_isMaskingEnabled() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B3")]
	public ISoftMask get_mask() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C3")]
	private Material get_replacement() { }

	[Address(RVA = "0x53B950", Offset = "0x53AB50", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B0")]
	public bool get_shaderIsNotSupported() { }

	[Address(RVA = "0x75C580", Offset = "0x75B780", Length = "0xF8")]
	[CalledBy(Type = typeof(SoftMaskable), Member = "NearestMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(ISoftMask))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "GetISoftMask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(ISoftMask))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "IsOverridingSortingCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ClearListAtExit`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CA")]
	private static T GetComponent(Component component, List<T> cachedList) { }

	[Address(RVA = "0x1568C70", Offset = "0x1567E70", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SoftMaskable), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), "System.Collections.Generic.List`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Token(Token = "0x60000C8")]
	private static ISoftMask GetISoftMask(Transform current, bool shouldBeEnabled = true) { }

	[Address(RVA = "0x1568D50", Offset = "0x1567F50", Length = "0x3DA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "get_shader", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(SoftMaskable), Member = "set_replacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Canvas), Member = "GetDefaultCanvasMaterial", ReturnType = typeof(Material))]
	[Token(Token = "0x60000B6")]
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	[Address(RVA = "0x1569130", Offset = "0x1568330", Length = "0x8F")]
	[CalledBy(Type = "SoftMasking.SoftMask+<>c", Member = "<InvalidateChildren>b__101_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMaskable)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask+<>c", Member = "<NotifyChildrenThatMaskMightChanged>b__102_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SoftMaskable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "set_mask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISoftMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "MaskMightChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "FindMaskOrDie", ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B7")]
	public void Invalidate() { }

	[Address(RVA = "0x15691C0", Offset = "0x15683C0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SoftMaskable), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), "System.Collections.Generic.List`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C9")]
	private static bool IsOverridingSortingCanvas(Transform transform) { }

	[Address(RVA = "0x1569290", Offset = "0x1568490", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMaskable), Member = "FindMaskOrDie", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMaskable), Member = "Invalidate", ReturnType = typeof(void))]
	[Token(Token = "0x60000B8")]
	public void MaskMightChanged() { }

	[Address(RVA = "0x15692C0", Offset = "0x15684C0", Length = "0x26B")]
	[CalledBy(Type = typeof(SoftMaskable), Member = "FindMaskOrDie", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SoftMaskable), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Component), "System.Collections.Generic.List`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Canvas), Member = "get_overrideSorting", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000C6")]
	private static ISoftMask NearestMask(Transform transform, out bool processedByThisMask, bool enabledOnly = true) { }

	[Address(RVA = "0x1569530", Offset = "0x1568730", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMaskable), Member = "FindMaskOrDie", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BE")]
	protected virtual void OnCanvasHierarchyChanged() { }

	[Address(RVA = "0x1569550", Offset = "0x1568750", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000BC")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x1569570", Offset = "0x1568770", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMaskable), Member = "set_replacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SoftMaskable), Member = "Invalidate", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000BB")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x15695E0", Offset = "0x15687E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMaskable), Member = "FindMaskOrDie", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60000BA")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1569620", Offset = "0x1568820", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMaskable), Member = "RequestChildTransformUpdate", ReturnType = typeof(void))]
	[Token(Token = "0x60000BF")]
	private void OnTransformChildrenChanged() { }

	[Address(RVA = "0x1569530", Offset = "0x1568730", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SoftMaskable), Member = "FindMaskOrDie", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BD")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x1569630", Offset = "0x1568830", Length = "0xC0")]
	[CalledBy(Type = typeof(SoftMaskable), Member = "OnTransformChildrenChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C0")]
	private void RequestChildTransformUpdate() { }

	[Address(RVA = "0x1569C90", Offset = "0x1568E90", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SoftMaskable), Member = "set_replacement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SoftMaskable), Member = "Invalidate", ReturnType = typeof(void))]
	[Token(Token = "0x60000B4")]
	private void set_mask(ISoftMask value) { }

	[Address(RVA = "0x1569D20", Offset = "0x1568F20", Length = "0x149")]
	[CalledBy(Type = typeof(SoftMaskable), Member = "set_mask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ISoftMask)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "GetModifiedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SoftMaskable), Member = "FindMaskOrDie", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C4")]
	private void set_replacement(Material value) { }

	[Address(RVA = "0x53B990", Offset = "0x53AB90", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B1")]
	private void set_shaderIsNotSupported(bool value) { }

	[Address(RVA = "0x15696F0", Offset = "0x15688F0", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SoftMaskable), Member = "get_graphic", ReturnType = typeof(Graphic))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000CB")]
	private void SetShaderNotSupported(Material material) { }

}

