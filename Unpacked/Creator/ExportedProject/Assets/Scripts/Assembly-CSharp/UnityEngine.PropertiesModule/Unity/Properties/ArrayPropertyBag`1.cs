namespace Unity.Properties;

[Token(Token = "0x2000025")]
public sealed class ArrayPropertyBag : IndexedCollectionPropertyBag<TElement[], TElement>
{

	[Token(Token = "0x17000020")]
	protected virtual InstantiationKind InstantiationKind
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008B")]
		 get { } //Length: 6
	}

	[Address(RVA = "0xAF8470", Offset = "0xAF7670", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008E")]
	public ArrayPropertyBag`1() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008B")]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[Address(RVA = "0xAF8450", Offset = "0xAF7650", Length = "0x18")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008D")]
	protected virtual TElement[] Instantiate() { }

	[Address(RVA = "0xAF8410", Offset = "0xAF7610", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600008C")]
	protected virtual TElement[] InstantiateWithCount(int count) { }

}

