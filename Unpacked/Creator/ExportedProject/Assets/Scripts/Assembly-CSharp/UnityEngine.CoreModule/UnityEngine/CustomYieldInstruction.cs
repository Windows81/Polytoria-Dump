namespace UnityEngine;

[Token(Token = "0x2000140")]
public abstract class CustomYieldInstruction : IEnumerator
{

	[Token(Token = "0x17000188")]
	public override object Current
	{
		[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000940")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000187")]
	public abstract bool keepWaiting
	{
		[Token(Token = "0x600093F")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000943")]
	protected CustomYieldInstruction() { }

	[Address(RVA = "0xC8CAA0", Offset = "0xC8BCA0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000940")]
	public override object get_Current() { }

	[Token(Token = "0x600093F")]
	public abstract bool get_keepWaiting() { }

	[Address(RVA = "0x13F0A50", Offset = "0x13EFC50", Length = "0x14")]
	[CallerCount(Count = 25)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000941")]
	public override bool MoveNext() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000942")]
	public override void Reset() { }

}

