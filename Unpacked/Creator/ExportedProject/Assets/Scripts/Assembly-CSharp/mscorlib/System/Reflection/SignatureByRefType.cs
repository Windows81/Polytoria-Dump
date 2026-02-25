namespace System.Reflection;

[Token(Token = "0x20004EC")]
internal sealed class SignatureByRefType : SignatureHasElementType
{

	[Token(Token = "0x17000467")]
	public virtual bool IsSZArray
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600222F")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000468")]
	public virtual bool IsVariableBoundArray
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002230")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000469")]
	protected virtual string Suffix
	{
		[Address(RVA = "0x13CA3D0", Offset = "0x13C95D0", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6002232")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x13CA380", Offset = "0x13C9580", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600222B")]
	internal SignatureByRefType(SignatureType elementType) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600222F")]
	public virtual bool get_IsSZArray() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002230")]
	public virtual bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x13CA3D0", Offset = "0x13C95D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6002232")]
	protected virtual string get_Suffix() { }

	[Address(RVA = "0x13CA330", Offset = "0x13C9530", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002231")]
	public virtual int GetArrayRank() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600222C")]
	protected virtual bool IsArrayImpl() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600222D")]
	protected virtual bool IsByRefImpl() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600222E")]
	protected virtual bool IsPointerImpl() { }

}

