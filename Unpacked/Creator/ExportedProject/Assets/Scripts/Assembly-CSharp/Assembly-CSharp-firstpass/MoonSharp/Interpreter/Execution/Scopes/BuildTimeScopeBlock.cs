namespace MoonSharp.Interpreter.Execution.Scopes;

[Token(Token = "0x2000153")]
internal class BuildTimeScopeBlock
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400056B")]
	private BuildTimeScopeBlock <Parent>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400056C")]
	private List<BuildTimeScopeBlock> <ChildNodes>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400056D")]
	private RuntimeScopeBlock <ScopeBlock>k__BackingField; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400056E")]
	private Dictionary<String, SymbolRef> m_DefinedNames; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400056F")]
	private List<GotoStatement> m_PendingGotos; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000570")]
	private Dictionary<String, LabelStatement> m_LocalLabels; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000571")]
	private string m_LastDefinedName; //Field offset: 0x40

	[Token(Token = "0x170001A4")]
	internal List<BuildTimeScopeBlock> ChildNodes
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CA7")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CA8")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001A3")]
	internal BuildTimeScopeBlock Parent
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CA5")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CA6")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001A5")]
	internal RuntimeScopeBlock ScopeBlock
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CA9")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CAA")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x3759B0", Offset = "0x374BB0", Length = "0x10F")]
	[CalledBy(Type = typeof(BuildTimeScopeBlock), Member = "AddChild", ReturnType = typeof(BuildTimeScopeBlock))]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "PushBlock", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000CAC")]
	internal BuildTimeScopeBlock(BuildTimeScopeBlock parent) { }

	[Address(RVA = "0x374900", Offset = "0x373B00", Length = "0xDA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuildTimeScopeBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CAD")]
	internal BuildTimeScopeBlock AddChild() { }

	[Address(RVA = "0x374C60", Offset = "0x373E60", Length = "0xA8")]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "TryDefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SymbolRef), Member = "Local", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CAF")]
	internal SymbolRef Define(string name) { }

	[Address(RVA = "0x3749E0", Offset = "0x373BE0", Length = "0x278")]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "DefineLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelStatement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LabelStatement), Member = "SetDefinedVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009B90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000CB1")]
	internal void DefineLabel(LabelStatement label) { }

	[Address(RVA = "0x374D10", Offset = "0x373F10", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Token(Token = "0x6000CAE")]
	internal SymbolRef Find(string name) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CA7")]
	internal List<BuildTimeScopeBlock> get_ChildNodes() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CA5")]
	internal BuildTimeScopeBlock get_Parent() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CA9")]
	internal RuntimeScopeBlock get_ScopeBlock() { }

	[Address(RVA = "0x374D60", Offset = "0x373F60", Length = "0x133")]
	[CalledBy(Type = typeof(BuildTimeScopeBlock), Member = "ResolveGotos", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "RegisterGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoStatement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(GotoStatement), Member = "SetDefinedVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CB2")]
	internal void RegisterGoto(GotoStatement gotostat) { }

	[Address(RVA = "0x374EA0", Offset = "0x3740A0", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CAB")]
	internal void Rename(string name) { }

	[Address(RVA = "0x374FD0", Offset = "0x3741D0", Length = "0x445")]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "PopBlock", ReturnType = typeof(RuntimeScopeBlock))]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "ResolveLRefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = "RegisterGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoStatement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(SyntaxErrorException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LabelStatement), Member = "RegisterGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoStatement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x6000CB3")]
	internal void ResolveGotos() { }

	[Address(RVA = "0x375420", Offset = "0x374620", Length = "0x584")]
	[CalledBy(Type = typeof(BuildTimeScopeBlock), Member = "ResolveLRefs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuildTimeScopeFrame)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "ResolveLRefs", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = "ResolveLRefs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuildTimeScopeFrame)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x6000CB0")]
	internal int ResolveLRefs(BuildTimeScopeFrame buildTimeScopeFrame) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CA8")]
	private void set_ChildNodes(List<BuildTimeScopeBlock> value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CA6")]
	private void set_Parent(BuildTimeScopeBlock value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CAA")]
	private void set_ScopeBlock(RuntimeScopeBlock value) { }

}

