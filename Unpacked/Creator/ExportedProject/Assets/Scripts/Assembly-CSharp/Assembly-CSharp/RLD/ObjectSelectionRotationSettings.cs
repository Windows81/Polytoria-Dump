namespace RLD;

[Token(Token = "0x20002A8")]
public class ObjectSelectionRotationSettings : Settings
{
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000A45")]
	private ObjectRotationPivot _rotationPivot; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000A46")]
	private ObjectKeyRotationSettings _keyRotationSettings; //Field offset: 0x30

	[Token(Token = "0x1700086D")]
	public ObjectKeyRotationSettings KeyRotationSettings
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x600195B")]
		 get { } //Length: 95
	}

	[Token(Token = "0x1700086C")]
	public ObjectRotationPivot RotationPivot
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001959")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x600195A")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3EAFB0", Offset = "0x3EA1B0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectKeyRotationSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Settings), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600195C")]
	public ObjectSelectionRotationSettings() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600195B")]
	public ObjectKeyRotationSettings get_KeyRotationSettings() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001959")]
	public ObjectRotationPivot get_RotationPivot() { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x600195A")]
	public void set_RotationPivot(ObjectRotationPivot value) { }

}

