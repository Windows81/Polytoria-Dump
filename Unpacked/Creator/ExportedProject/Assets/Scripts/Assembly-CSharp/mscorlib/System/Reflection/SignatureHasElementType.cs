namespace System.Reflection;

[Token(Token = "0x20004EE")]
internal abstract class SignatureHasElementType : SignatureType
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40013AC")]
	private readonly SignatureType _elementType; //Field offset: 0x18

	[Token(Token = "0x1700047C")]
	public virtual bool ContainsGenericParameters
	{
		[Address(RVA = "0x13CAAD0", Offset = "0x13C9CD0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002253")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700047D")]
	internal virtual SignatureType ElementType
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002254")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700047F")]
	public virtual int GenericParameterPosition
	{
		[Address(RVA = "0x13CAB00", Offset = "0x13C9D00", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6002259")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700047E")]
	public virtual Type[] GenericTypeArguments
	{
		[Address(RVA = "0x13CAB50", Offset = "0x13C9D50", Length = "0x30")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002258")]
		 get { } //Length: 48
	}

	[Token(Token = "0x17000479")]
	public virtual bool IsConstructedGenericType
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002250")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700047B")]
	public virtual bool IsGenericMethodParameter
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002252")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700047A")]
	public virtual bool IsGenericParameter
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002251")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000476")]
	public virtual bool IsGenericTypeDefinition
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002249")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000477")]
	public abstract bool IsSZArray
	{
		[Token(Token = "0x600224E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000478")]
	public abstract bool IsVariableBoundArray
	{
		[Token(Token = "0x600224F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000480")]
	public virtual string Name
	{
		[Address(RVA = "0x13CAB80", Offset = "0x13C9D80", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600225A")]
		 get { } //Length: 97
	}

	[Token(Token = "0x17000481")]
	public virtual string Namespace
	{
		[Address(RVA = "0x13CA9B0", Offset = "0x13C9BB0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600225B")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000482")]
	protected abstract string Suffix
	{
		[Token(Token = "0x600225D")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x13CA380", Offset = "0x13C9580", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002248")]
	protected SignatureHasElementType(SignatureType elementType) { }

	[Address(RVA = "0x13CAAD0", Offset = "0x13C9CD0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002253")]
	public virtual bool get_ContainsGenericParameters() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002254")]
	internal virtual SignatureType get_ElementType() { }

	[Address(RVA = "0x13CAB00", Offset = "0x13C9D00", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002259")]
	public virtual int get_GenericParameterPosition() { }

	[Address(RVA = "0x13CAB50", Offset = "0x13C9D50", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002258")]
	public virtual Type[] get_GenericTypeArguments() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002250")]
	public virtual bool get_IsConstructedGenericType() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002252")]
	public virtual bool get_IsGenericMethodParameter() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002251")]
	public virtual bool get_IsGenericParameter() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002249")]
	public virtual bool get_IsGenericTypeDefinition() { }

	[Token(Token = "0x600224E")]
	public abstract bool get_IsSZArray() { }

	[Token(Token = "0x600224F")]
	public abstract bool get_IsVariableBoundArray() { }

	[Address(RVA = "0x13CAB80", Offset = "0x13C9D80", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600225A")]
	public virtual string get_Name() { }

	[Address(RVA = "0x13CA9B0", Offset = "0x13C9BB0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600225B")]
	public virtual string get_Namespace() { }

	[Token(Token = "0x600225D")]
	protected abstract string get_Suffix() { }

	[Token(Token = "0x6002255")]
	public abstract int GetArrayRank() { }

	[Address(RVA = "0x13CA9E0", Offset = "0x13C9BE0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002257")]
	public virtual Type[] GetGenericArguments() { }

	[Address(RVA = "0x13CAA10", Offset = "0x13C9C10", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6002256")]
	public virtual Type GetGenericTypeDefinition() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600224A")]
	protected virtual bool HasElementTypeImpl() { }

	[Token(Token = "0x600224B")]
	protected abstract bool IsArrayImpl() { }

	[Token(Token = "0x600224C")]
	protected abstract bool IsByRefImpl() { }

	[Token(Token = "0x600224D")]
	protected abstract bool IsPointerImpl() { }

	[Address(RVA = "0x13CAA60", Offset = "0x13C9C60", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600225C")]
	public virtual string ToString() { }

}

