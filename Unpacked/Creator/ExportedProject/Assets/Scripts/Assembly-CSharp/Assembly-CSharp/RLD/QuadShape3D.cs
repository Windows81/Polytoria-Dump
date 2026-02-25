namespace RLD;

[Token(Token = "0x200024F")]
public class QuadShape3D : Shape3D
{
	[Flags]
	[Token(Token = "0x2000250")]
	internal enum WireEdgeFlags
	{
		None = 0,
		Top = 1,
		Right = 2,
		Bottom = 4,
		Left = 8,
		All = 15,
	}

	[Token(Token = "0x2000251")]
	internal class WireRenderDescriptor
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400093B")]
		private WireEdgeFlags _wireEdgeFlags; //Field offset: 0x10

		[Token(Token = "0x170007BB")]
		public WireEdgeFlags WireEdgeFlags
		{
			[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			[Token(Token = "0x600175B")]
			 get { } //Length: 4
			[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			[Token(Token = "0x600175C")]
			 set { } //Length: 4
		}

		[Address(RVA = "0x5C3C30", Offset = "0x5C2E30", Length = "0xE")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600175D")]
		public WireRenderDescriptor() { }

		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x600175B")]
		public WireEdgeFlags get_WireEdgeFlags() { }

		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600175C")]
		public void set_WireEdgeFlags(WireEdgeFlags value) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400092E")]
	private Shape3DRaycastMode _raycastMode; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400092F")]
	private Vector3 _center; //Field offset: 0x14
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000930")]
	private Vector2 _size; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000931")]
	private Quaternion _rotation; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000932")]
	private QuadEpsilon _epsilon; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000933")]
	private WireRenderDescriptor _wireRenderDesc; //Field offset: 0x48

	[Token(Token = "0x170007A5")]
	public Vector3 Center
	{
		[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600172B")]
		 get { } //Length: 19
		[Address(RVA = "0x5BD490", Offset = "0x5BC690", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600172C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x170007AE")]
	public QuadEpsilon Epsilon
	{
		[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001739")]
		 get { } //Length: 11
		[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600173A")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170007B2")]
	public float ExtrudeEps
	{
		[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001741")]
		 get { } //Length: 6
		[Address(RVA = "0x5BD4A0", Offset = "0x5BC6A0", Length = "0xC")]
		[CalledBy(Type = typeof(GizmoQuadPlaneSlider3DController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001742")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007A8")]
	public float Height
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001731")]
		 get { } //Length: 6
		[Address(RVA = "0x5BB250", Offset = "0x5BA450", Length = "0xD")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001732")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170007B1")]
	public float HeightEps
	{
		[Address(RVA = "0x5BD470", Offset = "0x5BC670", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600173F")]
		 get { } //Length: 11
		[Address(RVA = "0x5BD4B0", Offset = "0x5BC6B0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001740")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007AC")]
	public Vector3 Look
	{
		[Address(RVA = "0x5ADC90", Offset = "0x5ACE90", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001737")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007B9")]
	public static Vector3 ModelCenter
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600174B")]
		 get { } //Length: 74
	}

	[Token(Token = "0x170007B8")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600174A")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007BA")]
	public static Vector3 ModelNormal
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x600174C")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007B6")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001748")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007B7")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001749")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170007AD")]
	public Vector3 Normal
	{
		[Address(RVA = "0x5ADC90", Offset = "0x5ACE90", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001738")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007B4")]
	public Shape3DRaycastMode RaycastMode
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001745")]
		 get { } //Length: 4
		[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001746")]
		 set { } //Length: 4
	}

	[Token(Token = "0x170007AA")]
	public Vector3 Right
	{
		[Address(RVA = "0x5ADD20", Offset = "0x5ACF20", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001735")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007A9")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001733")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001734")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170007A6")]
	public Vector2 Size
	{
		[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600172D")]
		 get { } //Length: 19
		[Address(RVA = "0x5BD4D0", Offset = "0x5BC6D0", Length = "0x3B")]
		[CalledBy(Type = typeof(GizmoQuadPlaneSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GizmoThinQuad3DBorderController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RTCameraBackground), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Vector2Ex), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
		[Token(Token = "0x600172E")]
		 set { } //Length: 59
	}

	[Token(Token = "0x170007AF")]
	public Vector2 SizeEps
	{
		[Address(RVA = "0x58DF10", Offset = "0x58D110", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600173B")]
		 get { } //Length: 19
		[Address(RVA = "0x5BD4C0", Offset = "0x5BC6C0", Length = "0xC")]
		[CalledBy(Type = typeof(GizmoQuadPlaneSlider3DController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(QuadEpsilon), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
		[Token(Token = "0x600173C")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007AB")]
	public Vector3 Up
	{
		[Address(RVA = "0x5ADEA0", Offset = "0x5AD0A0", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001736")]
		 get { } //Length: 135
	}

	[Token(Token = "0x170007A7")]
	public float Width
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600172F")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001730")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170007B0")]
	public float WidthEps
	{
		[Address(RVA = "0x5BD480", Offset = "0x5BC680", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600173D")]
		 get { } //Length: 11
		[Address(RVA = "0x5BB260", Offset = "0x5BA460", Length = "0xC")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600173E")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007B3")]
	public float WireEps
	{
		[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001743")]
		 get { } //Length: 6
		[Address(RVA = "0x5BD510", Offset = "0x5BC710", Length = "0xC")]
		[CalledBy(Type = typeof(GizmoThinQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001744")]
		 set { } //Length: 12
	}

	[Token(Token = "0x170007B5")]
	public WireRenderDescriptor WireRenderDesc
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001747")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5BD350", Offset = "0x5BC550", Length = "0x115")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoQuad3DBorder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoPlaneSlider3D), typeof(GizmoHandle), typeof(QuadShape3D)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTCameraBackground), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600175A")]
	public QuadShape3D() { }

	[Address(RVA = "0x5BBE80", Offset = "0x5BB080", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[DeduplicatedMethod]
	[Token(Token = "0x600174D")]
	public void AlignNormal(Vector3 axis) { }

	[Address(RVA = "0x5BC110", Offset = "0x5BB310", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[DeduplicatedMethod]
	[Token(Token = "0x600174E")]
	public void AlignRight(Vector3 axis) { }

	[Address(RVA = "0x5BC3A0", Offset = "0x5BB5A0", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Token(Token = "0x600174F")]
	public void AlignUp(Vector3 axis) { }

	[Address(RVA = "0x5BC630", Offset = "0x5BB830", Length = "0x1BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuadMath), Member = "Contains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001757")]
	public bool ContainsPoint(Vector3 point, bool checkOnPlane) { }

	[Address(RVA = "0x561A60", Offset = "0x560C60", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600172B")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x3EAB10", Offset = "0x3E9D10", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001739")]
	public QuadEpsilon get_Epsilon() { }

	[Address(RVA = "0x3B4310", Offset = "0x3B3510", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001741")]
	public float get_ExtrudeEps() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001731")]
	public float get_Height() { }

	[Address(RVA = "0x5BD470", Offset = "0x5BC670", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600173F")]
	public float get_HeightEps() { }

	[Address(RVA = "0x5ADC90", Offset = "0x5ACE90", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001737")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600174B")]
	public static Vector3 get_ModelCenter() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600174A")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x600174C")]
	public static Vector3 get_ModelNormal() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001748")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001749")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x5ADC90", Offset = "0x5ACE90", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001738")]
	public Vector3 get_Normal() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001745")]
	public Shape3DRaycastMode get_RaycastMode() { }

	[Address(RVA = "0x5ADD20", Offset = "0x5ACF20", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001735")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001733")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x53E610", Offset = "0x53D810", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600172D")]
	public Vector2 get_Size() { }

	[Address(RVA = "0x58DF10", Offset = "0x58D110", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600173B")]
	public Vector2 get_SizeEps() { }

	[Address(RVA = "0x5ADEA0", Offset = "0x5AD0A0", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001736")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600172F")]
	public float get_Width() { }

	[Address(RVA = "0x5BD480", Offset = "0x5BC680", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600173D")]
	public float get_WidthEps() { }

	[Address(RVA = "0x3B43C0", Offset = "0x3B35C0", Length = "0x6")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001743")]
	public float get_WireEps() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001747")]
	public WireRenderDescriptor get_WireRenderDesc() { }

	[Address(RVA = "0x5BC7F0", Offset = "0x5BB9F0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadMath), Member = "Calc3DQuadCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001759")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5BC860", Offset = "0x5BBA60", Length = "0x48")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QuadMath), Member = "Calc3DQuadCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001750")]
	public List<Vector3> GetCornerPoints() { }

	[Address(RVA = "0x5BC8B0", Offset = "0x5BBAB0", Length = "0x6F")]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "MakeSliderPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GizmoTransform), typeof(PlaneId), typeof(GizmoLineSlider3D), typeof(GizmoLineSlider3D), typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "GetQuadCornerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuadCorner)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "SetQuadCornerPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(QuadCorner), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(QuadMath), Member = "Calc3DQuadCorner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Quaternion), typeof(QuadCorner)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001751")]
	public Vector3 GetCornerPosition(QuadCorner quadCorner) { }

	[Address(RVA = "0x5BC860", Offset = "0x5BBA60", Length = "0x48")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QuadMath), Member = "Calc3DQuadCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001758")]
	public List<Vector3> GetCorners() { }

	[Address(RVA = "0x5BCAE0", Offset = "0x5BBCE0", Length = "0x234")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuadMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001755")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5BC920", Offset = "0x5BBB20", Length = "0x1BB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuadMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001756")]
	public virtual bool RaycastWire(Ray ray, out float t) { }

	[Address(RVA = "0x5BCD20", Offset = "0x5BBF20", Length = "0x189")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitQuadXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001753")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5BCEB0", Offset = "0x5BC0B0", Length = "0x3DD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(QuadMath), Member = "Calc3DQuadCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(GLRenderer), Member = "DrawLine3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitWireQuadXY", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001754")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x5BD490", Offset = "0x5BC690", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600172C")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x3EAB40", Offset = "0x3E9D40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600173A")]
	public void set_Epsilon(QuadEpsilon value) { }

	[Address(RVA = "0x5BD4A0", Offset = "0x5BC6A0", Length = "0xC")]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider3DController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001742")]
	public void set_ExtrudeEps(float value) { }

	[Address(RVA = "0x5BB250", Offset = "0x5BA450", Length = "0xD")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001732")]
	public void set_Height(float value) { }

	[Address(RVA = "0x5BD4B0", Offset = "0x5BC6B0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001740")]
	public void set_HeightEps(float value) { }

	[Address(RVA = "0x2C33C0", Offset = "0x2C25C0", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001746")]
	public void set_RaycastMode(Shape3DRaycastMode value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001734")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x5BD4D0", Offset = "0x5BC6D0", Length = "0x3B")]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoThinQuad3DBorderController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTCameraBackground), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Vector2Ex), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Token(Token = "0x600172E")]
	public void set_Size(Vector2 value) { }

	[Address(RVA = "0x5BD4C0", Offset = "0x5BC6C0", Length = "0xC")]
	[CalledBy(Type = typeof(GizmoQuadPlaneSlider3DController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(QuadEpsilon), Member = "set_SizeEps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Token(Token = "0x600173C")]
	public void set_SizeEps(Vector2 value) { }

	[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001730")]
	public void set_Width(float value) { }

	[Address(RVA = "0x5BB260", Offset = "0x5BA460", Length = "0xC")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600173E")]
	public void set_WidthEps(float value) { }

	[Address(RVA = "0x5BD510", Offset = "0x5BC710", Length = "0xC")]
	[CalledBy(Type = typeof(GizmoThinQuad3DBorderController), Member = "UpdateEpsilons", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001744")]
	public void set_WireEps(float value) { }

	[Address(RVA = "0x5BD290", Offset = "0x5BC490", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(QuadMath), Member = "Calc3DQuadCorner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Quaternion), typeof(QuadCorner)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001752")]
	public void SetCornerPointPosition(QuadCorner quadCorner, Vector3 position) { }

}

