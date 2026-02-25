namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
[Token(Token = "0x200046C")]
public sealed class DecimalConstantAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400124F")]
	private decimal _dec; //Field offset: 0x10

	[Token(Token = "0x170003F7")]
	public decimal Value
	{
		[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600201F")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x13B7B60", Offset = "0x13B6D60", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CLSCompliant(False)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600201E")]
	public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) { }

	[Address(RVA = "0x3E81B0", Offset = "0x3E73B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600201F")]
	public decimal get_Value() { }

}

