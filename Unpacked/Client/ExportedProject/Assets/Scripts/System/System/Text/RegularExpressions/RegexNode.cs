namespace System.Text.RegularExpressions;

[Token(Token = "0x20000F3")]
internal sealed class RegexNode
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003FE")]
	public int NType; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003FF")]
	public List<RegexNode> Children; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000400")]
	public string Str; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000401")]
	public char Ch; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000402")]
	public int M; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000403")]
	public int N; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000404")]
	public readonly RegexOptions Options; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000405")]
	public RegexNode Next; //Field offset: 0x38

	[Address(RVA = "0x176E6B0", Offset = "0x176D8B0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000583")]
	public RegexNode(int type, RegexOptions options) { }

	[Address(RVA = "0x176E6F0", Offset = "0x176D8F0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000584")]
	public RegexNode(int type, RegexOptions options, char ch) { }

	[Address(RVA = "0x176E5C0", Offset = "0x176D7C0", Length = "0x50")]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000585")]
	public RegexNode(int type, RegexOptions options, string str) { }

	[Address(RVA = "0x176E610", Offset = "0x176D810", Length = "0x44")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000586")]
	public RegexNode(int type, RegexOptions options, int m) { }

	[Address(RVA = "0x176E660", Offset = "0x176D860", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000587")]
	public RegexNode(int type, RegexOptions options, int m, int n) { }

	[Address(RVA = "0x176D3A0", Offset = "0x176C5A0", Length = "0x12B")]
	[CalledBy(Type = typeof(RegexParser), Member = "AddGroup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexNode), Member = "MakeQuantifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanReplacement", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddConcatenate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "PopGroup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddAlternate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddConcatenate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddConcatenate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000593")]
	public void AddChild(RegexNode newChild) { }

	[Address(RVA = "0x176D520", Offset = "0x176C720", Length = "0x51")]
	[CalledBy(Type = typeof(RegexFCD), Member = "Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexPrefix))]
	[CalledBy(Type = typeof(RegexFCD), Member = "Anchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000594")]
	public RegexNode Child(int i) { }

	[Address(RVA = "0x176D4D0", Offset = "0x176C6D0", Length = "0x41")]
	[CalledBy(Type = typeof(RegexFCD), Member = "Prefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexPrefix))]
	[CalledBy(Type = typeof(RegexFCD), Member = "Anchors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000595")]
	public int ChildCount() { }

	[Address(RVA = "0x176D580", Offset = "0x176C780", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000592")]
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	[Address(RVA = "0x176D690", Offset = "0x176C890", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600058A")]
	private void MakeRep(int type, int min, int max) { }

	[Address(RVA = "0x176E210", Offset = "0x176D410", Length = "0x224")]
	[CalledBy(Type = typeof(RegexNode), Member = "AddChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexNode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexNode), Member = "ReduceConcatenation", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexNode), Member = "ReduceRep", ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexCharClass), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsSingleton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsSingletonInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "SingletonChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600058B")]
	private RegexNode Reduce() { }

	[Address(RVA = "0x176D6A0", Offset = "0x176C8A0", Length = "0x40D")]
	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexCharClass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RegexCharClass), Member = "IsMergeable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexNode), Member = "StripEnation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(RegexCharClass), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RegexCharClass))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000590")]
	private RegexNode ReduceAlternation() { }

	[Address(RVA = "0x176DAB0", Offset = "0x176CCB0", Length = "0x3C9")]
	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "InsertRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexNode), Member = "StripEnation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RegexNode))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000591")]
	private RegexNode ReduceConcatenation() { }

	[Address(RVA = "0x176DE80", Offset = "0x176D080", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600058D")]
	private RegexNode ReduceGroup() { }

	[Address(RVA = "0x176DEF0", Offset = "0x176D0F0", Length = "0x1B7")]
	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600058E")]
	private RegexNode ReduceRep() { }

	[Address(RVA = "0x176E0B0", Offset = "0x176D2B0", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "IsEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsSingleton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "IsSingletonInverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "SingletonChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600058F")]
	private RegexNode ReduceSet() { }

	[Address(RVA = "0x176E450", Offset = "0x176D650", Length = "0x67")]
	[CalledBy(Type = typeof(RegexParser), Member = "AddAlternate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "AddGroup", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Reverse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000589")]
	public RegexNode ReverseLeft() { }

	[Address(RVA = "0x176E4C0", Offset = "0x176D6C0", Length = "0xE8")]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceConcatenation", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600058C")]
	private RegexNode StripEnation(int emptyType) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000596")]
	public int Type() { }

	[Address(RVA = "0x176E5B0", Offset = "0x176D7B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000588")]
	public bool UseOptionR() { }

}

