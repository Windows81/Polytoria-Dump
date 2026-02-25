namespace System.Xml.Schema;

[Token(Token = "0x20000D7")]
internal sealed class SequenceNode : InteriorNode
{
	[Token(Token = "0x20000D8")]
	private struct SequenceConstructPosContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400047D")]
		public SequenceNode this_; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400047E")]
		public BitSet firstpos; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400047F")]
		public BitSet lastpos; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000480")]
		public BitSet lastposLeft; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000481")]
		public BitSet firstposRight; //Field offset: 0x20

		[Address(RVA = "0x16B1170", Offset = "0x16B0370", Length = "0x6F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60008B2")]
		public SequenceConstructPosContext(SequenceNode node, BitSet firstpos, BitSet lastpos) { }

	}


	[Token(Token = "0x17000202")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x16B19C0", Offset = "0x16B0BC0", Length = "0x19D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x60008AF")]
		 get { } //Length: 413
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B1")]
	public SequenceNode() { }

	[Address(RVA = "0x16B11E0", Offset = "0x16B03E0", Length = "0x7DF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Xml.Schema.SequenceNode+SequenceConstructPosContext>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SequenceConstructPosContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(BitSet), Member = "EnsureLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitSet), Member = "Clone", ReturnType = typeof(BitSet))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Xml.Schema.SequenceNode+SequenceConstructPosContext>), Member = "Pop", ReturnType = typeof(SequenceConstructPosContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[Token(Token = "0x60008AE")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x1698C80", Offset = "0x1697E80", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InteriorNode), Member = "ExpandTreeNoRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InteriorNode), typeof(SymbolsDictionary), typeof(Positions)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60008B0")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x16B19C0", Offset = "0x16B0BC0", Length = "0x19D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60008AF")]
	public virtual bool get_IsNullable() { }

}

