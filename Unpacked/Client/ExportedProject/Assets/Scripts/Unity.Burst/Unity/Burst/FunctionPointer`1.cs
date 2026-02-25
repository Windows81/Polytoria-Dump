namespace Unity.Burst;

[IsReadOnly]
[Token(Token = "0x200001B")]
public struct FunctionPointer
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000041")]
	private readonly IntPtr _ptr; //Field offset: 0x0

	[Token(Token = "0x1700000D")]
	public T Invoke
	{
		[Address(RVA = "0xC49900", Offset = "0xC48B00", Length = "0x76")]
		[CalledBy(Type = "GLTFast.Jobs.ConvertVector3SparseJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = "allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Block&"}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(Marshal), Member = "GetDelegateForFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "TDelegate")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000074")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000E")]
	public bool IsCreated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000075")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700000C")]
	public IntPtr Value
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000073")]
		 get { } //Length: 4
	}

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000072")]
	public FunctionPointer`1(IntPtr ptr) { }

	[Address(RVA = "0xC49900", Offset = "0xC48B00", Length = "0x76")]
	[CalledBy(Type = "GLTFast.Jobs.ConvertVector3SparseJob", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.AllocatorManager", Member = "allocate_block", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Block&"}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Marshal), Member = "GetDelegateForFunctionPointer", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "TDelegate")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000074")]
	public T get_Invoke() { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	public bool get_IsCreated() { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000073")]
	public IntPtr get_Value() { }

}

