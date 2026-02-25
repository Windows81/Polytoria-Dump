namespace System.Resources;

[Token(Token = "0x20004AC")]
internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<String>, IEqualityComparer<String>
{
	[Token(Token = "0x40012B5")]
	internal static readonly FastResourceComparer Default; //Field offset: 0x0

	[Address(RVA = "0x13B8CD0", Offset = "0x13B7ED0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020FA")]
	private static FastResourceComparer() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020F9")]
	public FastResourceComparer() { }

	[Address(RVA = "0x13B8A30", Offset = "0x13B7C30", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60020F2")]
	public override int Compare(object a, object b) { }

	[Address(RVA = "0x13B8A10", Offset = "0x13B7C10", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60020F3")]
	public override int Compare(string a, string b) { }

	[Address(RVA = "0x13B8940", Offset = "0x13B7B40", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60020F6")]
	public static int CompareOrdinal(string a, Byte[] bytes, int bCharLength) { }

	[Address(RVA = "0x13B87A0", Offset = "0x13B79A0", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60020F7")]
	public static int CompareOrdinal(Byte[] bytes, int aCharLength, string b) { }

	[Address(RVA = "0x13B8890", Offset = "0x13B7A90", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60020F8")]
	internal static int CompareOrdinal(Byte* a, int byteLen, string b) { }

	[Address(RVA = "0x13B8B10", Offset = "0x13B7D10", Length = "0x11")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60020F4")]
	public override bool Equals(string a, string b) { }

	[Address(RVA = "0x13B8AA0", Offset = "0x13B7CA0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60020F5")]
	public override bool Equals(object a, object b) { }

	[Address(RVA = "0x13B8B30", Offset = "0x13B7D30", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60020EF")]
	public override int GetHashCode(object key) { }

	[Address(RVA = "0x13B8BE0", Offset = "0x13B7DE0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60020F0")]
	public override int GetHashCode(string key) { }

	[Address(RVA = "0x13B8C70", Offset = "0x13B7E70", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60020F1")]
	internal static int HashFunction(string key) { }

}

