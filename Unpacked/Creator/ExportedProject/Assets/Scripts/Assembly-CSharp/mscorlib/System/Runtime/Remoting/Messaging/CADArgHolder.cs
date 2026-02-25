namespace System.Runtime.Remoting.Messaging;

[Token(Token = "0x2000398")]
internal class CADArgHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EA2")]
	public int index; //Field offset: 0x10

	[Address(RVA = "0x2D8370", Offset = "0x2D7570", Length = "0x7C")]
	[CallerCount(Count = 68)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001BC5")]
	public CADArgHolder(int i) { }

}

