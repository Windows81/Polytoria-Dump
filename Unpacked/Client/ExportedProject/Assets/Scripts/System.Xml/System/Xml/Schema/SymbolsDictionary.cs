namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x20000D0")]
internal class SymbolsDictionary
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400046F")]
	private int last; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000470")]
	private Hashtable names; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000471")]
	private Hashtable wildcards; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000472")]
	private ArrayList particles; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000473")]
	private object particleLast; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000474")]
	private bool isUpaEnforced; //Field offset: 0x38

	[Token(Token = "0x170001F7")]
	public int Count
	{
		[Address(RVA = "0x16B3570", Offset = "0x16B2770", Length = "0x6")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000889")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001F8")]
	public bool IsUpaEnforced
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600088A")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600088B")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x16B34D0", Offset = "0x16B26D0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000888")]
	public SymbolsDictionary() { }

	[Address(RVA = "0x16B2880", Offset = "0x16B1A80", Length = "0x127")]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContentValidator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600088C")]
	public int AddName(XmlQualifiedName name, object particle) { }

	[Address(RVA = "0x16B29B0", Offset = "0x16B1BB0", Length = "0x27F")]
	[CalledBy(Type = typeof(ParticleContentValidator), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NamespaceList), Member = "get_Enumerate", ReturnType = typeof(ICollection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(SymbolsDictionary), Member = "AddWildcard", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600088D")]
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	[Address(RVA = "0x16B2C30", Offset = "0x16B1E30", Length = "0x16A")]
	[CalledBy(Type = typeof(SymbolsDictionary), Member = "AddNamespaceList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NamespaceList), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600088E")]
	private void AddWildcard(string wildcard, object particle) { }

	[Address(RVA = "0x16B2DA0", Offset = "0x16B1FA0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000890")]
	public bool Exists(XmlQualifiedName name) { }

	[Address(RVA = "0x16B3570", Offset = "0x16B2770", Length = "0x6")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000889")]
	public int get_Count() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600088A")]
	public bool get_IsUpaEnforced() { }

	[Address(RVA = "0x16B2DE0", Offset = "0x16B1FE0", Length = "0x6A9")]
	[CalledBy(Type = typeof(NamespaceListNode), Member = "GetResolvedSymbols", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SymbolsDictionary)}, ReturnType = typeof(ICollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(NamespaceList), Member = "Allows", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[Token(Token = "0x600088F")]
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	[Address(RVA = "0x16B3490", Offset = "0x16B2690", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000891")]
	public object GetParticle(int symbol) { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600088B")]
	public void set_IsUpaEnforced(bool value) { }

}

