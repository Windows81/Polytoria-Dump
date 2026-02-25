namespace System;

[Token(Token = "0x2000137")]
internal sealed class OrdinalIgnoreCaseComparer : OrdinalComparer, ISerializable
{

	[Address(RVA = "0x14BBBC0", Offset = "0x14BADC0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A01")]
	public OrdinalIgnoreCaseComparer() { }

	[Address(RVA = "0x14BBA70", Offset = "0x14BAC70", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000A02")]
	public virtual int Compare(string x, string y) { }

	[Address(RVA = "0x14BBA90", Offset = "0x14BAC90", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000A03")]
	public virtual bool Equals(string x, string y) { }

	[Address(RVA = "0x14BBAB0", Offset = "0x14BACB0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000A04")]
	public virtual int GetHashCode(string obj) { }

	[Address(RVA = "0x14BBB10", Offset = "0x14BAD10", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(SerializationInfo), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A05")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

