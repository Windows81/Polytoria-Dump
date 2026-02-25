namespace RLD;

[Token(Token = "0x2000181")]
public class AxisDescriptor
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400067C")]
	private AxisSign _sign; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400067D")]
	private int _index; //Field offset: 0x14

	[Token(Token = "0x1700057B")]
	public int Index
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010FB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700057D")]
	public bool IsNegative
	{
		[Address(RVA = "0x557180", Offset = "0x556380", Length = "0x8")]
		[CallerCount(Count = 13)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60010FD")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700057C")]
	public bool IsPositive
	{
		[Address(RVA = "0x557190", Offset = "0x556390", Length = "0x8")]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60010FC")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700057A")]
	public AxisSign Sign
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010FA")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x557100", Offset = "0x556300", Length = "0x34")]
	[CalledBy(Type = typeof(GizmoTransformAxisMap2D), Member = "Map", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap2D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap3D), Member = "Map", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(int), typeof(AxisSign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoTransformAxisMap3D), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmo), Member = "OnAttached", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010FE")]
	public AxisDescriptor(int axisIndex, AxisSign axisSign) { }

	[Address(RVA = "0x557140", Offset = "0x556340", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010FF")]
	public AxisDescriptor(int axisIndex, bool isNegative) { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010FB")]
	public int get_Index() { }

	[Address(RVA = "0x557180", Offset = "0x556380", Length = "0x8")]
	[CallerCount(Count = 13)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60010FD")]
	public bool get_IsNegative() { }

	[Address(RVA = "0x557190", Offset = "0x556390", Length = "0x8")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010FC")]
	public bool get_IsPositive() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010FA")]
	public AxisSign get_Sign() { }

	[Address(RVA = "0x5570C0", Offset = "0x5562C0", Length = "0x3D")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SceneGizmo), typeof(int), typeof(AxisDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6001100")]
	public BoxFace GetAssociatedBoxFace() { }

}

