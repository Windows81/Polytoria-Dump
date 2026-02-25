namespace System;

[Token(Token = "0x2000146")]
public class TypeAccessException : TypeLoadException
{

	[Address(RVA = "0x14C58D0", Offset = "0x14C4AD0", Length = "0x44")]
	[CalledBy(Type = typeof(MissingMetadataException), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B02")]
	public TypeAccessException() { }

	[Address(RVA = "0x1498C80", Offset = "0x1497E80", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B03")]
	protected TypeAccessException(SerializationInfo info, StreamingContext context) { }

}

