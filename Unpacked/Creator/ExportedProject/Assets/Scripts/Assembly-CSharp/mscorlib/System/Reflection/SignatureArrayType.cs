namespace System.Reflection;

[Token(Token = "0x20004EB")]
internal sealed class SignatureArrayType : SignatureHasElementType
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40013A8")]
	private readonly int _rank; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40013A9")]
	private readonly bool _isMultiDim; //Field offset: 0x24

	[Token(Token = "0x17000464")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x13CA270", Offset = "0x13C9470", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002227")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000465")]
	public virtual bool IsVariableBoundArray
	{
		[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002228")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000466")]
	protected virtual string Suffix
	{
		[Address(RVA = "0x13CA280", Offset = "0x13C9480", Length = "0xA3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Token(Token = "0x600222A")]
		 get { } //Length: 163
	}

	[Address(RVA = "0x13CA200", Offset = "0x13C9400", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002223")]
	internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim) { }

	[Address(RVA = "0x13CA270", Offset = "0x13C9470", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002227")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x387940", Offset = "0x386B40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002228")]
	public virtual bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x13CA280", Offset = "0x13C9480", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x600222A")]
	protected virtual string get_Suffix() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002229")]
	public virtual int GetArrayRank() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002224")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002225")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002226")]
	protected virtual bool IsPointerImpl() { }

}

