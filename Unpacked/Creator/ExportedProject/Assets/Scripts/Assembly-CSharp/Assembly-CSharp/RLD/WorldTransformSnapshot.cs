namespace RLD;

[Token(Token = "0x2000268")]
public class WorldTransformSnapshot
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000993")]
	private Vector3 _worldPosition; //Field offset: 0x10
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000994")]
	private Quaternion _worldRotation; //Field offset: 0x1C
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000995")]
	private Vector3 _worldScale; //Field offset: 0x2C

	[Token(Token = "0x17000826")]
	public Vector3 WorldPosition
	{
		[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600184F")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000827")]
	public Quaternion WorldRotation
	{
		[Address(RVA = "0x573960", Offset = "0x572B60", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001850")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000828")]
	public Vector3 WorldScale
	{
		[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001851")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001854")]
	public WorldTransformSnapshot() { }

	[Address(RVA = "0x53F270", Offset = "0x53E470", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600184F")]
	public Vector3 get_WorldPosition() { }

	[Address(RVA = "0x573960", Offset = "0x572B60", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001850")]
	public Quaternion get_WorldRotation() { }

	[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001851")]
	public Vector3 get_WorldScale() { }

	[Address(RVA = "0x5C3CB0", Offset = "0x5C2EB0", Length = "0x16E")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001853")]
	public bool SameAs(Transform transform) { }

	[Address(RVA = "0x5C3E20", Offset = "0x5C3020", Length = "0x1BF")]
	[CalledBy(Type = typeof(RLDApp), Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Update_SystemCall", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTFocusCamera), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001852")]
	public void Snaphot(Transform transform) { }

}

