namespace MoonSharp.Interpreter;

[Extension]
[Token(Token = "0x200003B")]
internal static class Extension_Methods
{

	[Address(RVA = "0x6B2EC0", Offset = "0x6B20C0", Length = "0xA6")]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "RegisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600046C")]
	public static TValue GetOrCreate(Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> creator) { }

	[Address(RVA = "0x6B3120", Offset = "0x6B2320", Length = "0x78")]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TrySetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string), typeof(DynValue)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "UnregisterCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "FindMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IMemberDescriptor))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "FindMetaMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IMemberDescriptor))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "Index", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue), typeof(bool)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "SetIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(DynValue), typeof(DynValue), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "TryDefineLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "MetaIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "TryDispatchLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(DispatchingUserDataDescriptor), Member = "DispatchMetaOnMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Script), typeof(object), typeof(string)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(BuildTimeScopeBlock), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CalledBy(Type = typeof(BuildTimeScopeFrame), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SymbolRef))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600046B")]
	public static TValue GetOrDefault(Dictionary<TKey, TValue> dictionary, TKey key) { }

}

