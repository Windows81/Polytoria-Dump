namespace System;

[Token(Token = "0x2000135")]
public class OrdinalComparer : StringComparer
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400046A")]
	private readonly bool _ignoreCase; //Field offset: 0x10

	[Address(RVA = "0x14BBA10", Offset = "0x14BAC10", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009F6")]
	internal OrdinalComparer(bool ignoreCase) { }

	[Address(RVA = "0x14BB7E0", Offset = "0x14BA9E0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Token(Token = "0x60009F7")]
	public virtual int Compare(string x, string y) { }

	[Address(RVA = "0x14BB830", Offset = "0x14BAA30", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009F8")]
	public virtual bool Equals(string x, string y) { }

	[Address(RVA = "0x14BB8A0", Offset = "0x14BAAA0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60009FA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x14BB920", Offset = "0x14BAB20", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009F9")]
	public virtual int GetHashCode(string obj) { }

	[Address(RVA = "0x14BB9B0", Offset = "0x14BABB0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009FB")]
	public virtual int GetHashCode() { }

}

