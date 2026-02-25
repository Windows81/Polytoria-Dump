namespace System.Xml.Schema;

[Token(Token = "0x20000D9")]
internal sealed class ChoiceNode : InteriorNode
{

	[Token(Token = "0x17000203")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x1698C90", Offset = "0x1697E90", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60008B5")]
		 get { } //Length: 142
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B7")]
	public ChoiceNode() { }

	[Address(RVA = "0x1698800", Offset = "0x1697A00", Length = "0x17C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60008B3")]
	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x1698980", Offset = "0x1697B80", Length = "0x2FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BitSet), Member = "Or", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitSet)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60008B4")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x1698C80", Offset = "0x1697E80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteriorNode), Member = "ExpandTreeNoRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode), typeof(SymbolsDictionary), typeof(Positions)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B6")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x1698C90", Offset = "0x1697E90", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60008B5")]
	public virtual bool get_IsNullable() { }

}

