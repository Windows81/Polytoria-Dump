namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x2000399")]
internal class CADObjRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EA3")]
	internal ObjRef objref; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EA4")]
	internal int SourceDomain; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000EA5")]
	internal Byte[] TypeInfo; //Field offset: 0x20

	[Address(RVA = "0x137BDA0", Offset = "0x137AFA0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ObjRef), Member = "SerializeType", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001BC6")]
	public CADObjRef(ObjRef o, int sourceDomain) { }

}

