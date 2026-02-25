namespace MoonSharp.Interpreter.DataStructs;

[Token(Token = "0x200016C")]
internal class MultiDictionary
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D0")]
	private Dictionary<K, List`1<V>> m_Map; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40005D1")]
	private V[] m_DefaultRet; //Field offset: 0x0

	[Token(Token = "0x170001D0")]
	public IEnumerable<K> Keys
	{
		[Address(RVA = "0xE0D3A0", Offset = "0xE0C5A0", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D70")]
		 get { } //Length: 45
	}

	[Address(RVA = "0xE0D080", Offset = "0xE0C280", Length = "0xB9")]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6B")]
	public MultiDictionary`2() { }

	[Address(RVA = "0xE0D2D0", Offset = "0xE0C4D0", Length = "0xC9")]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventInfo), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6C")]
	public MultiDictionary`2(IEqualityComparer<K> eqComparer) { }

	[Address(RVA = "0xE0C430", Offset = "0xE0B630", Length = "0x17D")]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "RegisterExtensionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(InteropAccessMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6D")]
	public bool Add(K key, V value) { }

	[Address(RVA = "0xE0C900", Offset = "0xE0BB00", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D71")]
	public void Clear() { }

	[Address(RVA = "0xE0C930", Offset = "0xE0BB30", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6F")]
	public bool ContainsKey(K key) { }

	[Address(RVA = "0xE0CA50", Offset = "0xE0BC50", Length = "0x52")]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "DispatchEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "GetExtensionMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(System.Collections.Generic.IEnumerable`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[CalledBy(Type = typeof(ExtensionMethodsRegistry), Member = "GetExtensionMethodsByNameAndType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D6E")]
	public IEnumerable<V> Find(K key) { }

	[Address(RVA = "0xE0D3A0", Offset = "0xE0C5A0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D70")]
	public IEnumerable<K> get_Keys() { }

	[Address(RVA = "0xE0D050", Offset = "0xE0C250", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D72")]
	public void Remove(K key) { }

	[Address(RVA = "0xE0CE70", Offset = "0xE0C070", Length = "0xE0")]
	[CalledBy(Type = typeof(EventMemberDescriptor), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ScriptExecutionContext), typeof(CallbackArguments)}, ReturnType = typeof(DynValue))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D73")]
	public bool RemoveValue(K key, V value) { }

}

