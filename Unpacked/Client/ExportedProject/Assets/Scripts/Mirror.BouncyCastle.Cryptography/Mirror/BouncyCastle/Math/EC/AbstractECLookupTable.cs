namespace Mirror.BouncyCastle.Math.EC;

[Token(Token = "0x2000037")]
public abstract class AbstractECLookupTable : ECLookupTable
{

	[Token(Token = "0x1700001E")]
	public abstract int Size
	{
		[Token(Token = "0x6000223")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000225")]
	protected AbstractECLookupTable() { }

	[Token(Token = "0x6000223")]
	public abstract int get_Size() { }

	[Token(Token = "0x6000222")]
	public abstract ECPoint Lookup(int index) { }

	[Address(RVA = "0x1136070", Offset = "0x1135270", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000224")]
	public override ECPoint LookupVar(int index) { }

}

