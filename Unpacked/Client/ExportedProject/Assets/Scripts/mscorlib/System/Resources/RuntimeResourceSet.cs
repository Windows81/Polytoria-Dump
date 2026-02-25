namespace System.Resources;

[Token(Token = "0x20004A9")]
internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable
{
	[Token(Token = "0x40012AC")]
	internal const int Version = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012AD")]
	private Dictionary<String, ResourceLocator> _resCache; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012AE")]
	private ResourceReader _defaultReader; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40012AF")]
	private Dictionary<String, ResourceLocator> _caseInsensitiveTable; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40012B0")]
	private bool _haveReadFromReader; //Field offset: 0x40

	[Address(RVA = "0x13C93C0", Offset = "0x13C85C0", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(System.Collections.Generic.Dictionary`2<System.String, System.Resources.ResourceLocator>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020E2")]
	internal RuntimeResourceSet(string fileName) { }

	[Address(RVA = "0x13C92A0", Offset = "0x13C84A0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ResourceReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(System.Collections.Generic.Dictionary`2<System.String, System.Resources.ResourceLocator>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020E3")]
	internal RuntimeResourceSet(Stream stream) { }

	[Address(RVA = "0x13C8340", Offset = "0x13C7540", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ResourceReader), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceSet), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60020E4")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x13C8520", Offset = "0x13C7720", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetEnumeratorHelper", ReturnType = typeof(IDictionaryEnumerator))]
	[DeduplicatedMethod]
	[Token(Token = "0x60020E5")]
	public virtual IDictionaryEnumerator GetEnumerator() { }

	[Address(RVA = "0x13C8480", Offset = "0x13C7680", Length = "0x95")]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetEnumerator", ReturnType = typeof(IDictionaryEnumerator))]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60020E7")]
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	[Address(RVA = "0x13C8530", Offset = "0x13C7730", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Token(Token = "0x60020EA")]
	public virtual object GetObject(string key) { }

	[Address(RVA = "0x13C9030", Offset = "0x13C8230", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Token(Token = "0x60020EB")]
	public virtual object GetObject(string key, bool ignoreCase) { }

	[Address(RVA = "0x13C8550", Offset = "0x13C7750", Length = "0xAD8")]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Resources.ResourceLocator>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ResourceLocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "ResolveResourceLocator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ResourceLocator), typeof(string), typeof(System.Collections.Generic.Dictionary`2<System.String, System.Resources.ResourceLocator>), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Resources.ResourceLocator>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ResourceLocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ResourceReader), Member = "LoadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ResourceReader), Member = "LoadObjectV1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ResourceReader), Member = "LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ResourceReader), Member = "FindPosForResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1810AA5E0")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60020EC")]
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	[Address(RVA = "0x13C9090", Offset = "0x13C8290", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60020E8")]
	public virtual string GetString(string key) { }

	[Address(RVA = "0x13C9050", Offset = "0x13C8250", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60020E9")]
	public virtual string GetString(string key, bool ignoreCase) { }

	[Address(RVA = "0x13C90E0", Offset = "0x13C82E0", Length = "0x1B6")]
	[CalledBy(Type = typeof(RuntimeResourceSet), Member = "GetObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ResourceReader), Member = "LoadObjectV2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ResourceTypeCode&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ResourceReader), Member = "LoadObjectV1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Resources.ResourceLocator>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ResourceLocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60020ED")]
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<String, ResourceLocator> copyOfCache, bool keyInWrongCase) { }

	[Address(RVA = "0x13C8520", Offset = "0x13C7720", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeResourceSet), Member = "GetEnumeratorHelper", ReturnType = typeof(IDictionaryEnumerator))]
	[DeduplicatedMethod]
	[Token(Token = "0x60020E6")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

