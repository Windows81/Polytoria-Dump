namespace RLD;

[Token(Token = "0x200003A")]
public class GizmoTransform
{
	[Token(Token = "0x200003C")]
	internal struct ChangeData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000EE")]
		public ChangeReason ChangeReason; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40000EF")]
		public GizmoDimension TRSDimension; //Field offset: 0x4

		[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
		[CallerCount(Count = 47)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DA")]
		public ChangeData(ChangeReason changeReason, GizmoDimension trsDimension) { }

	}

	[Token(Token = "0x200003B")]
	internal enum ChangeReason
	{
		TRSChange = 0,
		ParentChange = 1,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000DA")]
	private GizmoEntityTransformChangedHandler Changed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000DB")]
	private bool _firingChanged3DEvent; //Field offset: 0x18
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40000DC")]
	private bool _firingChanged2DEvent; //Field offset: 0x19
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40000DD")]
	private Vector3 _position3D; //Field offset: 0x1C
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000DE")]
	private Vector3 _localPosition3D; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000DF")]
	private Quaternion _rotation3D; //Field offset: 0x34
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40000E0")]
	private Quaternion _localRotation3D; //Field offset: 0x44
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40000E1")]
	private Vector2 _position2D; //Field offset: 0x54
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40000E2")]
	private Vector2 _localPosition2D; //Field offset: 0x5C
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40000E3")]
	private float _rotation2DDegrees; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40000E4")]
	private Quaternion _rotation2D; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40000E5")]
	private float _localRotation2DDegrees; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x40000E6")]
	private Quaternion _localRotation2D; //Field offset: 0x7C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40000E7")]
	private Vector3[] _axes3D; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40000E8")]
	private Vector2[] _axes2D; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40000E9")]
	private GizmoTransform _parent; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40000EA")]
	private List<GizmoTransform> _children; //Field offset: 0xA8

	[Token(Token = "0x14000001")]
	public event GizmoEntityTransformChangedHandler Changed
	{
		[Address(RVA = "0x3C1900", Offset = "0x3C0B00", Length = "0x9E")]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CompilerGenerated]
		[Token(Token = "0x6000188")]
		 add { } //Length: 158
		[Address(RVA = "0x3C1C50", Offset = "0x3C0E50", Length = "0x9E")]
		[CalledBy(Type = typeof(MoveGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RotationGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnDetached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CompilerGenerated]
		[Token(Token = "0x6000189")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000064")]
	public bool CanChange2D
	{
		[Address(RVA = "0x3C19A0", Offset = "0x3C0BA0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600018B")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000063")]
	public bool CanChange3D
	{
		[Address(RVA = "0x3C19B0", Offset = "0x3C0BB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600018A")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000067")]
	public List<GizmoTransform> Children
	{
		[Address(RVA = "0x3C19C0", Offset = "0x3C0BC0", Length = "0x6B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
		[Token(Token = "0x600018E")]
		 get { } //Length: 107
	}

	[Token(Token = "0x17000073")]
	public Vector2 LocalPosition2D
	{
		[Address(RVA = "0x3C1A30", Offset = "0x3C0C30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600019F")]
		 get { } //Length: 19
		[Address(RVA = "0x3C1CF0", Offset = "0x3C0EF0", Length = "0x17C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001A0")]
		 set { } //Length: 380
	}

	[Token(Token = "0x17000072")]
	public Vector3 LocalPosition3D
	{
		[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600019D")]
		 get { } //Length: 19
		[Address(RVA = "0x3C1E70", Offset = "0x3C1070", Length = "0x18B")]
		[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600019E")]
		 set { } //Length: 395
	}

	[Token(Token = "0x17000075")]
	public Quaternion LocalRotation2D
	{
		[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A3")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000076")]
	public float LocalRotation2DDegrees
	{
		[Address(RVA = "0x3C1A70", Offset = "0x3C0C70", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A4")]
		 get { } //Length: 6
		[Address(RVA = "0x3C2000", Offset = "0x3C1200", Length = "0xB7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(GizmoTransform), Member = "OnLocalRotation2DChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001A5")]
		 set { } //Length: 183
	}

	[Token(Token = "0x17000074")]
	public Quaternion LocalRotation3D
	{
		[Address(RVA = "0x3C1A80", Offset = "0x3C0C80", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60001A1")]
		 get { } //Length: 11
		[Address(RVA = "0x3C20C0", Offset = "0x3C12C0", Length = "0x194")]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "set_LocalRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(GizmoTransform), Member = "OnLocalRotation3DChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001A2")]
		 set { } //Length: 404
	}

	[Token(Token = "0x1700006A")]
	public Vector3 Look3D
	{
		[Address(RVA = "0x3C1A90", Offset = "0x3C0C90", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000191")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000066")]
	public int NumChildren
	{
		[Address(RVA = "0x3C1AD0", Offset = "0x3C0CD0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600018D")]
		 get { } //Length: 63
	}

	[Token(Token = "0x17000065")]
	public GizmoTransform Parent
	{
		[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600018C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700006E")]
	public Vector2 Position2D
	{
		[Address(RVA = "0x3C1B10", Offset = "0x3C0D10", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000196")]
		 get { } //Length: 19
		[Address(RVA = "0x3C2260", Offset = "0x3C1460", Length = "0x196")]
		[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UniversalGizmo), Member = "Update2DGizmoPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MoveGizmo), Member = "Update2DGizmoPosition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "set_StartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap2D), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000197")]
		 set { } //Length: 406
	}

	[Token(Token = "0x1700006D")]
	public Vector3 Position3D
	{
		[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000194")]
		 get { } //Length: 19
		[Address(RVA = "0x3C2400", Offset = "0x3C1600", Length = "0x1C2")]
		[CallerCount(Count = 31)]
		[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000195")]
		 set { } //Length: 450
	}

	[Token(Token = "0x1700006B")]
	public Vector2 Right2D
	{
		[Address(RVA = "0x3C1B30", Offset = "0x3C0D30", Length = "0x38")]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000192")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000068")]
	public Vector3 Right3D
	{
		[Address(RVA = "0x3C1B70", Offset = "0x3C0D70", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600018F")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000070")]
	public Quaternion Rotation2D
	{
		[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600019A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000071")]
	public float Rotation2DDegrees
	{
		[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600019B")]
		 get { } //Length: 6
		[Address(RVA = "0x3C25D0", Offset = "0x3C17D0", Length = "0x1B")]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "set_RotationDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600019C")]
		 set { } //Length: 27
	}

	[Token(Token = "0x1700006F")]
	public Quaternion Rotation3D
	{
		[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000198")]
		 get { } //Length: 11
		[Address(RVA = "0x3C25F0", Offset = "0x3C17F0", Length = "0x194")]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "SetOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RefreshRotation", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "AlignToQuadrant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(PlaneQuadrantId), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(BoxGizmo), Member = "FitBoxToTargetHierarchy", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "SetAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CreatorController), Member = "PropertyGrid_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoTransform), Member = "Rotate3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "CapSlider3DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoCap3D), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoDragSession), Member = "ApplyDrag", ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(GizmoTransform), Member = "OnRotation3DChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000199")]
		 set { } //Length: 404
	}

	[Token(Token = "0x1700006C")]
	public Vector2 Up2D
	{
		[Address(RVA = "0x3C1BD0", Offset = "0x3C0DD0", Length = "0x38")]
		[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000193")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000069")]
	public Vector3 Up3D
	{
		[Address(RVA = "0x3C1C10", Offset = "0x3C0E10", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000190")]
		 get { } //Length: 56
	}

	[Address(RVA = "0x3C1740", Offset = "0x3C0940", Length = "0x1C0")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Gizmo), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "Update2DAxes", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GizmoTransform), Member = "Update3DAxes", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001A6")]
	public GizmoTransform() { }

	[Address(RVA = "0x3C1900", Offset = "0x3C0B00", Length = "0x9E")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnEnabled", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CompilerGenerated]
	[Token(Token = "0x6000188")]
	public void add_Changed(GizmoEntityTransformChangedHandler value) { }

	[Address(RVA = "0x3BD7C0", Offset = "0x3BC9C0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B7")]
	public void AlignAxis2D(int axisIndex, AxisSign axisSign, Vector2 axis) { }

	[Address(RVA = "0x3BD870", Offset = "0x3BCA70", Length = "0x2F4")]
	[CalledBy(Type = typeof(GizmoPyramidCap3DController), Member = "CapSlider3DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxCap3DController), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxCap3DController), Member = "CapSlider3DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = "AlignTransformAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoConeCap3DController), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoConeCap3DController), Member = "CapSlider3DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPyramidCap3DController), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSphereCap3DController), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoSphereCap3DController), Member = "CapSlider3DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "CapSlider3DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B6")]
	public void AlignAxis3D(int axisIndex, AxisSign axisSign, Vector3 axis) { }

	[Address(RVA = "0x3BDB70", Offset = "0x3BCD70", Length = "0x136")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001C8")]
	private void ChangeLocalPosition2D(Vector2 localPosition) { }

	[Address(RVA = "0x3BDCB0", Offset = "0x3BCEB0", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001C7")]
	private void ChangeLocalPosition3D(Vector3 localPosition) { }

	[Address(RVA = "0x3BDDD0", Offset = "0x3BCFD0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "OnLocalRotation2DChanged", ReturnType = typeof(void))]
	[Token(Token = "0x60001CB")]
	private void ChangeLocalRotation2D(Quaternion localRotation) { }

	[Address(RVA = "0x3BDE10", Offset = "0x3BD010", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "OnLocalRotation2DChanged", ReturnType = typeof(void))]
	[Token(Token = "0x60001CA")]
	private void ChangeLocalRotation2D(float localRotation) { }

	[Address(RVA = "0x3BDEB0", Offset = "0x3BD0B0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "OnLocalRotation3DChanged", ReturnType = typeof(void))]
	[Token(Token = "0x60001C9")]
	private void ChangeLocalRotation3D(Quaternion localRotation) { }

	[Address(RVA = "0x3BDEF0", Offset = "0x3BD0F0", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001C3")]
	private void ChangePosition2D(Vector2 position) { }

	[Address(RVA = "0x3BE050", Offset = "0x3BD250", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001C2")]
	private void ChangePosition3D(Vector3 position) { }

	[Address(RVA = "0x3BE1F0", Offset = "0x3BD3F0", Length = "0xAC")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "Rotate2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap2D), Member = "SetMappedAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap2D), Member = "SetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "AlignAxis2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "Rotate2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "set_Rotation2DDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2D), Member = "AlignTransformAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2D), Member = "set_RotationDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GizmoTransform), Member = "OnRotation2DChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E040")]
	[Token(Token = "0x60001C5")]
	private void ChangeRotation2D(float rotation) { }

	[Address(RVA = "0x3BE1B0", Offset = "0x3BD3B0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "OnRotation2DChanged", ReturnType = typeof(void))]
	[Token(Token = "0x60001C6")]
	private void ChangeRotation2D(Quaternion rotation) { }

	[Address(RVA = "0x3BE2A0", Offset = "0x3BD4A0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "OnRotation3DChanged", ReturnType = typeof(void))]
	[Token(Token = "0x60001C4")]
	private void ChangeRotation3D(Quaternion rotation) { }

	[Address(RVA = "0x3BE2E0", Offset = "0x3BD4E0", Length = "0x331")]
	[CalledBy(Type = typeof(GizmoDragSession), Member = "ApplyDrag", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001A7")]
	public static List<GizmoTransform> FilterParentsOnly(IEnumerable<GizmoTransform> transforms) { }

	[Address(RVA = "0x3C19A0", Offset = "0x3C0BA0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600018B")]
	public bool get_CanChange2D() { }

	[Address(RVA = "0x3C19B0", Offset = "0x3C0BB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600018A")]
	public bool get_CanChange3D() { }

	[Address(RVA = "0x3C19C0", Offset = "0x3C0BC0", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600018E")]
	public List<GizmoTransform> get_Children() { }

	[Address(RVA = "0x3C1A30", Offset = "0x3C0C30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600019F")]
	public Vector2 get_LocalPosition2D() { }

	[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019D")]
	public Vector3 get_LocalPosition3D() { }

	[Address(RVA = "0x3B4380", Offset = "0x3B3580", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A3")]
	public Quaternion get_LocalRotation2D() { }

	[Address(RVA = "0x3C1A70", Offset = "0x3C0C70", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A4")]
	public float get_LocalRotation2DDegrees() { }

	[Address(RVA = "0x3C1A80", Offset = "0x3C0C80", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001A1")]
	public Quaternion get_LocalRotation3D() { }

	[Address(RVA = "0x3C1A90", Offset = "0x3C0C90", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000191")]
	public Vector3 get_Look3D() { }

	[Address(RVA = "0x3C1AD0", Offset = "0x3C0CD0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600018D")]
	public int get_NumChildren() { }

	[Address(RVA = "0x2DD260", Offset = "0x2DC460", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600018C")]
	public GizmoTransform get_Parent() { }

	[Address(RVA = "0x3C1B10", Offset = "0x3C0D10", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000196")]
	public Vector2 get_Position2D() { }

	[Address(RVA = "0x3B87E0", Offset = "0x3B79E0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000194")]
	public Vector3 get_Position3D() { }

	[Address(RVA = "0x3C1B30", Offset = "0x3C0D30", Length = "0x38")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000192")]
	public Vector2 get_Right2D() { }

	[Address(RVA = "0x3C1B70", Offset = "0x3C0D70", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600018F")]
	public Vector3 get_Right3D() { }

	[Address(RVA = "0x3C1BC0", Offset = "0x3C0DC0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019A")]
	public Quaternion get_Rotation2D() { }

	[Address(RVA = "0x3C1BB0", Offset = "0x3C0DB0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600019B")]
	public float get_Rotation2DDegrees() { }

	[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000198")]
	public Quaternion get_Rotation3D() { }

	[Address(RVA = "0x3C1BD0", Offset = "0x3C0DD0", Length = "0x38")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000193")]
	public Vector2 get_Up2D() { }

	[Address(RVA = "0x3C1C10", Offset = "0x3C0E10", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000190")]
	public Vector3 get_Up3D() { }

	[Address(RVA = "0x3BE620", Offset = "0x3BD820", Length = "0x209")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PlaneIdHelper), Member = "PlaneIdToFirstAxisIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlaneIdHelper), Member = "PlaneIdToSecondAxisIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CameraEx), Member = "IsPointFacingCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PlaneIdHelper), Member = "GetQuadrantFromAxesSigns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(AxisSign), typeof(AxisSign)}, ReturnType = typeof(PlaneQuadrantId))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A8")]
	public PlaneQuadrantId Get3DQuadrantFacingCamera(PlaneId planeId, Camera camera) { }

	[Address(RVA = "0x3BE830", Offset = "0x3BDA30", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001BF")]
	public Vector2[] GetAxes2D() { }

	[Address(RVA = "0x3BE890", Offset = "0x3BDA90", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001BE")]
	public Vector3[] GetAxes3D() { }

	[Address(RVA = "0x3BE970", Offset = "0x3BDB70", Length = "0x53")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "get_Right", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "get_Up", ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001BD")]
	public Vector2 GetAxis2D(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3BE8F0", Offset = "0x3BDAF0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001BC")]
	public Vector2 GetAxis2D(AxisDescriptor axisDesc) { }

	[Address(RVA = "0x3BEA60", Offset = "0x3BDC60", Length = "0x7F")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "get_Plane", ReturnType = typeof(Plane))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "get_Right", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "get_Up", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "get_Look", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "get_Normal", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001BB")]
	public Vector3 GetAxis3D(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3BE9D0", Offset = "0x3BDBD0", Length = "0x8D")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateColor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "OnGizmoHandlePicked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "AlignToQuadrant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(PlaneQuadrantId), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001BA")]
	public Vector3 GetAxis3D(AxisDescriptor axisDesc) { }

	[Address(RVA = "0x3BEAE0", Offset = "0x3BDCE0", Length = "0x22E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001C1")]
	public Plane GetPlane3D(PlaneDescriptor planeDesc) { }

	[Address(RVA = "0x3BED10", Offset = "0x3BDF10", Length = "0x265")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "AlignToQuadrant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(PlaneQuadrantId), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlaneDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlaneId), typeof(PlaneQuadrantId)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60001C0")]
	public Plane GetPlane3D(PlaneId planeId, PlaneQuadrantId planeQuadrantId) { }

	[Address(RVA = "0x3BEF80", Offset = "0x3BE180", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001B1")]
	public Vector2 InverseTransformNormal2D(Vector2 normal) { }

	[Address(RVA = "0x3BF020", Offset = "0x3BE220", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001B0")]
	public Vector3 InverseTransformNormal3D(Vector3 normal) { }

	[Address(RVA = "0x3BF0B0", Offset = "0x3BE2B0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001B5")]
	public Vector2 InverseTransformPoint2D(Vector2 point) { }

	[Address(RVA = "0x3BF140", Offset = "0x3BE340", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001B4")]
	public Vector3 InverseTransformPoint3D(Vector3 point) { }

	[Address(RVA = "0x3BF200", Offset = "0x3BE400", Length = "0x28")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001B8")]
	public bool IsChildOf(GizmoTransform transform) { }

	[Address(RVA = "0x3BF230", Offset = "0x3BE430", Length = "0x67")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D7")]
	private void OnChanged(ChangeData changeData) { }

	[Address(RVA = "0x3BF2A0", Offset = "0x3BE4A0", Length = "0x122")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D0")]
	private void OnLocalPosition2DChanged() { }

	[Address(RVA = "0x3BF3D0", Offset = "0x3BE5D0", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001CF")]
	private void OnLocalPosition3DChanged() { }

	[Address(RVA = "0x3BF4F0", Offset = "0x3BE6F0", Length = "0x25A")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "set_LocalRotation2DDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangeLocalRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangeLocalRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "Update2DAxes", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D4")]
	private void OnLocalRotation2DChanged() { }

	[Address(RVA = "0x3BF750", Offset = "0x3BE950", Length = "0x240")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "set_LocalRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangeLocalRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "Update3DAxes", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D3")]
	private void OnLocalRotation3DChanged() { }

	[Address(RVA = "0x3BF990", Offset = "0x3BEB90", Length = "0x507")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001CC")]
	private void OnParentChanged() { }

	[Address(RVA = "0x3BFEA0", Offset = "0x3BF0A0", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001CE")]
	private void OnPosition2DChanged() { }

	[Address(RVA = "0x3BFFF0", Offset = "0x3BF1F0", Length = "0x14D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001CD")]
	private void OnPosition3DChanged() { }

	[Address(RVA = "0x3C0140", Offset = "0x3BF340", Length = "0x275")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "Update2DAxes", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D2")]
	private void OnRotation2DChanged() { }

	[Address(RVA = "0x3C03C0", Offset = "0x3BF5C0", Length = "0x25B")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangeRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "Update3DAxes", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D1")]
	private void OnRotation3DChanged() { }

	[Address(RVA = "0x3C1C50", Offset = "0x3C0E50", Length = "0x9E")]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RotationGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnDetached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnDisabled", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CompilerGenerated]
	[Token(Token = "0x6000189")]
	public void remove_Changed(GizmoEntityTransformChangedHandler value) { }

	[Address(RVA = "0x3C0640", Offset = "0x3BF840", Length = "0x4D")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoHandleDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001AB")]
	public void Rotate2D(Quaternion rotation) { }

	[Address(RVA = "0x3C0620", Offset = "0x3BF820", Length = "0x20")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoHandleDragUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001AA")]
	public void Rotate2D(float rotation) { }

	[Address(RVA = "0x3C0690", Offset = "0x3BF890", Length = "0x17E")]
	[CalledBy(Type = typeof(GizmoTransformAxisMap3D), Member = "SetAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap3D), Member = "SetMappedAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GizmoTransform), Member = "set_Rotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001A9")]
	public void Rotate3D(Quaternion rotation) { }

	[Address(RVA = "0x3C1CF0", Offset = "0x3C0EF0", Length = "0x17C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A0")]
	public void set_LocalPosition2D(Vector2 value) { }

	[Address(RVA = "0x3C1E70", Offset = "0x3C1070", Length = "0x18B")]
	[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600019E")]
	public void set_LocalPosition3D(Vector3 value) { }

	[Address(RVA = "0x3C2000", Offset = "0x3C1200", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "OnLocalRotation2DChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A5")]
	public void set_LocalRotation2DDegrees(float value) { }

	[Address(RVA = "0x3C20C0", Offset = "0x3C12C0", Length = "0x194")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "set_LocalRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "OnLocalRotation3DChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A2")]
	public void set_LocalRotation3D(Quaternion value) { }

	[Address(RVA = "0x3C2260", Offset = "0x3C1460", Length = "0x196")]
	[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap2D), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCircleCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoArrowCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "set_StartPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "set_Position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MoveGizmo), Member = "Update2DGizmoPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalGizmo), Member = "Update2DGizmoPosition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuadCap2DController), Member = "CapSlider2DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000197")]
	public void set_Position2D(Vector2 value) { }

	[Address(RVA = "0x3C2400", Offset = "0x3C1600", Length = "0x1C2")]
	[CallerCount(Count = 31)]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000195")]
	public void set_Position3D(Vector3 value) { }

	[Address(RVA = "0x3C25D0", Offset = "0x3C17D0", Length = "0x1B")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "set_RotationDegrees", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600019C")]
	public void set_Rotation2DDegrees(float value) { }

	[Address(RVA = "0x3C25F0", Offset = "0x3C17F0", Length = "0x194")]
	[CalledBy(Type = typeof(GizmoDragSession), Member = "ApplyDrag", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "CapSlider3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "CapSlider3DInvert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "Rotate3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CreatorController), Member = "PropertyGrid_ValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(PropertyInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "AlignAxis3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "FitBoxToTargetHierarchy", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "set_Rotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "AlignToQuadrant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(PlaneQuadrantId), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "RefreshRotation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "SetOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "SetAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(Quaternion), Member = "Internal_ToEulerRad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Internal_MakePositive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GizmoTransform), Member = "OnRotation3DChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000199")]
	public void set_Rotation3D(Quaternion value) { }

	[Address(RVA = "0x3C0810", Offset = "0x3BFA10", Length = "0xC5")]
	[CalledBy(Type = typeof(GizmoCap2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(GizmoTransform), Member = "OnParentChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B9")]
	public void SetParent(GizmoTransform newParent) { }

	[Address(RVA = "0x3C08E0", Offset = "0x3BFAE0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001AF")]
	public Vector2 TransformNormal2D(Vector2 normal) { }

	[Address(RVA = "0x3C0970", Offset = "0x3BFB70", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001AE")]
	public Vector3 TransformNormal3D(Vector3 normal) { }

	[Address(RVA = "0x3C09F0", Offset = "0x3BFBF0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001B3")]
	public Vector2 TransformPoint2D(Vector2 point) { }

	[Address(RVA = "0x3C0A60", Offset = "0x3BFC60", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001B2")]
	public Vector3 TransformPoint3D(Vector3 point) { }

	[Address(RVA = "0x3C0AF0", Offset = "0x3BFCF0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001AD")]
	public Vector2 TransformVector2D(Vector2 vec) { }

	[Address(RVA = "0x3C0B50", Offset = "0x3BFD50", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001AC")]
	public Vector3 TransformVector3D(Vector3 vec) { }

	[Address(RVA = "0x3C0BB0", Offset = "0x3BFDB0", Length = "0x1D4")]
	[CalledBy(Type = typeof(GizmoTransform), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnRotation2DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnLocalRotation2DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4Ex), Member = "GetNormalizedAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(int)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001D9")]
	private void Update2DAxes() { }

	[Address(RVA = "0x3C0D90", Offset = "0x3BFF90", Length = "0x208")]
	[CalledBy(Type = typeof(GizmoTransform), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnRotation3DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnLocalRotation3DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4Ex), Member = "GetNormalizedAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(int)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001D8")]
	private void Update3DAxes() { }

	[Address(RVA = "0x3C0FA0", Offset = "0x3C01A0", Length = "0x3D8")]
	[CalledBy(Type = typeof(LocalGizmoTransformSnapshot), Member = "Apply", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnLocalRotation2DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnRotation2DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnLocalPosition2DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnPosition2DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangeLocalPosition2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangePosition2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "set_LocalPosition2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "set_Position2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnParentChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms2D", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "Update2DAxes", ReturnType = typeof(void))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D6")]
	private void UpdateChildTransforms2D() { }

	[Address(RVA = "0x3C1380", Offset = "0x3C0580", Length = "0x3B8")]
	[CalledBy(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnRotation3DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnLocalPosition3DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnPosition3DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnParentChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "OnLocalRotation3DChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangePosition3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "set_LocalPosition3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "set_Position3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransform), Member = "ChangeLocalPosition3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "Update3DAxes", ReturnType = typeof(void))]
	[Calls(Type = typeof(GizmoTransform), Member = "UpdateChildTransforms3D", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D5")]
	private void UpdateChildTransforms3D() { }

}

