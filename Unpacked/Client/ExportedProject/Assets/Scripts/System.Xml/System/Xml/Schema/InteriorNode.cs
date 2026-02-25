namespace System.Xml.Schema;

[Token(Token = "0x20000D6")]
internal abstract class InteriorNode : SyntaxTreeNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400047B")]
	private SyntaxTreeNode leftChild; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400047C")]
	private SyntaxTreeNode rightChild; //Field offset: 0x18

	[Token(Token = "0x17000200")]
	public SyntaxTreeNode LeftChild
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A7")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000201")]
	public SyntaxTreeNode RightChild
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60008A9")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60008AA")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AD")]
	protected InteriorNode() { }

	[Address(RVA = "0x16ABC20", Offset = "0x16AAE20", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60008AC")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x16ABA00", Offset = "0x16AAC00", Length = "0x214")]
	[CalledBy(Type = typeof(SequenceNode), Member = "ExpandTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode), typeof(SymbolsDictionary), typeof(Positions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChoiceNode), Member = "ExpandTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode), typeof(SymbolsDictionary), typeof(Positions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60008AB")]
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A7")]
	public SyntaxTreeNode get_LeftChild() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A9")]
	public SyntaxTreeNode get_RightChild() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A8")]
	public void set_LeftChild(SyntaxTreeNode value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60008AA")]
	public void set_RightChild(SyntaxTreeNode value) { }

}

