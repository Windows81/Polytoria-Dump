namespace RLD;

[Token(Token = "0x200003E")]
public class GizmoTransformAxisMap3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F3")]
	private Vector3 _freeAxis; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F4")]
	private AxisDescriptor _mappedAxisDesc; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000F5")]
	private GizmoTransform _transform; //Field offset: 0x28

	[Token(Token = "0x17000081")]
	public Vector3 Axis
	{
		[Address(RVA = "0x3BD690", Offset = "0x3BC890", Length = "0xD6")]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "get_Direction", ReturnType = typeof(Vector3))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "get_DragRotationAxis", ReturnType = typeof(Vector3))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPositionWith3DCap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001EB")]
		 get { } //Length: 214
	}

	[Token(Token = "0x17000080")]
	public bool IsMapped
	{
		[Address(RVA = "0x3BD770", Offset = "0x3BC970", Length = "0x9")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60001EA")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700007D")]
	public AxisDescriptor MappedAxisDesc
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700007E")]
	public int MappedAxisIndex
	{
		[Address(RVA = "0x3BD780", Offset = "0x3BC980", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001E8")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700007F")]
	public AxisSign MappedAxisSign
	{
		[Address(RVA = "0x3BD7A0", Offset = "0x3BC9A0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E9")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000082")]
	public GizmoTransform Transform
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001EC")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3BD5E0", Offset = "0x3BC7E0", Length = "0xA6")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AxisDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001F2")]
	public GizmoTransformAxisMap3D() { }

	[Address(RVA = "0x3BD690", Offset = "0x3BC890", Length = "0xD6")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "get_Direction", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "get_DragRotationAxis", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealDirection", ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "GetRealEndPositionWith3DCap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001EB")]
	public Vector3 get_Axis() { }

	[Address(RVA = "0x3BD770", Offset = "0x3BC970", Length = "0x9")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EA")]
	public bool get_IsMapped() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E7")]
	public AxisDescriptor get_MappedAxisDesc() { }

	[Address(RVA = "0x3BD780", Offset = "0x3BC980", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001E8")]
	public int get_MappedAxisIndex() { }

	[Address(RVA = "0x3BD7A0", Offset = "0x3BC9A0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E9")]
	public AxisSign get_MappedAxisSign() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EC")]
	public GizmoTransform get_Transform() { }

	[Address(RVA = "0x3BD0C0", Offset = "0x3BC2C0", Length = "0xA2")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "MapDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "MapDragRotationAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AxisDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001ED")]
	public void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3BD170", Offset = "0x3BC370", Length = "0x21D")]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "SetDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = "SetDragRotationAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "Rotate3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001EF")]
	public void SetAxis(Vector3 axis) { }

	[Address(RVA = "0x3BD390", Offset = "0x3BC590", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60001F1")]
	public void SetFreeAxis(Vector3 axis) { }

	[Address(RVA = "0x3BD3E0", Offset = "0x3BC5E0", Length = "0x1D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(GizmoTransform), Member = "Rotate3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001F0")]
	public void SetMappedAxis(Vector3 axis) { }

	[Address(RVA = "0x3BD5C0", Offset = "0x3BC7C0", Length = "0x13")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EE")]
	public void Unmap() { }

}

