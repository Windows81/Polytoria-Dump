namespace System.Reflection;

[Token(Token = "0x20004DF")]
public abstract class MethodInfo : MethodBase
{

	[Token(Token = "0x1700044D")]
	internal override int GenericParameterCount
	{
		[Address(RVA = "0x13BE870", Offset = "0x13BDA70", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60021DF")]
		internal get { } //Length: 41
	}

	[Token(Token = "0x1700044A")]
	public virtual MemberTypes MemberType
	{
		[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x60021D3")]
		 get { } //Length: 6
	}

	[Token(Token = "0x1700044B")]
	public override ParameterInfo ReturnParameter
	{
		[Address(RVA = "0x13BE8A0", Offset = "0x13BDAA0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60021D4")]
		 get { } //Length: 39
	}

	[Token(Token = "0x1700044C")]
	public override Type ReturnType
	{
		[Address(RVA = "0x13BE8D0", Offset = "0x13BDAD0", Length = "0x27")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60021D5")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021D2")]
	protected MethodInfo() { }

	[Address(RVA = "0x13BE6E0", Offset = "0x13BD8E0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021D9")]
	public override Delegate CreateDelegate(Type delegateType) { }

	[Address(RVA = "0x13BE730", Offset = "0x13BD930", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021DA")]
	public override Delegate CreateDelegate(Type delegateType, object target) { }

	[Address(RVA = "0x13B6C10", Offset = "0x13B5E10", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DB")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x13BE870", Offset = "0x13BDA70", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60021DF")]
	internal override int get_GenericParameterCount() { }

	[Address(RVA = "0x3CE2B0", Offset = "0x3CD4B0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021D3")]
	public virtual MemberTypes get_MemberType() { }

	[Address(RVA = "0x13BE8A0", Offset = "0x13BDAA0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021D4")]
	public override ParameterInfo get_ReturnParameter() { }

	[Address(RVA = "0x13BE8D0", Offset = "0x13BDAD0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021D5")]
	public override Type get_ReturnType() { }

	[Address(RVA = "0x13BE780", Offset = "0x13BD980", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021D6")]
	public virtual Type[] GetGenericArguments() { }

	[Address(RVA = "0x13BE7D0", Offset = "0x13BD9D0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021D7")]
	public override MethodInfo GetGenericMethodDefinition() { }

	[Address(RVA = "0x2D8E50", Offset = "0x2D8050", Length = "0x7")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DC")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13BE820", Offset = "0x13BDA20", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60021D8")]
	public override MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	[Address(RVA = "0x13B6D10", Offset = "0x13B5F10", Length = "0x29")]
	[CallerCount(Count = 216)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DD")]
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	[Address(RVA = "0x13B8160", Offset = "0x13B7360", Length = "0x3E")]
	[CallerCount(Count = 129)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60021DE")]
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

}

