namespace System.Xml.Schema;

[Token(Token = "0x20000DA")]
internal sealed class PlusNode : InteriorNode
{

	[Token(Token = "0x17000204")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x1659F20", Offset = "0x1659120", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008B9")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008BA")]
	public PlusNode() { }

	[Address(RVA = "0x16B0AD0", Offset = "0x16AFCD0", Length = "0x1BA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BitSet), Member = "NextSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B8")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x1659F20", Offset = "0x1659120", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B9")]
	public virtual bool get_IsNullable() { }

}

