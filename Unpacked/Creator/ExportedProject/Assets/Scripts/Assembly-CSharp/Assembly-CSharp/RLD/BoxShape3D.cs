namespace RLD;

[Token(Token = "0x200023D")]
public class BoxShape3D : Shape3D
{
	[Token(Token = "0x200023F")]
	internal class WireRenderDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008DD")]
		private float _cornerLinePercentage; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40008DE")]
		private WireRenderMode _wireMode; //Field offset: 0x14

		[Token(Token = "0x170006F6")]
		public float CornerLinePercentage
		{
			[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60015B7")]
			 get { } //Length: 6
			[Address(RVA = "0x5C3C40", Offset = "0x5C2E40", Length = "0x21")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x60015B8")]
			 set { } //Length: 33
		}

		[Token(Token = "0x170006F5")]
		public WireRenderMode WireMode
		{
			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60015B5")]
			 get { } //Length: 4
			[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			[Token(Token = "0x60015B6")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x5C3BE0", Offset = "0x5C2DE0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60015B9")]
		public WireRenderDescriptor() { }

		[Address(RVA = "0x4FCB00", Offset = "0x4FBD00", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015B7")]
		public float get_CornerLinePercentage() { }

		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015B5")]
		public WireRenderMode get_WireMode() { }

		[Address(RVA = "0x5C3C40", Offset = "0x5C2E40", Length = "0x21")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60015B8")]
		public void set_CornerLinePercentage(float value) { }

		[Address(RVA = "0x369380", Offset = "0x368580", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015B6")]
		public void set_WireMode(WireRenderMode value) { }

	}

	[Token(Token = "0x200023E")]
	internal enum WireRenderMode
	{
		Wire = 0,
		WireCorners = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008D5")]
	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008D6")]
	private Vector3 _size; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40008D7")]
	private Vector3 _center; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008D8")]
	private Quaternion _rotation; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40008D9")]
	private BoxEpsilon _epsilon; //Field offset: 0x40

	[Token(Token = "0x170006E4")]
	public Vector3 Center
	{
		[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600158D")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600158E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170006E2")]
	public float Depth
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600158A")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x600158B")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170006E9")]
	public float DepthEps
	{
		[Address(RVA = "0x5A8A80", Offset = "0x5A7C80", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001597")]
		 get { } //Length: 11
		[Address(RVA = "0x5A8E50", Offset = "0x5A8050", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001598")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170006E5")]
	public BoxEpsilon Epsilon
	{
		[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600158F")]
		 get { } //Length: 19
		[Address(RVA = "0x5A8E70", Offset = "0x5A8070", Length = "0x10")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001590")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170006E3")]
	public Vector3 Extents
	{
		[Address(RVA = "0x5A8A90", Offset = "0x5A7C90", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600158C")]
		 get { } //Length: 59
	}

	[Token(Token = "0x170006E1")]
	public float Height
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001588")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001589")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170006E8")]
	public float HeightEps
	{
		[Address(RVA = "0x5A8AD0", Offset = "0x5A7CD0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001595")]
		 get { } //Length: 11
		[Address(RVA = "0x5A8E80", Offset = "0x5A8080", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001596")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170006EF")]
	public Vector3 Look
	{
		[Address(RVA = "0x5A8AE0", Offset = "0x5A7CE0", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x60015A1")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170006EB")]
	public Vector3 Max
	{
		[Address(RVA = "0x5A8B70", Offset = "0x5A7D70", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600159B")]
		 get { } //Length: 84
		[Address(RVA = "0x5A8EA0", Offset = "0x5A80A0", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600159C")]
		 set { } //Length: 206
	}

	[Token(Token = "0x170006EA")]
	public Vector3 Min
	{
		[Address(RVA = "0x5A8BD0", Offset = "0x5A7DD0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001599")]
		 get { } //Length: 96
		[Address(RVA = "0x5A8F70", Offset = "0x5A8170", Length = "0xCB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600159A")]
		 set { } //Length: 203
	}

	[Token(Token = "0x170006F4")]
	public static Vector3 ModelCenter
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60015A6")]
		 get { } //Length: 74
	}

	[Token(Token = "0x170006F3")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60015A5")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170006F1")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60015A3")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170006F2")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x60015A4")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170006ED")]
	public Vector3 Right
	{
		[Address(RVA = "0x5A8D20", Offset = "0x5A7F20", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600159F")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170006EC")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600159D")]
		 get { } //Length: 11
		[Address(RVA = "0x5A9040", Offset = "0x5A8240", Length = "0x30")]
		[CalledBy(Type = typeof(GizmoBoxCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
		[Token(Token = "0x600159E")]
		 set { } //Length: 48
	}

	[Token(Token = "0x170006DF")]
	public Vector3 Size
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001584")]
		 get { } //Length: 19
		[Address(RVA = "0x5A90A0", Offset = "0x5A82A0", Length = "0x41")]
		[CalledBy(Type = typeof(GizmoBoxCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001585")]
		 set { } //Length: 65
	}

	[Token(Token = "0x170006E6")]
	public Vector3 SizeEps
	{
		[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001591")]
		 get { } //Length: 19
		[Address(RVA = "0x5A9070", Offset = "0x5A8270", Length = "0x2B")]
		[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoBoxQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(BoxEpsilon), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001592")]
		 set { } //Length: 43
	}

	[Token(Token = "0x170006EE")]
	public Vector3 Up
	{
		[Address(RVA = "0x5A8DB0", Offset = "0x5A7FB0", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x60015A0")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170006E0")]
	public float Width
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001586")]
		 get { } //Length: 6
		[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001587")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170006E7")]
	public float WidthEps
	{
		[Address(RVA = "0x5A8E40", Offset = "0x5A8040", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001593")]
		 get { } //Length: 11
		[Address(RVA = "0x5A90F0", Offset = "0x5A82F0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001594")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170006F0")]
	public WireRenderDescriptor WireRenderDesc
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60015A2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5A8960", Offset = "0x5A7B60", Length = "0x111")]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoLineSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(QuadShape3D)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60015B4")]
	public BoxShape3D() { }

	[Address(RVA = "0x5A7860", Offset = "0x5A6A60", Length = "0x2A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x60015AB")]
	public void AlignDepth(Vector3 axis) { }

	[Address(RVA = "0x5A7B10", Offset = "0x5A6D10", Length = "0x2A4")]
	[CalledBy(Type = typeof(GizmoBoxQuad3DBorderController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x60015AA")]
	public void AlignHeight(Vector3 axis) { }

	[Address(RVA = "0x5A7DC0", Offset = "0x5A6FC0", Length = "0x2A4")]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxQuad3DBorderController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x60015A9")]
	public void AlignWidth(Vector3 axis) { }

	[Address(RVA = "0x5A8070", Offset = "0x5A7270", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60015B3")]
	public bool ContainsPoint(Vector3 point) { }

	[Address(RVA = "0x5A8180", Offset = "0x5A7380", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015A7")]
	public void FromOBB(OBB obb) { }

	[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600158D")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600158A")]
	public float get_Depth() { }

	[Address(RVA = "0x5A8A80", Offset = "0x5A7C80", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001597")]
	public float get_DepthEps() { }

	[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600158F")]
	public BoxEpsilon get_Epsilon() { }

	[Address(RVA = "0x5A8A90", Offset = "0x5A7C90", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600158C")]
	public Vector3 get_Extents() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001588")]
	public float get_Height() { }

	[Address(RVA = "0x5A8AD0", Offset = "0x5A7CD0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001595")]
	public float get_HeightEps() { }

	[Address(RVA = "0x5A8AE0", Offset = "0x5A7CE0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60015A1")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x5A8B70", Offset = "0x5A7D70", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600159B")]
	public Vector3 get_Max() { }

	[Address(RVA = "0x5A8BD0", Offset = "0x5A7DD0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001599")]
	public Vector3 get_Min() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60015A6")]
	public static Vector3 get_ModelCenter() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60015A5")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60015A3")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x60015A4")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x5A8D20", Offset = "0x5A7F20", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600159F")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600159D")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001584")]
	public Vector3 get_Size() { }

	[Address(RVA = "0x3B9190", Offset = "0x3B8390", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001591")]
	public Vector3 get_SizeEps() { }

	[Address(RVA = "0x5A8DB0", Offset = "0x5A7FB0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60015A0")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001586")]
	public float get_Width() { }

	[Address(RVA = "0x5A8E40", Offset = "0x5A8040", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001593")]
	public float get_WidthEps() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60015A2")]
	public WireRenderDescriptor get_WireRenderDesc() { }

	[Address(RVA = "0x5A8200", Offset = "0x5A7400", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x60015B1")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5A8260", Offset = "0x5A7460", Length = "0xF9")]
	[CalledBy(Type = typeof(GizmoBoxQuad3DBorderController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxFaceCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxFace)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60015AC")]
	public Vector3 GetFaceCenter(BoxFace boxFace) { }

	[Address(RVA = "0x5A8360", Offset = "0x5A7560", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(Quaternion)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60015B2")]
	public OBB GetOBB() { }

	[Address(RVA = "0x5A83F0", Offset = "0x5A75F0", Length = "0x75")]
	[CalledBy(Type = typeof(GizmoBoxQuad3DBorderController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3Ex), Member = "AbsDot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Token(Token = "0x60015A8")]
	public float GetSizeAlongDirection(Vector3 direction) { }

	[Address(RVA = "0x5A8470", Offset = "0x5A7670", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60015B0")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5A85A0", Offset = "0x5A77A0", Length = "0x15D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitBox", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60015AE")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5A8700", Offset = "0x5A7900", Length = "0x114")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsEx), Member = "DrawWireCornerBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60015AF")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600158E")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x600158B")]
	public void set_Depth(float value) { }

	[Address(RVA = "0x5A8E50", Offset = "0x5A8050", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001598")]
	public void set_DepthEps(float value) { }

	[Address(RVA = "0x5A8E70", Offset = "0x5A8070", Length = "0x10")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001590")]
	public void set_Epsilon(BoxEpsilon value) { }

	[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001589")]
	public void set_Height(float value) { }

	[Address(RVA = "0x5A8E80", Offset = "0x5A8080", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001596")]
	public void set_HeightEps(float value) { }

	[Address(RVA = "0x5A8EA0", Offset = "0x5A80A0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600159C")]
	public void set_Max(Vector3 value) { }

	[Address(RVA = "0x5A8F70", Offset = "0x5A8170", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600159A")]
	public void set_Min(Vector3 value) { }

	[Address(RVA = "0x5A9040", Offset = "0x5A8240", Length = "0x30")]
	[CalledBy(Type = typeof(GizmoBoxCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QuaternionEx), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x600159E")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x5A90A0", Offset = "0x5A82A0", Length = "0x41")]
	[CalledBy(Type = typeof(GizmoBoxCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001585")]
	public void set_Size(Vector3 value) { }

	[Address(RVA = "0x5A9070", Offset = "0x5A8270", Length = "0x2B")]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(BoxEpsilon), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001592")]
	public void set_SizeEps(Vector3 value) { }

	[Address(RVA = "0x5A9100", Offset = "0x5A8300", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001587")]
	public void set_Width(float value) { }

	[Address(RVA = "0x5A90F0", Offset = "0x5A82F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001594")]
	public void set_WidthEps(float value) { }

	[Address(RVA = "0x5A8820", Offset = "0x5A7A20", Length = "0x133")]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxQuad3DBorderController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxFaceCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxFace)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60015AD")]
	public void SetFaceCenter(BoxFace boxFace, Vector3 newCenter) { }

}

