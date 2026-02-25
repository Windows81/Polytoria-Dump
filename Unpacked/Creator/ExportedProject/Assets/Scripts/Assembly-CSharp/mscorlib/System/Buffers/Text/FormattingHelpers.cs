namespace System.Buffers.Text;

[Token(Token = "0x2000619")]
internal static class FormattingHelpers
{

	[Address(RVA = "0x143E6E0", Offset = "0x143D8E0", Length = "0x96")]
	[CalledBy(Type = typeof(Number), Member = "NegativeInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryNegativeInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(int), typeof(string), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Number), Member = "UInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Number), Member = "TryUInt64ToDecStr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(int), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C79")]
	public static int CountDigits(ulong value) { }

	[Address(RVA = "0x143E780", Offset = "0x143D980", Length = "0x58")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002C7A")]
	public static int CountDigits(uint value) { }

	[Address(RVA = "0x143E7E0", Offset = "0x143D9E0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002C7B")]
	public static int CountHexDigits(ulong value) { }

}

