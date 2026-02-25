namespace Mono.Xml;

[Token(Token = "0x2000048")]
internal class SmallXmlParser
{
	[Token(Token = "0x200004B")]
	private class AttrListImpl : IAttrList
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400014E")]
		private List<String> attrNames; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400014F")]
		private List<String> attrValues; //Field offset: 0x18

		[Token(Token = "0x17000013")]
		public override int Length
		{
			[Address(RVA = "0x12D71C0", Offset = "0x12D63C0", Length = "0x3C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x60000AD")]
			 get { } //Length: 60
		}

		[Token(Token = "0x17000014")]
		public override String[] Names
		{
			[Address(RVA = "0x12D7200", Offset = "0x12D6400", Length = "0x44")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x60000B1")]
			 get { } //Length: 68
		}

		[Token(Token = "0x17000015")]
		public override String[] Values
		{
			[Address(RVA = "0x12D7250", Offset = "0x12D6450", Length = "0x44")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x60000B2")]
			 get { } //Length: 68
		}

		[Address(RVA = "0x12D7110", Offset = "0x12D6310", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60000B5")]
		public AttrListImpl() { }

		[Address(RVA = "0x12D6DC0", Offset = "0x12D5FC0", Length = "0x127")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x60000B4")]
		internal void Add(string name, string value) { }

		[Address(RVA = "0x12D6EF0", Offset = "0x12D60F0", Length = "0x89")]
		[CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SmallXmlParser), Member = "Cleanup", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000B3")]
		internal void Clear() { }

		[Address(RVA = "0x12D71C0", Offset = "0x12D63C0", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000AD")]
		public override int get_Length() { }

		[Address(RVA = "0x12D7200", Offset = "0x12D6400", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000B1")]
		public override String[] get_Names() { }

		[Address(RVA = "0x12D7250", Offset = "0x12D6450", Length = "0x44")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000B2")]
		public override String[] get_Values() { }

		[Address(RVA = "0x12D6F80", Offset = "0x12D6180", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000AE")]
		public override string GetName(int i) { }

		[Address(RVA = "0x12D6FE0", Offset = "0x12D61E0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000AF")]
		public override string GetValue(int i) { }

		[Address(RVA = "0x12D7040", Offset = "0x12D6240", Length = "0xCA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x60000B0")]
		public override string GetValue(string name) { }

	}

	[Token(Token = "0x200004A")]
	internal interface IAttrList
	{

		[Token(Token = "0x17000010")]
		public int Length
		{
			[Token(Token = "0x60000A7")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000011")]
		public String[] Names
		{
			[Token(Token = "0x60000AB")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000012")]
		public String[] Values
		{
			[Token(Token = "0x60000AC")]
			 get { } //Length: 0
		}

		[Token(Token = "0x60000A7")]
		public int get_Length() { }

		[Token(Token = "0x60000AB")]
		public String[] get_Names() { }

		[Token(Token = "0x60000AC")]
		public String[] get_Values() { }

		[Token(Token = "0x60000A8")]
		public string GetName(int i) { }

		[Token(Token = "0x60000A9")]
		public string GetValue(int i) { }

		[Token(Token = "0x60000AA")]
		public string GetValue(string name) { }

	}

	[Token(Token = "0x2000049")]
	internal interface IContentHandler
	{

		[Token(Token = "0x60000A5")]
		public void OnChars(string text) { }

		[Token(Token = "0x60000A3")]
		public void OnEndElement(string name) { }

		[Token(Token = "0x60000A1")]
		public void OnEndParsing(SmallXmlParser parser) { }

		[Token(Token = "0x60000A6")]
		public void OnIgnorableWhitespace(string text) { }

		[Token(Token = "0x60000A4")]
		public void OnProcessingInstruction(string name, string text) { }

		[Token(Token = "0x60000A2")]
		public void OnStartElement(string name, IAttrList attrs) { }

		[Token(Token = "0x60000A0")]
		public void OnStartParsing(SmallXmlParser parser) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000142")]
	private IContentHandler handler; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000143")]
	private TextReader reader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000144")]
	private Stack elementNames; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000145")]
	private Stack xmlSpaces; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000146")]
	private string xmlSpace; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000147")]
	private StringBuilder buffer; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000148")]
	private Char[] nameBuffer; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000149")]
	private bool isWhitespace; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400014A")]
	private AttrListImpl attributes; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400014B")]
	private int line; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x400014C")]
	private int column; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400014D")]
	private bool resetColumn; //Field offset: 0x60

	[Address(RVA = "0x12E6DF0", Offset = "0x12E5FF0", Length = "0x1C1")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000089")]
	public SmallXmlParser() { }

	[Address(RVA = "0x12E4740", Offset = "0x12E3940", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AttrListImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000097")]
	private void Cleanup() { }

	[Address(RVA = "0x12E4800", Offset = "0x12E3A00", Length = "0xE0")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadComment", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600008A")]
	private Exception Error(string msg) { }

	[Address(RVA = "0x12E48E0", Offset = "0x12E3AE0", Length = "0x116")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadComment", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000093")]
	public void Expect(int c) { }

	[Address(RVA = "0x12E4A00", Offset = "0x12E3C00", Length = "0xCF")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000099")]
	private void HandleBufferedContent() { }

	[Address(RVA = "0x12E4AD0", Offset = "0x12E3CD0", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600008F")]
	private void HandleWhitespaces() { }

	[Address(RVA = "0x12E4BE0", Offset = "0x12E3DE0", Length = "0xC0")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008C")]
	private bool IsNameChar(char c, bool start) { }

	[Address(RVA = "0x12E4CD0", Offset = "0x12E3ED0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600008D")]
	private bool IsWhitespace(int c) { }

	[Address(RVA = "0x12E4CF0", Offset = "0x12E3EF0", Length = "0x20E")]
	[CalledBy(Type = typeof(SecurityParser), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SmallXmlParser), Member = "HandleBufferedContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AttrListImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000096")]
	public void Parse(TextReader input, IContentHandler handler) { }

	[Address(RVA = "0x12E4F00", Offset = "0x12E4100", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000091")]
	private int Peek() { }

	[Address(RVA = "0x12E6BC0", Offset = "0x12E5DC0", Length = "0x5A")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000092")]
	private int Read() { }

	[Address(RVA = "0x12E4F30", Offset = "0x12E4130", Length = "0x267")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600009D")]
	private void ReadAttribute(AttrListImpl a) { }

	[Address(RVA = "0x12E51A0", Offset = "0x12E43A0", Length = "0x14C")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600009E")]
	private void ReadCDATASection() { }

	[Address(RVA = "0x12E52F0", Offset = "0x12E44F0", Length = "0x1EB")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x600009C")]
	private int ReadCharacterReference() { }

	[Address(RVA = "0x12E54E0", Offset = "0x12E46E0", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600009A")]
	private void ReadCharacters() { }

	[Address(RVA = "0x12E5600", Offset = "0x12E4800", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600009F")]
	private void ReadComment() { }

	[Address(RVA = "0x12E5750", Offset = "0x12E4950", Length = "0xE8D")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(SmallXmlParser), Member = "HandleBufferedContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadCDATASection", ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 42)]
	[Token(Token = "0x6000098")]
	public void ReadContent() { }

	[Address(RVA = "0x12E65E0", Offset = "0x12E57E0", Length = "0x22C")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SmallXmlParser), Member = "IsNameChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000095")]
	public string ReadName() { }

	[Address(RVA = "0x12E6810", Offset = "0x12E5A10", Length = "0x260")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadCharacters", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadCharacterReference", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600009B")]
	private void ReadReference() { }

	[Address(RVA = "0x12E6A80", Offset = "0x12E5C80", Length = "0x133")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000094")]
	private string ReadUntil(char until, bool handleReferences) { }

	[Address(RVA = "0x12E6C30", Offset = "0x12E5E30", Length = "0xDF")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000090")]
	public void SkipWhitespaces(bool expected) { }

	[Address(RVA = "0x12E6C20", Offset = "0x12E5E20", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600008E")]
	public void SkipWhitespaces() { }

	[Address(RVA = "0x12E6D10", Offset = "0x12E5F10", Length = "0xD7")]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadCDATASection", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600008B")]
	private Exception UnexpectedEndError() { }

}

