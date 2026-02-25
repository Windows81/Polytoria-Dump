namespace System.Reflection;

[Token(Token = "0x20004FB")]
public sealed class MissingMetadataException : TypeAccessException
{

	[Address(RVA = "0x13E4560", Offset = "0x13E3760", Length = "0x7")]
	[CalledBy(Type = typeof(ReflectionExecutionDomainCallbacks), Member = "CreateMissingMetadataException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeAccessException), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6002313")]
	public MissingMetadataException() { }

}

