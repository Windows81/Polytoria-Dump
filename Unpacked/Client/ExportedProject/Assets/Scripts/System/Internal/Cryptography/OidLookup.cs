namespace Internal.Cryptography;

[Token(Token = "0x20000AD")]
internal static class OidLookup
{
	[CompilerGenerated]
	[Token(Token = "0x20000AE")]
	private sealed class <>c
	{
		[Token(Token = "0x4000207")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x1746A70", Offset = "0x1745C70", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000353")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000354")]
		public <>c() { }

		[Address(RVA = "0x17469F0", Offset = "0x1745BF0", Length = "0x39")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000355")]
		internal string <.cctor>b__10_0(KeyValuePair<String, String> kvp) { }

		[Address(RVA = "0x1746A30", Offset = "0x1745C30", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000356")]
		internal string <.cctor>b__10_1(KeyValuePair<String, String> kvp) { }

	}

	[Token(Token = "0x4000202")]
	private static readonly ConcurrentDictionary<String, String> s_lateBoundOidToFriendlyName; //Field offset: 0x0
	[Token(Token = "0x4000203")]
	private static readonly ConcurrentDictionary<String, String> s_lateBoundFriendlyNameToOid; //Field offset: 0x8
	[Token(Token = "0x4000204")]
	private static readonly Dictionary<String, String> s_friendlyNameToOid; //Field offset: 0x10
	[Token(Token = "0x4000205")]
	private static readonly Dictionary<String, String> s_oidToFriendlyName; //Field offset: 0x18
	[Token(Token = "0x4000206")]
	private static readonly Dictionary<String, String> s_compatOids; //Field offset: 0x20

	[Address(RVA = "0x1744290", Offset = "0x1743490", Length = "0x1A38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEqualityComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey", "TElement"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>"}, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000352")]
	private static OidLookup() { }

	[Address(RVA = "0x1743740", Offset = "0x1742940", Length = "0x34E")]
	[CalledBy(Type = typeof(OidLookup), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x6000351")]
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	[Address(RVA = "0x1743A90", Offset = "0x1742C90", Length = "0x34E")]
	[CalledBy(Type = typeof(OidLookup), Member = "ToFriendlyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 12)]
	[Token(Token = "0x6000350")]
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600034F")]
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	[Address(RVA = "0x1743DE0", Offset = "0x1742FE0", Length = "0x265")]
	[CalledBy(Type = typeof(Oid), Member = "FromOidValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup)}, ReturnType = typeof(Oid))]
	[CalledBy(Type = typeof(Oid), Member = "get_FriendlyName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_SignatureAlgorithm", ReturnType = typeof(Oid))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OidLookup), Member = "NativeOidToFriendlyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x600034D")]
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	[Address(RVA = "0x1744050", Offset = "0x1743250", Length = "0x234")]
	[CalledBy(Type = typeof(Oid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(OidLookup), Member = "NativeFriendlyNameToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentDictionary`2<System.Object, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600034E")]
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

}

