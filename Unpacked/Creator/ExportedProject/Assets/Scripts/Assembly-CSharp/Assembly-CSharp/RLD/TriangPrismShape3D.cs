namespace RLD;

[Token(Token = "0x2000263")]
public class TriangPrismShape3D : Shape3D
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400097E")]
	private Vector3 _baseCenter; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400097F")]
	private float _width; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000980")]
	private float _height; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000981")]
	private float _depth; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000982")]
	private Quaternion _rotation; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000983")]
	private PrismEpsilon _epsilon; //Field offset: 0x38

	[Token(Token = "0x17000810")]
	public Vector3 BaseCenter
	{
		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600181B")]
		 get { } //Length: 19
		[Address(RVA = "0x58D8B0", Offset = "0x58CAB0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600181C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000813")]
	public Vector3 Center
	{
		[Address(RVA = "0x5C2FE0", Offset = "0x5C21E0", Length = "0xF6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001821")]
		 get { } //Length: 246
		[Address(RVA = "0x5C3550", Offset = "0x5C2750", Length = "0xED")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001822")]
		 set { } //Length: 237
	}

	[Token(Token = "0x1700081B")]
	public Vector3 CentralAxis
	{
		[Address(RVA = "0x5ADEA0", Offset = "0x5AD0A0", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001831")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000817")]
	public float Depth
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001829")]
		 get { } //Length: 6
		[Address(RVA = "0x5BB250", Offset = "0x5BA450", Length = "0xD")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x600182A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000818")]
	public PrismEpsilon Epsilon
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600182B")]
		 get { } //Length: 4
		[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600182C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000812")]
	public Vector3 FrontCenter
	{
		[Address(RVA = "0x5C30E0", Offset = "0x5C22E0", Length = "0x1C9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600181F")]
		 get { } //Length: 457
		[Address(RVA = "0x5C3640", Offset = "0x5C2840", Length = "0x19F")]
		[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001820")]
		 set { } //Length: 415
	}

	[Token(Token = "0x17000816")]
	public float Height
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001827")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001828")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700081E")]
	public Vector3 Look
	{
		[Address(RVA = "0x5ADC90", Offset = "0x5ACE90", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001834")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000814")]
	public Vector3 MidTip
	{
		[Address(RVA = "0x5C32B0", Offset = "0x5C24B0", Length = "0x1AF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001823")]
		 get { } //Length: 431
		[Address(RVA = "0x5C37E0", Offset = "0x5C29E0", Length = "0x1A3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x6001824")]
		 set { } //Length: 419
	}

	[Token(Token = "0x17000822")]
	public static Vector3 ModelBaseCenter
	{
		[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001838")]
		 get { } //Length: 74
	}

	[Token(Token = "0x17000821")]
	public static Vector3 ModelLook
	{
		[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001837")]
		 get { } //Length: 75
	}

	[Token(Token = "0x1700081F")]
	public static Vector3 ModelRight
	{
		[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001835")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000820")]
	public static Vector3 ModelUp
	{
		[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001836")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000819")]
	public float PtContainEps
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600182D")]
		 get { } //Length: 6
		[Address(RVA = "0x5BB260", Offset = "0x5BA460", Length = "0xC")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600182E")]
		 set { } //Length: 12
	}

	[Token(Token = "0x1700081C")]
	public Vector3 Right
	{
		[Address(RVA = "0x5ADD20", Offset = "0x5ACF20", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001832")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700081A")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600182F")]
		 get { } //Length: 11
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001830")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000811")]
	public Vector3 TopCenter
	{
		[Address(RVA = "0x5C3460", Offset = "0x5C2660", Length = "0xE2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600181D")]
		 get { } //Length: 226
		[Address(RVA = "0x5C3990", Offset = "0x5C2B90", Length = "0xCC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600181E")]
		 set { } //Length: 204
	}

	[Token(Token = "0x1700081D")]
	public Vector3 Up
	{
		[Address(RVA = "0x5ADEA0", Offset = "0x5AD0A0", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[DeduplicatedMethod]
		[Token(Token = "0x6001833")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000815")]
	public float Width
	{
		[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001825")]
		 get { } //Length: 6
		[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001826")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x5BB0C0", Offset = "0x5BA2C0", Length = "0x97")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001842")]
	public TriangPrismShape3D() { }

	[Address(RVA = "0x5BBE80", Offset = "0x5BB080", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[DeduplicatedMethod]
	[Token(Token = "0x600183B")]
	public void AlignDepth(Vector3 axis) { }

	[Address(RVA = "0x5BAA90", Offset = "0x5B9C90", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[DeduplicatedMethod]
	[Token(Token = "0x600183A")]
	public void AlignHeight(Vector3 axis) { }

	[Address(RVA = "0x5BC110", Offset = "0x5BB310", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001839")]
	public void AlignWidth(Vector3 axis) { }

	[Address(RVA = "0x5C2AB0", Offset = "0x5C1CB0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrismMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion), typeof(PrismEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001840")]
	public bool ContainsPoint(Vector3 point) { }

	[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600181B")]
	public Vector3 get_BaseCenter() { }

	[Address(RVA = "0x5C2FE0", Offset = "0x5C21E0", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001821")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x5ADEA0", Offset = "0x5AD0A0", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001831")]
	public Vector3 get_CentralAxis() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001829")]
	public float get_Depth() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600182B")]
	public PrismEpsilon get_Epsilon() { }

	[Address(RVA = "0x5C30E0", Offset = "0x5C22E0", Length = "0x1C9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600181F")]
	public Vector3 get_FrontCenter() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001827")]
	public float get_Height() { }

	[Address(RVA = "0x5ADC90", Offset = "0x5ACE90", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001834")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x5C32B0", Offset = "0x5C24B0", Length = "0x1AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001823")]
	public Vector3 get_MidTip() { }

	[Address(RVA = "0x2BC6D0", Offset = "0x2BB8D0", Length = "0x4A")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001838")]
	public static Vector3 get_ModelBaseCenter() { }

	[Address(RVA = "0x5A8C30", Offset = "0x5A7E30", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001837")]
	public static Vector3 get_ModelLook() { }

	[Address(RVA = "0x5A8C80", Offset = "0x5A7E80", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001835")]
	public static Vector3 get_ModelRight() { }

	[Address(RVA = "0x5A8CD0", Offset = "0x5A7ED0", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001836")]
	public static Vector3 get_ModelUp() { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600182D")]
	public float get_PtContainEps() { }

	[Address(RVA = "0x5ADD20", Offset = "0x5ACF20", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001832")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x3B0170", Offset = "0x3AF370", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600182F")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x5C3460", Offset = "0x5C2660", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600181D")]
	public Vector3 get_TopCenter() { }

	[Address(RVA = "0x5ADEA0", Offset = "0x5AD0A0", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001833")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x3B2170", Offset = "0x3B1370", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001825")]
	public float get_Width() { }

	[Address(RVA = "0x5C2B40", Offset = "0x5C1D40", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrismMath), Member = "CalcTriangPrismCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001841")]
	public virtual AABB GetAABB() { }

	[Address(RVA = "0x5C2BD0", Offset = "0x5C1DD0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600183E")]
	public void MakeEquilateral(float sideLength) { }

	[Address(RVA = "0x5C2C30", Offset = "0x5C1E30", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PrismMath), Member = "RaycastTriangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600183F")]
	public virtual bool Raycast(Ray ray, out float t) { }

	[Address(RVA = "0x5C2CC0", Offset = "0x5C1EC0", Length = "0x186")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitTriangularPrism", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600183C")]
	public virtual void RenderSolid() { }

	[Address(RVA = "0x5C2E50", Offset = "0x5C2050", Length = "0x186")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MeshPool), Member = "get_UnitWireTriangularPrism", ReturnType = typeof(Mesh))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Graphics), Member = "DrawMeshNow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600183D")]
	public virtual void RenderWire() { }

	[Address(RVA = "0x58D8B0", Offset = "0x58CAB0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600181C")]
	public void set_BaseCenter(Vector3 value) { }

	[Address(RVA = "0x5C3550", Offset = "0x5C2750", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001822")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x5BB250", Offset = "0x5BA450", Length = "0xD")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600182A")]
	public void set_Depth(float value) { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600182C")]
	public void set_Epsilon(PrismEpsilon value) { }

	[Address(RVA = "0x5C3640", Offset = "0x5C2840", Length = "0x19F")]
	[CalledBy(Type = typeof(GizmoTriPrismCap3DController), Member = "UpdateTransforms", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001820")]
	public void set_FrontCenter(Vector3 value) { }

	[Address(RVA = "0x5A8E60", Offset = "0x5A8060", Length = "0xD")]
	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001828")]
	public void set_Height(float value) { }

	[Address(RVA = "0x5C37E0", Offset = "0x5C29E0", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001824")]
	public void set_MidTip(Vector3 value) { }

	[Address(RVA = "0x5BB260", Offset = "0x5BA460", Length = "0xC")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600182E")]
	public void set_PtContainEps(float value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001830")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x5C3990", Offset = "0x5C2B90", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600181E")]
	public void set_TopCenter(Vector3 value) { }

	[Address(RVA = "0x5A8E90", Offset = "0x5A8090", Length = "0xD")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001826")]
	public void set_Width(float value) { }

}

