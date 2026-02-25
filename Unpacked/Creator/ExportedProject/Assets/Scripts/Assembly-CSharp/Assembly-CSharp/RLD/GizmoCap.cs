namespace RLD;

[Token(Token = "0x2000029")]
public abstract class GizmoCap : IGizmoCap
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400009F")]
	private Gizmo _gizmo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000A0")]
	private GizmoHandle _handle; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000A1")]
	private bool _isVisible; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40000A2")]
	private bool _isHoverable; //Field offset: 0x21

	[Token(Token = "0x1700004C")]
	public override Priority GenericHoverPriority
	{
		[Address(RVA = "0x3B6AB0", Offset = "0x3B5CB0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000150")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000045")]
	public override Gizmo Gizmo
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000149")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000044")]
	protected GizmoHandle Handle
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000148")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000046")]
	public override int HandleId
	{
		[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600014A")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700004B")]
	public override Priority HoverPriority2D
	{
		[Address(RVA = "0x3B6AF0", Offset = "0x3B5CF0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600014F")]
		 get { } //Length: 27
	}

	[Token(Token = "0x1700004A")]
	public override Priority HoverPriority3D
	{
		[Address(RVA = "0x3B6B10", Offset = "0x3B5D10", Length = "0x1B")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600014E")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000048")]
	public bool IsHoverable
	{
		[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014C")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000049")]
	public bool IsHovered
	{
		[Address(RVA = "0x3B6B30", Offset = "0x3B5D30", Length = "0x33")]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateColor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600014D")]
		 get { } //Length: 51
	}

	[Token(Token = "0x17000047")]
	public bool IsVisible
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600014B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3B6A40", Offset = "0x3B5C40", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Gizmo), Member = "CreateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GizmoHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000151")]
	public GizmoCap(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x3B6AB0", Offset = "0x3B5CB0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000150")]
	public override Priority get_GenericHoverPriority() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000149")]
	public override Gizmo get_Gizmo() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000148")]
	protected GizmoHandle get_Handle() { }

	[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600014A")]
	public override int get_HandleId() { }

	[Address(RVA = "0x3B6AF0", Offset = "0x3B5CF0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600014F")]
	public override Priority get_HoverPriority2D() { }

	[Address(RVA = "0x3B6B10", Offset = "0x3B5D10", Length = "0x1B")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600014E")]
	public override Priority get_HoverPriority3D() { }

	[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014C")]
	public bool get_IsHoverable() { }

	[Address(RVA = "0x3B6B30", Offset = "0x3B5D30", Length = "0x33")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateColor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600014D")]
	public bool get_IsHovered() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600014B")]
	public bool get_IsVisible() { }

	[Token(Token = "0x6000156")]
	protected abstract void OnHoverableStateChanged() { }

	[Token(Token = "0x6000155")]
	protected abstract void OnVisibilityStateChanged() { }

	[Token(Token = "0x6000154")]
	public abstract void Render(Camera camera) { }

	[Address(RVA = "0x3B6A00", Offset = "0x3B5C00", Length = "0x1D")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateHoverPermission", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoCap), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "Set2DCapHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "Set3DCapHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "SetMidCapHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetRtMidCapHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000153")]
	public override void SetHoverable(bool isHoverable) { }

	[Address(RVA = "0x3B6A20", Offset = "0x3B5C20", Length = "0x1D")]
	[CallerCount(Count = 43)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000152")]
	public override void SetVisible(bool isVisible) { }

}

