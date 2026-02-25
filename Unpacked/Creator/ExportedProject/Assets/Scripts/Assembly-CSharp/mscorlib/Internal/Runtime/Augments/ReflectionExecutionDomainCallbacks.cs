namespace Internal.Runtime.Augments;

[Token(Token = "0x200008E")]
internal class ReflectionExecutionDomainCallbacks
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000261")]
	public ReflectionExecutionDomainCallbacks() { }

	[Address(RVA = "0x12FA0F0", Offset = "0x12F92F0", Length = "0x44")]
	[CalledBy(Type = typeof(CustomAttributeNamedArgument), Member = "get_MemberInfo", ReturnType = typeof(MemberInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MissingMetadataException), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000260")]
	internal Exception CreateMissingMetadataException(Type attributeType) { }

}

