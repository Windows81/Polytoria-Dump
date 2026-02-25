namespace GLTFast;

[Token(Token = "0x2000005")]
internal class AccessorNativeData : AccessorDataBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000014")]
	public NativeArray<T> data; //Field offset: 0x0

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public AccessorNativeData`1() { }

	[Address(RVA = "0x80BF20", Offset = "0x80B120", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public virtual void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public virtual void Unpin() { }

}

