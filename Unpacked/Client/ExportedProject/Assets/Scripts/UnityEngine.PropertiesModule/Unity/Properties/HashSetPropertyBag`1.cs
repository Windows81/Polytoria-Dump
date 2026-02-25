namespace Unity.Properties;

[Token(Token = "0x2000028")]
public class HashSetPropertyBag : SetPropertyBagBase<HashSet`1<TElement>, TElement>
{

	[Token(Token = "0x17000022")]
	protected virtual InstantiationKind InstantiationKind
	{
		[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000098")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x963BA0", Offset = "0x962DA0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009A")]
	public HashSetPropertyBag`1() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000098")]
	protected virtual InstantiationKind get_InstantiationKind() { }

	[Address(RVA = "0x9E88F0", Offset = "0x9E7AF0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000099")]
	protected virtual HashSet<TElement> Instantiate() { }

}

