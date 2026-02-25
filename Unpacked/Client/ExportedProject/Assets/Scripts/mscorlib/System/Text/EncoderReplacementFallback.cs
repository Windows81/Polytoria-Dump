namespace System.Text;

[Token(Token = "0x20002A2")]
public sealed class EncoderReplacementFallback : EncoderFallback, ISerializable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B9C")]
	private string _strDefault; //Field offset: 0x10

	[Token(Token = "0x17000224")]
	public string DefaultString
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600154E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000225")]
	public virtual int MaxCharCount
	{
		[Address(RVA = "0x563670", Offset = "0x562870", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001550")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x130B6F0", Offset = "0x130A8F0", Length = "0x3C")]
	[CalledBy(Type = typeof(EncoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(EncoderFallback))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600154A")]
	public EncoderReplacementFallback() { }

	[Address(RVA = "0x130B730", Offset = "0x130A930", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600154B")]
	internal EncoderReplacementFallback(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x130B7F0", Offset = "0x130A9F0", Length = "0x17C")]
	[CalledBy(Type = "UnityEngine.TextAsset+EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.UriComponents"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.Char[]", typeof(Int32&), typeof(char), typeof(char), typeof(char), "System.UnescapeMode", "System.UriParser", typeof(bool)}, ReturnType = "System.Char[]")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600154D")]
	public EncoderReplacementFallback(string replacement) { }

	[Address(RVA = "0x130B590", Offset = "0x130A790", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600154F")]
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() { }

	[Address(RVA = "0x130B620", Offset = "0x130A820", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001551")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600154E")]
	public string get_DefaultString() { }

	[Address(RVA = "0x563670", Offset = "0x562870", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001550")]
	public virtual int get_MaxCharCount() { }

	[Address(RVA = "0x300BF0", Offset = "0x2FFDF0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001552")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x130B690", Offset = "0x130A890", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600154C")]
	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

