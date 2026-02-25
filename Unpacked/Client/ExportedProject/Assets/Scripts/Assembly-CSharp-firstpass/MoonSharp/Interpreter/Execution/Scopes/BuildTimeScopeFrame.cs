namespace MoonSharp.Interpreter.Execution.Scopes;

[Token(Token = "0x2000154")]
internal class BuildTimeScopeFrame
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000572")]
	private BuildTimeScopeBlock m_ScopeTreeRoot; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000573")]
	private BuildTimeScopeBlock m_ScopeTreeHead; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000574")]
	private RuntimeScopeFrame m_ScopeFrame; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000575")]
	private bool <HasVarArgs>k__BackingField; //Field offset: 0x28

	[Token(Token = "0x170001A6")]
	public private bool HasVarArgs
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CB4")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CB5")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x3760E0", Offset = "0x3752E0", Length = "0xBF")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "PushFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IClosureBuilder), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RuntimeScopeFrame), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuildTimeScopeBlock)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CB6")]
	internal BuildTimeScopeFrame(bool hasVarArgs) { }

	[Address(RVA = "0x375AC0", Offset = "0x374CC0", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CBE")]
	internal int AllocVar(SymbolRef var) { }

	[Address(RVA = "0x375BB0", Offset = "0x374DB0", Length = "0x1E")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "DefineLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelStatement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = "DefineLabel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LabelStatement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CC0")]
	internal void DefineLabel(LabelStatement label) { }

	[Address(RVA = "0x375BD0", Offset = "0x374DD0", Length = "0x1E")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "DefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CBB")]
	internal SymbolRef DefineLocal(string name) { }

	[Address(RVA = "0x375BF0", Offset = "0x374DF0", Length = "0x60")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Token(Token = "0x6000CBA")]
	internal SymbolRef Find(string name) { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CB4")]
	public bool get_HasVarArgs() { }

	[Address(RVA = "0x375C50", Offset = "0x374E50", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CBF")]
	internal int GetPosForNextVar() { }

	[Address(RVA = "0x375CA0", Offset = "0x374EA0", Length = "0x8B")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "PopFunction", ReturnType = typeof(RuntimeScopeFrame))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CB9")]
	internal RuntimeScopeFrame GetRuntimeFrameData() { }

	[Address(RVA = "0x375D30", Offset = "0x374F30", Length = "0x9E")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "PopBlock", ReturnType = typeof(RuntimeScopeBlock))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = "ResolveGotos", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CB8")]
	internal RuntimeScopeBlock PopBlock() { }

	[Address(RVA = "0x375DD0", Offset = "0x374FD0", Length = "0xF1")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "PushBlock", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuildTimeScopeBlock)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CB7")]
	internal void PushBlock() { }

	[Address(RVA = "0x375ED0", Offset = "0x3750D0", Length = "0x1E")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "RegisterGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoStatement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = "RegisterGoto", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GotoStatement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CC1")]
	internal void RegisterGoto(GotoStatement gotostat) { }

	[Address(RVA = "0x375EF0", Offset = "0x3750F0", Length = "0x37")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "PopFunction", ReturnType = typeof(RuntimeScopeFrame))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = "ResolveGotos", ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = "ResolveLRefs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuildTimeScopeFrame)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CBD")]
	internal void ResolveLRefs() { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CB5")]
	private void set_HasVarArgs(bool value) { }

	[Address(RVA = "0x375F30", Offset = "0x375130", Length = "0x1A2")]
	[CalledBy(Type = typeof(BuildTimeScope), Member = "TryDefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extension_Methods), Member = "GetOrDefault", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", "TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BuildTimeScopeBlock), Member = "Define", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CBC")]
	internal SymbolRef TryDefineLocal(string name) { }

}

