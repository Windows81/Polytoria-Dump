namespace System.Collections.Specialized;

[DefaultMember("Item")]
[Token(Token = "0x20001A9")]
public class StringDictionary : IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000687")]
	internal Hashtable contents; //Field offset: 0x10

	[Address(RVA = "0x17B1250", Offset = "0x17B0450", Length = "0x66")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A43")]
	public StringDictionary() { }

	[Address(RVA = "0x17CBF90", Offset = "0x17CB190", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A44")]
	public override void Add(string key, string value) { }

	[Address(RVA = "0x143CC20", Offset = "0x143BE20", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A45")]
	public override IEnumerator GetEnumerator() { }

}

