namespace RLD;

[Token(Token = "0x2000047")]
public abstract class GizmoDragSession : IGizmoDragSession
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000128")]
	private List<GizmoTransform> _targetTransforms; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000129")]
	protected Vector3 _totalDragOffset; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400012A")]
	protected Quaternion _totalDragRotation; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400012B")]
	protected Vector3 _totalDragScale; //Field offset: 0x34
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400012C")]
	protected Vector3 _relativeDragOffset; //Field offset: 0x40
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400012D")]
	protected Quaternion _relativeDragRotation; //Field offset: 0x4C
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400012E")]
	protected Vector3 _relativeDragScale; //Field offset: 0x5C

	[Token(Token = "0x17000099")]
	public abstract GizmoDragChannel DragChannel
	{
		[Token(Token = "0x600021B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000098")]
	public abstract bool IsActive
	{
		[Token(Token = "0x600021A")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000091")]
	public int NumTargetTransforms
	{
		[Address(RVA = "0x3B9150", Offset = "0x3B8350", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000213")]
		 get { } //Length: 60
	}

	[Token(Token = "0x17000095")]
	public override Vector3 RelativeDragOffset
	{
		[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000217")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000096")]
	public override Quaternion RelativeDragRotation
	{
		[Address(RVA = "0x3B91B0", Offset = "0x3B83B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000218")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000097")]
	public override Vector3 RelativeDragScale
	{
		[Address(RVA = "0x3B91C0", Offset = "0x3B83C0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000219")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000092")]
	public override Vector3 TotalDragOffset
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000214")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000093")]
	public override Quaternion TotalDragRotation
	{
		[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000215")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000094")]
	public override Vector3 TotalDragScale
	{
		[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000216")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x3B9060", Offset = "0x3B8260", Length = "0xE2")]
	[CalledBy(Type = typeof(GizmoSglAxisOffsetDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoDblAxisOffsetDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoDblAxisRotationDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoDblAxisScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoScreenDrag), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSglAxisRotationDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSglAxisScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoUniformScaleDrag3D), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600022A")]
	protected GizmoDragSession() { }

	[Address(RVA = "0x3B8890", Offset = "0x3B7A90", Length = "0xA5")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "AddTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 44)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021D")]
	public override void AddTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x3B8940", Offset = "0x3B7B40", Length = "0x427")]
	[CalledBy(Type = typeof(GizmoDragSession), Member = "Update", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoTransform), Member = "FilterParentsOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<RLD.GizmoTransform>)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.GizmoTransform>))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000226")]
	protected void ApplyDrag() { }

	[Address(RVA = "0x3B8D70", Offset = "0x3B7F70", Length = "0x60")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600021F")]
	public override bool Begin() { }

	[Token(Token = "0x6000225")]
	protected abstract void CalculateDragValues() { }

	[Address(RVA = "0x3B8DD0", Offset = "0x3B7FD0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000227")]
	protected override bool CanBegin() { }

	[Address(RVA = "0x3B8E00", Offset = "0x3B8000", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600021C")]
	public override bool ContainsTargetTransform(GizmoTransform transform) { }

	[Token(Token = "0x6000222")]
	protected abstract bool DoBeginSession() { }

	[Token(Token = "0x6000224")]
	protected abstract void DoEndSession() { }

	[Token(Token = "0x6000223")]
	protected abstract bool DoUpdateSession() { }

	[Address(RVA = "0x3B8E60", Offset = "0x3B8060", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000221")]
	public override void End() { }

	[Token(Token = "0x600021B")]
	public abstract GizmoDragChannel get_DragChannel() { }

	[Token(Token = "0x600021A")]
	public abstract bool get_IsActive() { }

	[Address(RVA = "0x3B9150", Offset = "0x3B8350", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000213")]
	public int get_NumTargetTransforms() { }

	[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000217")]
	public override Vector3 get_RelativeDragOffset() { }

	[Address(RVA = "0x3B91B0", Offset = "0x3B83B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000218")]
	public override Quaternion get_RelativeDragRotation() { }

	[Address(RVA = "0x3B91C0", Offset = "0x3B83C0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000219")]
	public override Vector3 get_RelativeDragScale() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000214")]
	public override Vector3 get_TotalDragOffset() { }

	[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000215")]
	public override Quaternion get_TotalDragRotation() { }

	[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000216")]
	public override Vector3 get_TotalDragScale() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000228")]
	protected override void OnSessionBegin() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000229")]
	protected override void OnSessionEnd() { }

	[Address(RVA = "0x3B8F80", Offset = "0x3B8180", Length = "0x6E")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "RemoveTargetTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(GizmoDragChannel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600021E")]
	public override void RemoveTargetTransform(GizmoTransform transform) { }

	[Address(RVA = "0x3B8FF0", Offset = "0x3B81F0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GizmoDragSession), Member = "ApplyDrag", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000220")]
	public override bool Update() { }

}

