namespace System.Xml;

[Token(Token = "0x20000B3")]
public class XmlException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000411")]
	private string res; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000412")]
	private String[] args; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000413")]
	private int lineNumber; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000414")]
	private int linePosition; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[OptionalField]
	[Token(Token = "0x4000415")]
	private string sourceUri; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000416")]
	private string message; //Field offset: 0xB0

	[Token(Token = "0x170001CC")]
	public int LineNumber
	{
		[Address(RVA = "0x508E60", Offset = "0x508060", Length = "0x7")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000804")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001CD")]
	public int LinePosition
	{
		[Address(RVA = "0x126F110", Offset = "0x126E310", Length = "0x7")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000805")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001CE")]
	public virtual string Message
	{
		[Address(RVA = "0x16B89D0", Offset = "0x16B7BD0", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		[Token(Token = "0x6000806")]
		 get { } //Length: 25
	}

	[Token(Token = "0x170001CF")]
	internal string ResString
	{
		[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000807")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x16B7EF0", Offset = "0x16B70F0", Length = "0x48D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Current", ReturnType = typeof(SerializationEntry))]
	[Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007F0")]
	protected XmlException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x16B8790", Offset = "0x16B7990", Length = "0xCE")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60007FE")]
	internal XmlException(string res, String[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	[Address(RVA = "0x16B83E0", Offset = "0x16B75E0", Length = "0x2A")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007FD")]
	internal XmlException(string res, String[] args, Exception innerException, int lineNumber, int linePosition) { }

	[Address(RVA = "0x16B8510", Offset = "0x16B7710", Length = "0x31")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007FC")]
	internal XmlException(string res, String[] args, int lineNumber, int linePosition, string sourceUri) { }

	[Address(RVA = "0x16B8410", Offset = "0x16B7610", Length = "0xC7")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007FA")]
	internal XmlException(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	[Address(RVA = "0x16B7E20", Offset = "0x16B7020", Length = "0xC0")]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007F9")]
	internal XmlException(string res, string arg, int lineNumber, int linePosition) { }

	[Address(RVA = "0x16B8860", Offset = "0x16B7A60", Length = "0xBC")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007F8")]
	internal XmlException(string res, string arg, string sourceUri) { }

	[Address(RVA = "0x16B84E0", Offset = "0x16B76E0", Length = "0x2A")]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(ExceptionType), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007FB")]
	internal XmlException(string res, String[] args, int lineNumber, int linePosition) { }

	[Address(RVA = "0x16B8760", Offset = "0x16B7960", Length = "0x25")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValidateNames), Member = "ThrowInvalidName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValidateNames), Member = "GetInvalidNameException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyNMTOKEN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007F6")]
	internal XmlException(string res, String[] args) { }

	[Address(RVA = "0x16B8550", Offset = "0x16B7750", Length = "0x206")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007F5")]
	internal XmlException(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	[Address(RVA = "0x16B7DF0", Offset = "0x16B6FF0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007F4")]
	public XmlException(string message, Exception innerException, int lineNumber, int linePosition) { }

	[Address(RVA = "0x16B8380", Offset = "0x16B7580", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007F3")]
	public XmlException(string message) { }

	[Address(RVA = "0x16B83B0", Offset = "0x16B75B0", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007F2")]
	public XmlException() { }

	[Address(RVA = "0x16B8920", Offset = "0x16B7B20", Length = "0xAD")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60007F7")]
	internal XmlException(string res, string arg) { }

	[Address(RVA = "0x16B7670", Offset = "0x16B6870", Length = "0x62")]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEncodedRawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteDocType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "InvalidCharsException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlDocument), Member = "CheckName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidNameCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(ValidateNames), Member = "ThrowInvalidName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValidateNames), Member = "GetInvalidNameException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "VerifyQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlConvert), Member = "TryVerifyNMTOKEN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000801")]
	internal static String[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	[Address(RVA = "0x16B7970", Offset = "0x16B6B70", Length = "0x5D")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000802")]
	internal static String[] BuildCharExceptionArgs(Char[] data, int length, int invCharIndex) { }

	[Address(RVA = "0x16B76E0", Offset = "0x16B68E0", Length = "0x288")]
	[CalledBy(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), "System.Xml.XmlTextReaderImpl+NodeData"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.DtdParser+LiteralType"}, ReturnType = "System.Xml.DtdParser+Token")]
	[CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlConvert), Member = "CreateInvalidCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(ExceptionType)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "CombineSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000803")]
	internal static String[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	[Address(RVA = "0x16B79D0", Offset = "0x16B6BD0", Length = "0x1B1")]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlException), Member = "FormatUserMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SR), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Token(Token = "0x6000800")]
	private static string CreateMessage(string res, String[] args, int lineNumber, int linePosition) { }

	[Address(RVA = "0x16B7B90", Offset = "0x16B6D90", Length = "0x10E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlException), Member = "CreateMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007FF")]
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	[Address(RVA = "0x508E60", Offset = "0x508060", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000804")]
	public int get_LineNumber() { }

	[Address(RVA = "0x126F110", Offset = "0x126E310", Length = "0x7")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000805")]
	public int get_LinePosition() { }

	[Address(RVA = "0x16B89D0", Offset = "0x16B7BD0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	[Token(Token = "0x6000806")]
	public virtual string get_Message() { }

	[Address(RVA = "0x2DD200", Offset = "0x2DC400", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000807")]
	internal string get_ResString() { }

	[Address(RVA = "0x16B7CA0", Offset = "0x16B6EA0", Length = "0x14A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60007F1")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

