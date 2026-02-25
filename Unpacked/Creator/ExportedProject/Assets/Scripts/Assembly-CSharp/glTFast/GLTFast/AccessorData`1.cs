namespace GLTFast;

[Token(Token = "0x2000004")]
internal class AccessorData : AccessorDataBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000012")]
	public T[] data; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000013")]
	public GCHandle gcHandle; //Field offset: 0x0

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000006")]
	public AccessorData`1() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public virtual void Dispose() { }

	[Address(RVA = "0x80BEF0", Offset = "0x80B0F0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public virtual void Unpin() { }

}

