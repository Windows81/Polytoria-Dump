namespace System.Text;

[ComVisible(True)]
[Token(Token = "0x20002B8")]
public abstract class Encoding : ICloneable
{
	[Token(Token = "0x20002BA")]
	public class DefaultDecoder : Decoder, ISerializable, IObjectReference
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BEB")]
		private Encoding m_encoding; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BEC")]
		private bool m_hasInitializedEncoding; //Field offset: 0x28

		[Address(RVA = "0x13254E0", Offset = "0x13246E0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016B4")]
		public DefaultDecoder(Encoding encoding) { }

		[Address(RVA = "0x1325230", Offset = "0x1324430", Length = "0x2AE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60016B5")]
		internal DefaultDecoder(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1325010", Offset = "0x1324210", Length = "0x27")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016B8")]
		public virtual int GetCharCount(Byte[] bytes, int index, int count) { }

		[Address(RVA = "0x1324FE0", Offset = "0x13241E0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016B9")]
		public virtual int GetCharCount(Byte[] bytes, int index, int count, bool flush) { }

		[Address(RVA = "0x1325040", Offset = "0x1324240", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016BA")]
		public virtual int GetCharCount(Byte* bytes, int count, bool flush) { }

		[Address(RVA = "0x1325070", Offset = "0x1324270", Length = "0x39")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016BB")]
		public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

		[Address(RVA = "0x13250E0", Offset = "0x13242E0", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016BC")]
		public virtual int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex, bool flush) { }

		[Address(RVA = "0x13250B0", Offset = "0x13242B0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016BD")]
		public virtual int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, bool flush) { }

		[Address(RVA = "0x1325120", Offset = "0x1324320", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016B6")]
		public override object GetRealObject(StreamingContext context) { }

		[Address(RVA = "0x1325190", Offset = "0x1324390", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60016B7")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	[Token(Token = "0x20002B9")]
	public class DefaultEncoder : Encoder, ISerializable, IObjectReference
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BE8")]
		private Encoding m_encoding; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BE9")]
		private bool m_hasInitializedEncoding; //Field offset: 0x28
		[FieldOffset(Offset = "0x2A")]
		[Token(Token = "0x4000BEA")]
		internal char charLeftOver; //Field offset: 0x2A

		[Address(RVA = "0x13254E0", Offset = "0x13246E0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016AC")]
		public DefaultEncoder(Encoding encoding) { }

		[Address(RVA = "0x1325760", Offset = "0x1324960", Length = "0x2FE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60016AD")]
		internal DefaultEncoder(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x1325550", Offset = "0x1324750", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016B0")]
		public virtual int GetByteCount(Char[] chars, int index, int count, bool flush) { }

		[Address(RVA = "0x1325520", Offset = "0x1324720", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016B1")]
		public virtual int GetByteCount(Char* chars, int count, bool flush) { }

		[Address(RVA = "0x1325580", Offset = "0x1324780", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016B2")]
		public virtual int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex, bool flush) { }

		[Address(RVA = "0x13255C0", Offset = "0x13247C0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016B3")]
		public virtual int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, bool flush) { }

		[Address(RVA = "0x13255F0", Offset = "0x13247F0", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016AE")]
		public override object GetRealObject(StreamingContext context) { }

		[Address(RVA = "0x13256C0", Offset = "0x13248C0", Length = "0x99")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60016AF")]
		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	[Token(Token = "0x20002BC")]
	public class EncodingByteBuffer
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BF7")]
		private Byte* bytes; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BF8")]
		private Byte* byteStart; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BF9")]
		private Byte* byteEnd; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BFA")]
		private Char* chars; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BFB")]
		private Char* charStart; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BFC")]
		private Char* charEnd; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BFD")]
		private int byteCountResult; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BFE")]
		private Encoding enc; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BFF")]
		private EncoderNLS encoder; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000C00")]
		internal EncoderFallbackBuffer fallbackBuffer; //Field offset: 0x58

		[Token(Token = "0x1700024F")]
		internal int CharsUsed
		{
			[Address(RVA = "0x1326010", Offset = "0x1325210", Length = "0x11")]
			[CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
			[CallerCount(Count = 1)]
			[Token(Token = "0x60016D0")]
			internal get { } //Length: 17
		}

		[Token(Token = "0x17000250")]
		internal int Count
		{
			[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016D1")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x1700024E")]
		internal bool MoreData
		{
			[Address(RVA = "0x1326030", Offset = "0x1325230", Length = "0x47")]
			[CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60016CE")]
			internal get { } //Length: 71
		}

		[Address(RVA = "0x1325D90", Offset = "0x1324F90", Length = "0x277")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(Char*), typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60016C8")]
		internal EncodingByteBuffer(Encoding inEncoding, EncoderNLS inEncoder, Byte* inByteStart, int inByteCount, Char* inCharStart, int inCharCount) { }

		[Address(RVA = "0x1325B20", Offset = "0x1324D20", Length = "0x11E")]
		[CalledBy(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60016C9")]
		internal bool AddByte(byte b, int moreBytesExpected) { }

		[Address(RVA = "0x1325B10", Offset = "0x1324D10", Length = "0xB")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 8)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x60016CA")]
		internal bool AddByte(byte b1) { }

		[Address(RVA = "0x1325AC0", Offset = "0x1324CC0", Length = "0x4A")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
		[ContainsInvalidInstructions]
		[Token(Token = "0x60016CB")]
		internal bool AddByte(byte b1, byte b2) { }

		[Address(RVA = "0x1325A60", Offset = "0x1324C60", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60016CC")]
		internal bool AddByte(byte b1, byte b2, int moreBytesExpected) { }

		[Address(RVA = "0x1326010", Offset = "0x1325210", Length = "0x11")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60016D0")]
		internal int get_CharsUsed() { }

		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016D1")]
		internal int get_Count() { }

		[Address(RVA = "0x1326030", Offset = "0x1325230", Length = "0x47")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60016CE")]
		internal bool get_MoreData() { }

		[Address(RVA = "0x1325C40", Offset = "0x1324E40", Length = "0x42")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalGetNextChar", ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60016CF")]
		internal char GetNextChar() { }

		[Address(RVA = "0x1325C90", Offset = "0x1324E90", Length = "0xF6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
		[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60016CD")]
		internal void MovePrevious(bool bThrow) { }

	}

	[Token(Token = "0x20002BB")]
	public class EncodingCharBuffer
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BED")]
		private Char* chars; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BEE")]
		private Char* charStart; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BEF")]
		private Char* charEnd; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BF0")]
		private int charCountResult; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BF1")]
		private Encoding enc; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BF2")]
		private DecoderNLS decoder; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000BF3")]
		private Byte* byteStart; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000BF4")]
		private Byte* byteEnd; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000BF5")]
		private Byte* bytes; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000BF6")]
		private DecoderFallbackBuffer fallbackBuffer; //Field offset: 0x58

		[Token(Token = "0x1700024C")]
		internal int BytesUsed
		{
			[Address(RVA = "0x1326550", Offset = "0x1325750", Length = "0x7")]
			[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
			[CallerCount(Count = 1)]
			[Token(Token = "0x60016C4")]
			internal get { } //Length: 7
		}

		[Token(Token = "0x1700024D")]
		internal int Count
		{
			[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60016C7")]
			internal get { } //Length: 4
		}

		[Token(Token = "0x1700024B")]
		internal bool MoreData
		{
			[Address(RVA = "0x1326560", Offset = "0x1325760", Length = "0xC")]
			[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
			[CallerCount(Count = 1)]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x60016C2")]
			internal get { } //Length: 12
		}

		[Address(RVA = "0x1326460", Offset = "0x1325660", Length = "0xEF")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalInitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Char*)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60016BE")]
		internal EncodingCharBuffer(Encoding enc, DecoderNLS decoder, Char* charStart, int charCount, Byte* byteStart, int byteCount) { }

		[Address(RVA = "0x1326080", Offset = "0x1325280", Length = "0xE4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60016BF")]
		internal bool AddChar(char ch, int numBytes) { }

		[Address(RVA = "0x1326170", Offset = "0x1325370", Length = "0xDF")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60016C0")]
		internal bool AddChar(char ch) { }

		[Address(RVA = "0x1326250", Offset = "0x1325450", Length = "0x8")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60016C1")]
		internal void AdjustBytes(int count) { }

		[Address(RVA = "0x1326260", Offset = "0x1325460", Length = "0x6E")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsInvalidInstructions]
		[Token(Token = "0x60016C5")]
		internal bool Fallback(byte fallbackByte) { }

		[Address(RVA = "0x13262D0", Offset = "0x13254D0", Length = "0x16C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
		[Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
		[Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60016C6")]
		internal bool Fallback(Byte[] byteBuffer) { }

		[Address(RVA = "0x1326550", Offset = "0x1325750", Length = "0x7")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60016C4")]
		internal int get_BytesUsed() { }

		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60016C7")]
		internal int get_Count() { }

		[Address(RVA = "0x1326560", Offset = "0x1325760", Length = "0xC")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60016C2")]
		internal bool get_MoreData() { }

		[Address(RVA = "0x1326440", Offset = "0x1325640", Length = "0x1D")]
		[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60016C3")]
		internal byte GetNextByte() { }

	}

	[Token(Token = "0x4000BD8")]
	private static Encoding defaultEncoding; //Field offset: 0x0
	[Token(Token = "0x4000BD9")]
	private static Encoding unicodeEncoding; //Field offset: 0x8
	[Token(Token = "0x4000BDA")]
	private static Encoding bigEndianUnicode; //Field offset: 0x10
	[Token(Token = "0x4000BDB")]
	private static Encoding utf7Encoding; //Field offset: 0x18
	[Token(Token = "0x4000BDC")]
	private static Encoding utf8Encoding; //Field offset: 0x20
	[Token(Token = "0x4000BDD")]
	private static Encoding utf32Encoding; //Field offset: 0x28
	[Token(Token = "0x4000BDE")]
	private static Encoding asciiEncoding; //Field offset: 0x30
	[Token(Token = "0x4000BDF")]
	private static Encoding latin1Encoding; //Field offset: 0x38
	[Token(Token = "0x4000BE0")]
	private static Dictionary<Int32, Encoding> encodings; //Field offset: 0x40
	[Token(Token = "0x4000BE7")]
	private static object s_InternalSyncObject; //Field offset: 0x48
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000BE1")]
	internal int m_codePage; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000BE2")]
	internal CodePageDataItem dataItem; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000BE3")]
	internal bool m_deserializedFromEverett; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000BE4")]
	private bool m_isReadOnly; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000BE5")]
	internal EncoderFallback encoderFallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[OptionalField(VersionAdded = 2)]
	[Token(Token = "0x4000BE6")]
	internal DecoderFallback decoderFallback; //Field offset: 0x30

	[Token(Token = "0x17000242")]
	public static Encoding ASCII
	{
		[Address(RVA = "0x1329D90", Offset = "0x1328F90", Length = "0xB4")]
		[CallerCount(Count = 79)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ASCIIEncoding), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600167E")]
		 get { } //Length: 180
	}

	[Token(Token = "0x17000247")]
	public static Encoding BigEndianUnicode
	{
		[Address(RVA = "0x1329E50", Offset = "0x1329050", Length = "0xBC")]
		[CalledBy(Type = typeof(StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Boolean&)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadBMPString", ReturnType = typeof(string))]
		[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "Clone", ReturnType = typeof(object))]
		[CalledBy(Type = "Mono.Security.X509.X520+AttributeTypeAndValue", Member = "GetASN1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = "Mono.Security.ASN1")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600169F")]
		 get { } //Length: 188
	}

	[Token(Token = "0x17000244")]
	public override int CodePage
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001694")]
		 get { } //Length: 4
	}

	[ComVisible(False)]
	[Token(Token = "0x17000240")]
	public DecoderFallback DecoderFallback
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x600167A")]
		 get { } //Length: 95
		[Address(RVA = "0x132A550", Offset = "0x1329750", Length = "0xCA")]
		[CalledBy(Type = typeof(EncodingProvider), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
		[CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.UriComponents"}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.Char[]", typeof(Int32&), typeof(char), typeof(char), typeof(char), "System.UnescapeMode", "System.UriParser", typeof(bool)}, ReturnType = "System.Char[]")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600167B")]
		 set { } //Length: 202
	}

	[Token(Token = "0x17000245")]
	public static Encoding Default
	{
		[Address(RVA = "0x1329F10", Offset = "0x1329110", Length = "0xD0")]
		[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
		[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CommandStream+PipelineEntry", "System.Net.ResponseDescription", typeof(bool), typeof(Stream&)}, ReturnType = "System.Net.CommandStream+PipelineInstruction")]
		[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(EncodingHelper), Member = "GetDefaultEncoding", ReturnType = typeof(Encoding))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001698")]
		 get { } //Length: 208
	}

	[ComVisible(False)]
	[Token(Token = "0x1700023F")]
	public EncoderFallback EncoderFallback
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001678")]
		 get { } //Length: 5
		[Address(RVA = "0x132A620", Offset = "0x1329820", Length = "0xCA")]
		[CalledBy(Type = typeof(EncodingProvider), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
		[CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.UriComponents"}, ReturnType = typeof(string))]
		[CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.Char[]", typeof(Int32&), typeof(char), typeof(char), typeof(char), "System.UnescapeMode", "System.UriParser", typeof(bool)}, ReturnType = "System.Char[]")]
		[CalledBy(Type = "System.Xml.XmlEncodedRawTextWriter", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), "System.Xml.XmlWriterSettings"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001679")]
		 set { } //Length: 202
	}

	[Token(Token = "0x1700023C")]
	public override string EncodingName
	{
		[Address(RVA = "0x1329FF0", Offset = "0x13291F0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Environment), Member = "GetResourceStringEncodingName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[Token(Token = "0x6001675")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700023D")]
	public override string HeaderName
	{
		[Address(RVA = "0x132A000", Offset = "0x1329200", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "GetDataItem", ReturnType = typeof(void))]
		[Calls(Type = typeof(CodePageDataItem), Member = "get_HeaderName", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001676")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700023A")]
	private static object InternalSyncObject
	{
		[Address(RVA = "0x132A040", Offset = "0x1329240", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600166E")]
		private get { } //Length: 152
	}

	[ComVisible(False)]
	[Token(Token = "0x17000241")]
	public bool IsReadOnly
	{
		[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600167D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000243")]
	private static Encoding Latin1
	{
		[Address(RVA = "0x132A0E0", Offset = "0x13292E0", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Latin1Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600167F")]
		private get { } //Length: 180
	}

	[Token(Token = "0x1700023B")]
	public override ReadOnlySpan<Byte> Preamble
	{
		[Address(RVA = "0x132A1A0", Offset = "0x13293A0", Length = "0x6C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001673")]
		 get { } //Length: 108
	}

	[Token(Token = "0x17000246")]
	public static Encoding Unicode
	{
		[Address(RVA = "0x132A450", Offset = "0x1329650", Length = "0xBA")]
		[CallerCount(Count = 30)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600169E")]
		 get { } //Length: 186
	}

	[Token(Token = "0x1700024A")]
	public static Encoding UTF32
	{
		[Address(RVA = "0x132A210", Offset = "0x1329410", Length = "0xBA")]
		[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
		[CalledBy(Type = typeof(StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Boolean&)}, ReturnType = typeof(int))]
		[CalledBy(Type = "System.Net.Http.HttpContent", Member = "GetEncodingFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(Int32&)}, ReturnType = typeof(Encoding))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60016A2")]
		 get { } //Length: 186
	}

	[Token(Token = "0x17000248")]
	public static Encoding UTF7
	{
		[Address(RVA = "0x132A2D0", Offset = "0x13294D0", Length = "0xB4")]
		[CalledBy(Type = "Mono.Security.X509.X501", Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), "Mono.Security.ASN1", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UTF7Encoding), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60016A0")]
		 get { } //Length: 180
	}

	[Token(Token = "0x17000249")]
	public static Encoding UTF8
	{
		[Address(RVA = "0x132A390", Offset = "0x1329590", Length = "0xB7")]
		[CallerCount(Count = 91)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60016A1")]
		 get { } //Length: 183
	}

	[Token(Token = "0x1700023E")]
	public override string WebName
	{
		[Address(RVA = "0x132A510", Offset = "0x1329710", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Encoding), Member = "GetDataItem", ReturnType = typeof(void))]
		[Calls(Type = typeof(CodePageDataItem), Member = "get_WebName", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001677")]
		 get { } //Length: 49
	}

	[Address(RVA = "0x1329CC0", Offset = "0x1328EC0", Length = "0x37")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IO.BinaryEncoding", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Ucs4Encoding", Member = "get_UCS4_Littleendian", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.Xml.Ucs4Encoding", Member = "get_UCS4_Bigendian", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.Xml.Ucs4Encoding", Member = "get_UCS4_2143", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.Xml.Ucs4Encoding", Member = "get_UCS4_3412", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.Xml.Ucs4Encoding", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Ucs4Encoding1234", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Ucs4Encoding4321", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Ucs4Encoding2143", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Ucs4Encoding3412", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001664")]
	protected Encoding() { }

	[Address(RVA = "0x1329D00", Offset = "0x1328F00", Length = "0x8A")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001665")]
	protected Encoding(int codePage) { }

	[Address(RVA = "0x1326E80", Offset = "0x1326080", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ComVisible(False)]
	[Token(Token = "0x600167C")]
	public override object Clone() { }

	[Address(RVA = "0x1326F00", Offset = "0x1326100", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EncodingHelper), Member = "GetDefaultEncoding", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001696")]
	private static Encoding CreateDefaultEncoding() { }

	[Address(RVA = "0x1326F50", Offset = "0x1326150", Length = "0x38F")]
	[CalledBy(Type = typeof(Latin1Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600166C")]
	internal void DeserializeEncoding(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13272E0", Offset = "0x13264E0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60016A3")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x1329D90", Offset = "0x1328F90", Length = "0xB4")]
	[CallerCount(Count = 79)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ASCIIEncoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600167E")]
	public static Encoding get_ASCII() { }

	[Address(RVA = "0x1329E50", Offset = "0x1329050", Length = "0xBC")]
	[CalledBy(Type = typeof(StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadBMPString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "Clone", ReturnType = typeof(object))]
	[CalledBy(Type = "Mono.Security.X509.X520+AttributeTypeAndValue", Member = "GetASN1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = "Mono.Security.ASN1")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600169F")]
	public static Encoding get_BigEndianUnicode() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001694")]
	public override int get_CodePage() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x600167A")]
	public DecoderFallback get_DecoderFallback() { }

	[Address(RVA = "0x1329F10", Offset = "0x1329110", Length = "0xD0")]
	[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Diagnostics.ProcessStartInfo"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.FtpControlStream", Member = "PipelineCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.CommandStream+PipelineEntry", "System.Net.ResponseDescription", typeof(bool), typeof(Stream&)}, ReturnType = "System.Net.CommandStream+PipelineInstruction")]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<Initialize>d__42", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EncodingHelper), Member = "GetDefaultEncoding", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001698")]
	public static Encoding get_Default() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001678")]
	public EncoderFallback get_EncoderFallback() { }

	[Address(RVA = "0x1329FF0", Offset = "0x13291F0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Environment), Member = "GetResourceStringEncodingName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6001675")]
	public override string get_EncodingName() { }

	[Address(RVA = "0x132A000", Offset = "0x1329200", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "GetDataItem", ReturnType = typeof(void))]
	[Calls(Type = typeof(CodePageDataItem), Member = "get_HeaderName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001676")]
	public override string get_HeaderName() { }

	[Address(RVA = "0x132A040", Offset = "0x1329240", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600166E")]
	private static object get_InternalSyncObject() { }

	[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600167D")]
	public bool get_IsReadOnly() { }

	[Address(RVA = "0x132A0E0", Offset = "0x13292E0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Latin1Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600167F")]
	private static Encoding get_Latin1() { }

	[Address(RVA = "0x132A1A0", Offset = "0x13293A0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001673")]
	public override ReadOnlySpan<Byte> get_Preamble() { }

	[Address(RVA = "0x132A450", Offset = "0x1329650", Length = "0xBA")]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600169E")]
	public static Encoding get_Unicode() { }

	[Address(RVA = "0x132A210", Offset = "0x1329410", Length = "0xBA")]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Boolean&)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Net.Http.HttpContent", Member = "GetEncodingFromBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(Int32&)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60016A2")]
	public static Encoding get_UTF32() { }

	[Address(RVA = "0x132A2D0", Offset = "0x13294D0", Length = "0xB4")]
	[CalledBy(Type = "Mono.Security.X509.X501", Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), "Mono.Security.ASN1", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF7Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60016A0")]
	public static Encoding get_UTF7() { }

	[Address(RVA = "0x132A390", Offset = "0x1329590", Length = "0xB7")]
	[CallerCount(Count = 91)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60016A1")]
	public static Encoding get_UTF8() { }

	[Address(RVA = "0x132A510", Offset = "0x1329710", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "GetDataItem", ReturnType = typeof(void))]
	[Calls(Type = typeof(CodePageDataItem), Member = "get_WebName", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001677")]
	public override string get_WebName() { }

	[Address(RVA = "0x13273B0", Offset = "0x13265B0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60016A6")]
	internal override Char[] GetBestFitBytesToUnicodeData() { }

	[Address(RVA = "0x1327400", Offset = "0x1326600", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60016A5")]
	internal override Char[] GetBestFitUnicodeToBytesData() { }

	[Address(RVA = "0x13274F0", Offset = "0x13266F0", Length = "0x198")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x6001682")]
	public override int GetByteCount(Char* chars, int count) { }

	[Token(Token = "0x6001681")]
	public abstract int GetByteCount(Char[] chars, int index, int count) { }

	[Address(RVA = "0x1327690", Offset = "0x1326890", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001683")]
	internal override int GetByteCount(Char* chars, int count, EncoderNLS encoder) { }

	[Address(RVA = "0x13276B0", Offset = "0x13268B0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60016AB")]
	public override int GetByteCount(ReadOnlySpan<Char> chars) { }

	[Address(RVA = "0x1327450", Offset = "0x1326650", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001680")]
	public override int GetByteCount(string s) { }

	[Address(RVA = "0x1327B60", Offset = "0x1326D60", Length = "0x10A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001687")]
	public override Byte[] GetBytes(string s) { }

	[Address(RVA = "0x1327A90", Offset = "0x1326C90", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001689")]
	internal override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount, EncoderNLS encoder) { }

	[Address(RVA = "0x1327C70", Offset = "0x1326E70", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001688")]
	public override int GetBytes(string s, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Token(Token = "0x6001686")]
	public abstract int GetBytes(Char[] chars, int charIndex, int charCount, Byte[] bytes, int byteIndex) { }

	[Address(RVA = "0x1327750", Offset = "0x1326950", Length = "0x263")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x600168A")]
	public override int GetBytes(Char* chars, int charCount, Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1327AB0", Offset = "0x1326CB0", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001684")]
	public override Byte[] GetBytes(Char[] chars) { }

	[Address(RVA = "0x13279C0", Offset = "0x1326BC0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001685")]
	public override Byte[] GetBytes(Char[] chars, int index, int count) { }

	[Token(Token = "0x600168B")]
	public abstract int GetCharCount(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x1327D20", Offset = "0x1326F20", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x600168C")]
	public override int GetCharCount(Byte* bytes, int count) { }

	[Address(RVA = "0x1327EC0", Offset = "0x13270C0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600168D")]
	internal override int GetCharCount(Byte* bytes, int count, DecoderNLS decoder) { }

	[Address(RVA = "0x1327EE0", Offset = "0x13270E0", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600168E")]
	public override Char[] GetChars(Byte[] bytes, int index, int count) { }

	[Token(Token = "0x600168F")]
	public abstract int GetChars(Byte[] bytes, int byteIndex, int byteCount, Char[] chars, int charIndex) { }

	[Address(RVA = "0x1327FD0", Offset = "0x13271D0", Length = "0x264")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x6001690")]
	public override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount) { }

	[Address(RVA = "0x1327FB0", Offset = "0x13271B0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001691")]
	internal override int GetChars(Byte* bytes, int byteCount, Char* chars, int charCount, DecoderNLS decoder) { }

	[Address(RVA = "0x1328240", Offset = "0x1327440", Length = "0x124")]
	[CalledBy(Type = typeof(Encoding), Member = "get_HeaderName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Encoding), Member = "get_WebName", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EncodingTable), Member = "GetCodePageDataItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CodePageDataItem))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Token(Token = "0x6001674")]
	private void GetDataItem() { }

	[Address(RVA = "0x1328370", Offset = "0x1327570", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001695")]
	public override Decoder GetDecoder() { }

	[Address(RVA = "0x13283E0", Offset = "0x13275E0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001699")]
	public override Encoder GetEncoder() { }

	[Address(RVA = "0x1328750", Offset = "0x1327950", Length = "0xB5C")]
	[CalledBy(Type = typeof(Console), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(EncodingHelper), Member = "GetDefaultEncoding", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(EncodingHelper), Member = "InvokeI18N", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(EncodingTable), Member = "GetCodePageDataItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CodePageDataItem))]
	[Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EncodingProvider), Member = "GetEncodingFromProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Latin1Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UTF7Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF32", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600166F")]
	public static Encoding GetEncoding(int codepage) { }

	[Address(RVA = "0x1328450", Offset = "0x1327650", Length = "0x26E")]
	[CalledBy(Type = "UnityEngine.TextAsset+EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(EncodingProvider), Member = "GetEncodingFromProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001670")]
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	[Address(RVA = "0x13286C0", Offset = "0x13278C0", Length = "0x87")]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenizerStream)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Security.Cryptography.DerSequenceReader+<>c", Member = "<ReadT61String>b__45_1", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.Net.Mail.MailAddressParser", Member = "ParseAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32&)}, ReturnType = "System.Net.Mail.MailAddress")]
	[CalledBy(Type = "System.Net.Mail.MailAddress", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Mail.MailAddress", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.IoModule", Member = "open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "System.Xml.XmlDocument", Member = "get_TextEncoding", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.Xml.XmlDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpContent+<ReadAsStringAsync>d__20", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Networking.DownloadHandler", Member = "GetTextEncoder", ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.Xml.Linq.XDocument", Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.Linq.SaveOptions"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(EncodingTable), Member = "GetCodePageFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(EncodingProvider), Member = "GetEncodingFromProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001671")]
	public static Encoding GetEncoding(string name) { }

	[Address(RVA = "0x13292B0", Offset = "0x13284B0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60016A4")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x600169A")]
	public abstract int GetMaxByteCount(int charCount) { }

	[Token(Token = "0x600169B")]
	public abstract int GetMaxCharCount(int byteCount) { }

	[Address(RVA = "0x1329320", Offset = "0x1328520", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001672")]
	public override Byte[] GetPreamble() { }

	[Address(RVA = "0x1329520", Offset = "0x1328720", Length = "0x168")]
	[CalledBy(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(string), Member = "CreateStringFromEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001693")]
	public string GetString(ReadOnlySpan<Byte> bytes) { }

	[Address(RVA = "0x1329420", Offset = "0x1328620", Length = "0xFC")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsX509Name", Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "CreateStringForSByteConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureData), Member = "idx2string", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "U8Xml.RawString", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateStringFromEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CLSCompliant(False)]
	[ComVisible(False)]
	[Token(Token = "0x6001692")]
	public string GetString(Byte* bytes, int byteCount) { }

	[Address(RVA = "0x1329370", Offset = "0x1328570", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600169C")]
	public override string GetString(Byte[] bytes) { }

	[Address(RVA = "0x1329690", Offset = "0x1328890", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600169D")]
	public override string GetString(Byte[] bytes, int index, int count) { }

	[Address(RVA = "0x13296C0", Offset = "0x13288C0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001668")]
	internal void OnDeserialized() { }

	[Address(RVA = "0x13296C0", Offset = "0x13288C0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[OnDeserialized]
	[Token(Token = "0x600166A")]
	private void OnDeserialized(StreamingContext ctx) { }

	[Address(RVA = "0x1329710", Offset = "0x1328910", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001667")]
	internal void OnDeserializing() { }

	[Address(RVA = "0x1329710", Offset = "0x1328910", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[OnDeserializing]
	[Token(Token = "0x6001669")]
	private void OnDeserializing(StreamingContext ctx) { }

	[Address(RVA = "0xCF50B0", Offset = "0xCF42B0", Length = "0x13")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[OnSerializing]
	[Token(Token = "0x600166B")]
	private void OnSerializing(StreamingContext ctx) { }

	[Address(RVA = "0x1329750", Offset = "0x1328950", Length = "0x168")]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "System.Runtime.Serialization.ISerializable.GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600166D")]
	internal void SerializeEncoding(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x132A550", Offset = "0x1329750", Length = "0xCA")]
	[CalledBy(Type = typeof(EncodingProvider), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.UriComponents"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.Char[]", typeof(Int32&), typeof(char), typeof(char), typeof(char), "System.UnescapeMode", "System.UriParser", typeof(bool)}, ReturnType = "System.Char[]")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600167B")]
	public void set_DecoderFallback(DecoderFallback value) { }

	[Address(RVA = "0x132A620", Offset = "0x1329820", Length = "0xCA")]
	[CalledBy(Type = typeof(EncodingProvider), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EncoderFallback), typeof(DecoderFallback)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.UriComponents"}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.Char[]", typeof(Int32&), typeof(char), typeof(char), typeof(char), "System.UnescapeMode", "System.UriParser", typeof(bool)}, ReturnType = "System.Char[]")]
	[CalledBy(Type = "System.Xml.XmlEncodedRawTextWriter", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), "System.Xml.XmlWriterSettings"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001679")]
	public void set_EncoderFallback(EncoderFallback value) { }

	[Address(RVA = "0x13298C0", Offset = "0x1328AC0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InternalDecoderBestFitFallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001666")]
	internal override void SetDefaultFallbacks() { }

	[Address(RVA = "0x3292F0", Offset = "0x3284F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001697")]
	internal void setReadOnly(bool value = true) { }

	[Address(RVA = "0x1329960", Offset = "0x1328B60", Length = "0x10B")]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "AddByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingByteBuffer), Member = "MovePrevious", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016A7")]
	internal void ThrowBytesOverflow() { }

	[Address(RVA = "0x1329A70", Offset = "0x1328C70", Length = "0x93")]
	[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(Byte*), typeof(int), typeof(EncoderNLS)}, ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Encoder), Member = "get_FallbackBuffer", ReturnType = typeof(EncoderFallbackBuffer))]
	[Calls(Type = typeof(EncoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "ThrowBytesOverflow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60016A8")]
	internal void ThrowBytesOverflow(EncoderNLS encoder, bool nothingEncoded) { }

	[Address(RVA = "0x1329C20", Offset = "0x1328E20", Length = "0x93")]
	[CalledBy(Type = typeof(ASCIIEncoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Latin1Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF32Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF7Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UTF8Encoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnicodeEncoding), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int), typeof(Char*), typeof(int), typeof(DecoderNLS)}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Decoder), Member = "get_FallbackBuffer", ReturnType = typeof(DecoderFallbackBuffer))]
	[Calls(Type = typeof(DecoderFallbackBuffer), Member = "InternalReset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "ThrowCharsOverflow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60016AA")]
	internal void ThrowCharsOverflow(DecoderNLS decoder, bool nothingDecoded) { }

	[Address(RVA = "0x1329B10", Offset = "0x1328D10", Length = "0x10B")]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EncodingCharBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Encoding), Member = "ThrowCharsOverflow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecoderNLS), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60016A9")]
	internal void ThrowCharsOverflow() { }

}

