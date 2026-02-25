namespace RLD;

[Token(Token = "0x200003D")]
public class GizmoTransformAxisMap2D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000F0")]
	private Vector2 _freeAxis; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000F1")]
	private AxisDescriptor _mappedAxisDesc; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000F2")]
	private GizmoTransform _transform; //Field offset: 0x20

	[Token(Token = "0x1700007B")]
	public Vector2 Axis
	{
		[Address(RVA = "0x3BCFD0", Offset = "0x3BC1D0", Length = "0x9D")]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "get_Direction", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "GetRealDirection", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "GetRealEndPosition", ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(GizmoThinLineSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001DF")]
		 get { } //Length: 157
	}

	[Token(Token = "0x1700007A")]
	public bool IsMapped
	{
		[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DE")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000077")]
	public AxisDescriptor MappedAxisDesc
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000078")]
	public int MappedAxisIndex
	{
		[Address(RVA = "0x3BD080", Offset = "0x3BC280", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001DC")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000079")]
	public AxisSign MappedAxisSign
	{
		[Address(RVA = "0x3BD0A0", Offset = "0x3BC2A0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001DD")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700007C")]
	public GizmoTransform Transform
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E0")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3BCF20", Offset = "0x3BC120", Length = "0xAA")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AxisDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001E6")]
	public GizmoTransformAxisMap2D() { }

	[Address(RVA = "0x3BCFD0", Offset = "0x3BC1D0", Length = "0x9D")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "get_Direction", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "GetRealDirection", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "GetRealEndPosition", ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(GizmoThinLineSlider2DController), Member = "UpdateTransforms", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001DF")]
	public Vector2 get_Axis() { }

	[Address(RVA = "0x3BD070", Offset = "0x3BC270", Length = "0x9")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DE")]
	public bool get_IsMapped() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DB")]
	public AxisDescriptor get_MappedAxisDesc() { }

	[Address(RVA = "0x3BD080", Offset = "0x3BC280", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DC")]
	public int get_MappedAxisIndex() { }

	[Address(RVA = "0x3BD0A0", Offset = "0x3BC2A0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001DD")]
	public AxisSign get_MappedAxisSign() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E0")]
	public GizmoTransform get_Transform() { }

	[Address(RVA = "0x3BCBD0", Offset = "0x3BBDD0", Length = "0xA6")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "MapDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AxisDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001E1")]
	public void Map(GizmoTransform transform, int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x3BCC80", Offset = "0x3BBE80", Length = "0x133")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "SetDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001E3")]
	public void SetAxis(Vector2 axis) { }

	[Address(RVA = "0x3BCDC0", Offset = "0x3BBFC0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E5")]
	public void SetFreeAxis(Vector2 axis) { }

	[Address(RVA = "0x3BCE00", Offset = "0x3BC000", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "ConvertTo2DRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(GizmoTransform), Member = "ChangeRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001E4")]
	public void SetMappedAxis(Vector2 axis) { }

	[Address(RVA = "0x3BCF00", Offset = "0x3BC100", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E2")]
	public void Unmap() { }

}

