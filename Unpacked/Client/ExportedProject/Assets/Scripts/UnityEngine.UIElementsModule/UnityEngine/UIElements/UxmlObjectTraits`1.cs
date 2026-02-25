namespace UnityEngine.UIElements;

[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
[Token(Token = "0x20004DC")]
internal abstract class UxmlObjectTraits : BaseUxmlTraits
{

	[Address(RVA = "0x84BDF0", Offset = "0x84AFF0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002422")]
	protected UxmlObjectTraits`1() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002421")]
	public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

}

