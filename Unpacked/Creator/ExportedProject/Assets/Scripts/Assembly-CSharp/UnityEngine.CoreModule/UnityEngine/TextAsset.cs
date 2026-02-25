namespace UnityEngine;

[NativeHeader("Runtime/Scripting/TextAsset.h")]
[Token(Token = "0x200015F")]
public class TextAsset : object
{
	[Token(Token = "0x2000160")]
	public enum CreateOptions
	{
		None = 0,
		CreateNativeObject = 1,
	}

	[Token(Token = "0x2000161")]
	private static class EncodingUtility
	{
		[Token(Token = "0x400057E")]
		internal static readonly KeyValuePair<Byte[], Encoding>[] encodingLookup; //Field offset: 0x0
		[Token(Token = "0x400057F")]
		internal static readonly Encoding targetEncoding; //Field offset: 0x8

		[Address(RVA = "0x195F580", Offset = "0x195E780", Length = "0x466")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 6)]
		[Token(Token = "0x6000A07")]
		private static EncodingUtility() { }

	}


	[Token(Token = "0x1700019B")]
	public Byte[] bytes
	{
		[Address(RVA = "0x1971630", Offset = "0x1970830", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "InitTextLib", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60009FE")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700019C")]
	public string text
	{
		[Address(RVA = "0x1971460", Offset = "0x1970660", Length = "0xA3")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(TextAsset), Member = "DecodeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A00")]
		 get { } //Length: 163
	}

	[Address(RVA = "0x1971510", Offset = "0x1970710", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextAsset), Member = "Internal_CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A02")]
	public TextAsset() { }

	[Address(RVA = "0x1971570", Offset = "0x1970770", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextAsset), Member = "Internal_CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000A03")]
	internal TextAsset(CreateOptions options, string text) { }

	[Address(RVA = "0x1971030", Offset = "0x1970230", Length = "0x252")]
	[CalledBy(Type = typeof(TextAsset), Member = "get_text", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(TextAsset), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A04")]
	internal static string DecodeString(Byte[] bytes) { }

	[Address(RVA = "0x1971630", Offset = "0x1970830", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "InitTextLib", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009FE")]
	public Byte[] get_bytes() { }

	[Address(RVA = "0x19715F0", Offset = "0x19707F0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A05")]
	private static Byte[] get_bytes_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1971460", Offset = "0x1970660", Length = "0xA3")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A00")]
	public string get_text() { }

	[Address(RVA = "0x19712E0", Offset = "0x19704E0", Length = "0x17C")]
	[CalledBy(Type = typeof(TextAsset), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextAsset), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CreateOptions), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60009FF")]
	private static void Internal_CreateInstance(TextAsset self, string text) { }

	[Address(RVA = "0x1971290", Offset = "0x1970490", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000A06")]
	private static void Internal_CreateInstance_Injected(TextAsset self, ref ManagedSpanWrapper text) { }

	[Address(RVA = "0x1971460", Offset = "0x1970660", Length = "0xA3")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A01")]
	public virtual string ToString() { }

}

