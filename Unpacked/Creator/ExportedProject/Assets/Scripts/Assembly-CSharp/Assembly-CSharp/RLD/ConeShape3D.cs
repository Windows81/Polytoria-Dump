namespace RLD;

[Token(Token = "0x2000243")]
public class ConeShape3D : Shape3D
{
	[Token(Token = "0x2000245")]
	internal class WireRenderDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40008F9")]
		private WireRenderMode _wireMode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40008FA")]
		private int _numDetailAxialRings; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40008FB")]
		private int _numDetailAxialSegments; //Field offset: 0x18

		[Token(Token = "0x17000735")]
		public int NumDetailAxialRings
		{
			[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001638")]
			 get { } //Length: 4
			[Address(RVA = "0x5C3C80", Offset = "0x5C2E80", Length = "0x10")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001639")]
			 set { } //Length: 16
		}

		[Token(Token = "0x17000736")]
		public int NumDetailAxialSegments
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600163A")]
			 get { } //Length: 4
			[Address(RVA = "0x5C3C70", Offset = "0x5C2E70", Length = "0x10")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600163B")]
			 set { } //Length: 16
		}

		[Token(Token = "0x17000734")]
		public WireRenderMode WireMode
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001636")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001637")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x5C3C10", Offset = "0x5C2E10", Length = "0x15")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600163C")]
		public WireRenderDescriptor() { }

		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001638")]
		public int get_NumDetailAxialRings() { }

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600163A")]
		public int get_NumDetailAxialSegments() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001636")]
		public WireRenderMode get_WireMode() { }

		[Address(RVA = "0x5C3C80", Offset = "0x5C2E80", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001639")]
		public void set_NumDetailAxialRings(int value) { }

		[Address(RVA = "0x5C3C70", Offset = "0x5C2E70", Length = "0x10")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600163B")]
		public void set_NumDetailAxialSegments(int value) { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001637")]
		public void set_WireMode(WireRenderMode value) { }

	}

	[Token(Token = "0x2000244")]
	internal enum WireRenderMode
	{
		Basic = 0,
		Detailed = 1,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008F0")]
	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008F1")]
	private Vector3 _baseCenter; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40008F2")]
	private Quaternion _rotation; //Field offset: 0x24
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40008F3")]
	private float _baseRadius; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008F4")]
	private float _height; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40008F5")]
	private ConeEpsilon _epsilon; //Field offset: 0x3C

	[Token(Token = "0x17000723")]
	public Vector3 BaseCenter
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001615")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001616")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000725")]
	public float BaseRadius
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001619")]
		 get { } //Length: 6
		[Address(RVA = "0x5ACED0", Offset = "0x5AC0D0", Length = "0xD")]
		[CalledBy(Type = typeof(GizmoConeCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600161A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000728")]
	public Vector3 CentralAxis
	{
		[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x600161F")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700072C")]
	public ConeEpsilon Epsilon
	{
		[Address(RVA = "0x3E3C80", Offset = "0x3E2E80", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001623")]
		 get { } //Length: 19
		[Address(RVA = "0x3E3CB0", Offset = "0x3E2EB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001624")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000726")]
	public float Height
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600161B")]
		 get { } //Length: 6
		[Address(RVA = "0x5ACEE0", Offset = "0x5AC0E0", Length = "0xD")]
		[CalledBy(Type = typeof(GizmoConeCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600161C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700072D")]
	public float HrzEps
	{
		[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001625")]
		 get { } //Length: 6
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC0F0", Length = "0xC")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001626")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700072B")]
	public Vector3 Look
	{
		[Address(RVA = "0x5ACCC0", Offset = "0x5ABEC0", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001622")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000733")]
	public static Vector3 ModelBaseCenter
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600162D")]
		 get { } //Length: 74
	}

	[Token(Token = "0x17000732")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600162C")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000730")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600162A")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000731")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600162B")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000729")]
	public Vector3 Right
	{
		[Address(RVA = "0x5ACD50", Offset = "0x5ABF50", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001620")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000727")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600161D")]
		 get { } //Length: 11
		[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600161E")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000724")]
	public Vector3 Tip
	{
		[Address(RVA = "0x5ACDE0", Offset = "0x5ABFE0", Length = "0xE2")]
		[CalledBy(Type = typeof(ConeShape3D), Member = "RenderWire", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConeShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001617")]
		 get { } //Length: 226
		[Address(RVA = "0x5ACF00", Offset = "0x5AC100", Length = "0xCC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001618")]
		 set { } //Length: 204
	}

	[Token(Token = "0x1700072A")]
	public Vector3 Up
	{
		[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001621")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700072E")]
	public float VertEps
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001627")]
		 get { } //Length: 6
		[Address(RVA = "0x5ACFD0", Offset = "0x5AC1D0", Length = "0xC")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001628")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700072F")]
	public WireRenderDescriptor WireRenderDesc
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001629")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5ACB40", Offset = "0x5ABD40", Length = "0xEC")]
	[CalledBy(Type = typeof(GizmoCap3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001635")]
	public ConeShape3D() { }

	[Address(RVA = "0x5AB7E0", Offset = "0x5AA9E0", Length = "0x287")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[DeduplicatedMethod]
	[Token(Token = "0x600162E")]
	public void AlignTip(Vector3 axis) { }

	[Address(RVA = "0x5ABA70", Offset = "0x5AAC70", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConeMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), typeof(ConeEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001632")]
	public bool ContainsPoint(Vector3 point) { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001615")]
	public Vector3 get_BaseCenter() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001619")]
	public float get_BaseRadius() { }

	[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x600161F")]
	public Vector3 get_CentralAxis() { }

	[Address(RVA = "0x3E3C80", Offset = "0x3E2E80", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001623")]
	public ConeEpsilon get_Epsilon() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600161B")]
	public float get_Height() { }

	[Address(RVA = "0x3B4320", Offset = "0x3B3520", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001625")]
	public float get_HrzEps() { }

	[Address(RVA = "0x5ACCC0", Offset = "0x5ABEC0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001622")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600162D")]
	public static Vector3 get_ModelBaseCenter() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600162C")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600162A")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600162B")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x5ACD50", Offset = "0x5ABF50", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001620")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x3B91E0", Offset = "0x3B83E0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600161D")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x5ACDE0", Offset = "0x5ABFE0", Length = "0xE2")]
	[CalledBy(Type = typeof(ConeShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConeShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001617")]
	public Vector3 get_Tip() { }

	[Address(RVA = "0x5ACC30", Offset = "0x5ABE30", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001621")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001627")]
	public float get_VertEps() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001629")]
	public WireRenderDescriptor get_WireRenderDesc() { }

	[Address(RVA = "0x5ABAF0", Offset = "0x5AACF0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConeMath), Member = "CalcConeBaseExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConeShape3D), Member = "get_Tip", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001634")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5ABB90", Offset = "0x5AAD90", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConeMath), Member = "CalcConeBaseExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Token(Token = "0x6001633")]
	public List<Vector3> GetBaseExtents() { }

	[Address(RVA = "0x5ABBD0", Offset = "0x5AADD0", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConeMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), typeof(ConeEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001631")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5ABC60", Offset = "0x5AAE60", Length = "0x184")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitCone", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600162F")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5ABDF0", Offset = "0x5AAFF0", Length = "0xD45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLines3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitWireCircleXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ConeShape3D), Member = "get_Tip", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ConeMath), Member = "CalcConeBaseExtentPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001630")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x2DD600", Offset = "0x2DC800", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001616")]
	public void set_BaseCenter(Vector3 value) { }

	[Address(RVA = "0x5ACED0", Offset = "0x5AC0D0", Length = "0xD")]
	[CalledBy(Type = typeof(GizmoConeCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600161A")]
	public void set_BaseRadius(float value) { }

	[Address(RVA = "0x3E3CB0", Offset = "0x3E2EB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001624")]
	public void set_Epsilon(ConeEpsilon value) { }

	[Address(RVA = "0x5ACEE0", Offset = "0x5AC0E0", Length = "0xD")]
	[CalledBy(Type = typeof(GizmoConeCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600161C")]
	public void set_Height(float value) { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC0F0", Length = "0xC")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001626")]
	public void set_HrzEps(float value) { }

	[Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600161E")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC100", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001618")]
	public void set_Tip(Vector3 value) { }

	[Address(RVA = "0x5ACFD0", Offset = "0x5AC1D0", Length = "0xC")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001628")]
	public void set_VertEps(float value) { }

}

