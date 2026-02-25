namespace System;

[Token(Token = "0x20000D2")]
public class EntryPointNotFoundException : TypeLoadException
{

	[Address(RVA = "0x1499F50", Offset = "0x1499150", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600069A")]
	public EntryPointNotFoundException() { }

	[Address(RVA = "0x1499FA0", Offset = "0x14991A0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600069B")]
	public EntryPointNotFoundException(string message) { }

	[Address(RVA = "0x1498C80", Offset = "0x1497E80", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600069C")]
	protected EntryPointNotFoundException(SerializationInfo info, StreamingContext context) { }

}

