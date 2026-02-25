namespace RLD;

[Token(Token = "0x20001CD")]
public class MeshTransform
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000721")]
	private Vector3 _position; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000722")]
	private Quaternion _rotation; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000723")]
	private Vector3 _scale; //Field offset: 0x2C

	[Token(Token = "0x170005BB")]
	public Vector3 Position
	{
		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600122C")]
		 get { } //Length: 19
	}

	[Token(Token = "0x170005BC")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x573960", Offset = "0x572B60", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600122D")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170005BD")]
	public Vector3 Scale
	{
		[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600122E")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x5738F0", Offset = "0x572AF0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600122F")]
	public MeshTransform(Vector3 position, Quaternion rotation, Vector3 scale) { }

	[Address(RVA = "0x573860", Offset = "0x572A60", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001230")]
	public MeshTransform(Transform transform) { }

	[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600122C")]
	public Vector3 get_Position() { }

	[Address(RVA = "0x573960", Offset = "0x572B60", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600122D")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600122E")]
	public Vector3 get_Scale() { }

	[Address(RVA = "0x573350", Offset = "0x572550", Length = "0x31D")]
	[CalledBy(Type = typeof(MeshTree), Member = "OverlapVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(MeshTransform), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3Ex), Member = "GetInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001231")]
	public OBB InverseTransformOBB(OBB obb) { }

	[Address(RVA = "0x573670", Offset = "0x572870", Length = "0x121")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3Ex), Member = "GetInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "Inverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001233")]
	public Vector3 InverseTransformPoint(Vector3 point) { }

	[Address(RVA = "0x5737A0", Offset = "0x5729A0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6001232")]
	public Vector3 TransformPoint(Vector3 point) { }

}

