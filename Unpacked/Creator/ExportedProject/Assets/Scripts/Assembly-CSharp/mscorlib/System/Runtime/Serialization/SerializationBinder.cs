namespace System.Runtime.Serialization;

[Token(Token = "0x20003CF")]
public abstract class SerializationBinder
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001CEE")]
	protected SerializationBinder() { }

	[Address(RVA = "0x1392820", Offset = "0x1391A20", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001CEC")]
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	[Token(Token = "0x6001CED")]
	public abstract Type BindToType(string assemblyName, string typeName) { }

}

