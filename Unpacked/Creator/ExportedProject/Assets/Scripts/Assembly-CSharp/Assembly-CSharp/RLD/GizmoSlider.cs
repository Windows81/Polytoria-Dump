namespace RLD;

[Token(Token = "0x20000FE")]
public abstract class GizmoSlider : IGizmoSlider
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000421")]
	private GizmoHandle _handle; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000422")]
	private Gizmo _gizmo; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000423")]
	private bool _isVisible; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x4000424")]
	private bool _isHoverable; //Field offset: 0x21

	[Token(Token = "0x170002E3")]
	public override Priority GenericHoverPriority
	{
		[Address(RVA = "0x4A2FD0", Offset = "0x4A21D0", Length = "0x1B")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600092F")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170002DC")]
	public override Gizmo Gizmo
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000928")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002DB")]
	protected GizmoHandle Handle
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000927")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002DD")]
	public override int HandleId
	{
		[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000929")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170002E2")]
	public override Priority HoverPriority2D
	{
		[Address(RVA = "0x308F00", Offset = "0x308100", Length = "0x1B")]
		[CallerCount(Count = 54)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600092E")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170002E1")]
	public override Priority HoverPriority3D
	{
		[Address(RVA = "0x513D50", Offset = "0x512F50", Length = "0x1B")]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600092D")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170002DF")]
	public bool IsHoverable
	{
		[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600092B")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002E0")]
	public bool IsHovered
	{
		[Address(RVA = "0x513D70", Offset = "0x512F70", Length = "0x33")]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600092C")]
		 get { } //Length: 51
	}

	[Token(Token = "0x170002DE")]
	public bool IsVisible
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600092A")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x513CC0", Offset = "0x512EC0", Length = "0x6C")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Gizmo), Member = "CreateHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GizmoHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000930")]
	public GizmoSlider(Gizmo gizmo, int handleId) { }

	[Address(RVA = "0x4A2FD0", Offset = "0x4A21D0", Length = "0x1B")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600092F")]
	public override Priority get_GenericHoverPriority() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000928")]
	public override Gizmo get_Gizmo() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000927")]
	protected GizmoHandle get_Handle() { }

	[Address(RVA = "0x513D30", Offset = "0x512F30", Length = "0x1A")]
	[CallerCount(Count = 83)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000929")]
	public override int get_HandleId() { }

	[Address(RVA = "0x308F00", Offset = "0x308100", Length = "0x1B")]
	[CallerCount(Count = 54)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600092E")]
	public override Priority get_HoverPriority2D() { }

	[Address(RVA = "0x513D50", Offset = "0x512F50", Length = "0x1B")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoPreUpdateBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Make3DHoverPriorityLowerThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "Make3DHoverPriorityHigherThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Priority)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600092D")]
	public override Priority get_HoverPriority3D() { }

	[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600092B")]
	public bool get_IsHoverable() { }

	[Address(RVA = "0x513D70", Offset = "0x512F70", Length = "0x33")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600092C")]
	public bool get_IsHovered() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600092A")]
	public bool get_IsVisible() { }

	[Token(Token = "0x6000936")]
	protected abstract void OnHoverableStateChanged() { }

	[Token(Token = "0x6000935")]
	protected abstract void OnVisibilityStateChanged() { }

	[Token(Token = "0x6000934")]
	public abstract void Render(Camera camera) { }

	[Address(RVA = "0x513C80", Offset = "0x512E80", Length = "0x17")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "SetAxesLinesHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "SetMvAxesLinesHoverable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000932")]
	public override void SetHoverable(bool isHoverable) { }

	[Token(Token = "0x6000933")]
	public abstract void SetSnapEnabled(bool isEnabled) { }

	[Address(RVA = "0x513CA0", Offset = "0x512EA0", Length = "0x17")]
	[CalledBy(Type = typeof(GizmoLineSlider2DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3DCollection), Member = "SetVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScaleGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Set2DModeEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnGizmoUpdateBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Hide2DModeHandles", ReturnType = typeof(void))]
	[CallerCount(Count = 35)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000931")]
	public override void SetVisible(bool isVisible) { }

}

