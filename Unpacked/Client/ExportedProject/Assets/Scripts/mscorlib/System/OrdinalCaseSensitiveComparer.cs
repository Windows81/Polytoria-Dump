namespace System;

[Token(Token = "0x2000136")]
internal sealed class OrdinalCaseSensitiveComparer : OrdinalComparer, ISerializable
{

	[Address(RVA = "0x14BB790", Offset = "0x14BA990", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009FC")]
	public OrdinalCaseSensitiveComparer() { }

	[Address(RVA = "0x13B8A10", Offset = "0x13B7C10", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60009FD")]
	public virtual int Compare(string x, string y) { }

	[Address(RVA = "0x13B8B10", Offset = "0x13B7D10", Length = "0x11")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009FE")]
	public virtual bool Equals(string x, string y) { }

	[Address(RVA = "0x14BB6B0", Offset = "0x14BA8B0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009FF")]
	public virtual int GetHashCode(string obj) { }

	[Address(RVA = "0x14BB6E0", Offset = "0x14BA8E0", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180214FD0")]
	[Calls(Type = typeof(SerializationInfo), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000A00")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

