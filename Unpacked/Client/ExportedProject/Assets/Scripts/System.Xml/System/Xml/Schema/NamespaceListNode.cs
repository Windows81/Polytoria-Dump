namespace System.Xml.Schema;

[Token(Token = "0x20000D5")]
internal class NamespaceListNode : SyntaxTreeNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000479")]
	protected NamespaceList namespaceList; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400047A")]
	protected object particle; //Field offset: 0x18

	[Token(Token = "0x170001FF")]
	public virtual bool IsNullable
	{
		[Address(RVA = "0x16AC1A0", Offset = "0x16AB3A0", Length = "0x3E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60008A6")]
		 get { } //Length: 62
	}

	[Address(RVA = "0x331270", Offset = "0x330470", Length = "0x4E")]
	[CallerCount(Count = 37)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A2")]
	public NamespaceListNode(NamespaceList namespaceList, object particle) { }

	[Address(RVA = "0x16ABDC0", Offset = "0x16AAFC0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60008A5")]
	public virtual void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	[Address(RVA = "0x16ABE00", Offset = "0x16AB000", Length = "0x36B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Positions), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60008A4")]
	public virtual void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	[Address(RVA = "0x16AC1A0", Offset = "0x16AB3A0", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60008A6")]
	public virtual bool get_IsNullable() { }

	[Address(RVA = "0x16AC170", Offset = "0x16AB370", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SymbolsDictionary), Member = "GetNamespaceListSymbols", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList)}, ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60008A3")]
	public override ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

}

