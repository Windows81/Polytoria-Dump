namespace System.Xml;

[Token(Token = "0x2000035")]
internal sealed class XmlEventCache : XmlRawWriter
{
	[Token(Token = "0x2000037")]
	private struct XmlEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CF")]
		private XmlEventType eventType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40000D0")]
		private string s1; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000D1")]
		private string s2; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000D2")]
		private string s3; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000D3")]
		private object o; //Field offset: 0x20

		[Token(Token = "0x1700003B")]
		public XmlEventType EventType
		{
			[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
			[CallerCount(Count = 129)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001CE")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700003F")]
		public object Object
		{
			[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
			[CallerCount(Count = 11)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001D2")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700003C")]
		public string String1
		{
			[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001CF")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700003D")]
		public string String2
		{
			[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
			[CallerCount(Count = 50)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001D0")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700003E")]
		public string String3
		{
			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[DeduplicatedMethod]
			[Token(Token = "0x60001D1")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CE")]
		public XmlEventType get_EventType() { }

		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D2")]
		public object get_Object() { }

		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CF")]
		public string get_String1() { }

		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D0")]
		public string get_String2() { }

		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D1")]
		public string get_String3() { }

		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C8")]
		public void InitEvent(XmlEventType eventType) { }

		[Address(RVA = "0x880C00", Offset = "0x87FE00", Length = "0x12")]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001C9")]
		public void InitEvent(XmlEventType eventType, string s1) { }

		[Address(RVA = "0x4004F0", Offset = "0x3FF6F0", Length = "0x3C")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CA")]
		public void InitEvent(XmlEventType eventType, string s1, string s2) { }

		[Address(RVA = "0x1076BD0", Offset = "0x1075DD0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001CB")]
		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3) { }

		[Address(RVA = "0x163A590", Offset = "0x1639790", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001CC")]
		public void InitEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

		[Address(RVA = "0x163A570", Offset = "0x1639770", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001CD")]
		public void InitEvent(XmlEventType eventType, object o) { }

	}

	[Token(Token = "0x2000036")]
	private enum XmlEventType
	{
		Unknown = 0,
		DocType = 1,
		StartElem = 2,
		StartAttr = 3,
		EndAttr = 4,
		CData = 5,
		Comment = 6,
		PI = 7,
		Whitespace = 8,
		String = 9,
		Raw = 10,
		EntRef = 11,
		CharEnt = 12,
		SurrCharEnt = 13,
		Base64 = 14,
		BinHex = 15,
		XmlDecl1 = 16,
		XmlDecl2 = 17,
		StartContent = 18,
		EndElem = 19,
		FullEndElem = 20,
		Nmsp = 21,
		EndBase64 = 22,
		Close = 23,
		Flush = 24,
		Dispose = 25,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000AE")]
	private List<XmlEvent[]> pages; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000AF")]
	private XmlEvent[] pageCurr; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000B0")]
	private int pageSize; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40000B1")]
	private bool hasRootNode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000B2")]
	private StringConcat singleText; //Field offset: 0x38
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40000B3")]
	private string baseUri; //Field offset: 0x70

	[Address(RVA = "0x163A520", Offset = "0x1639720", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001A1")]
	public XmlEventCache(string baseUri, bool hasRootNode) { }

	[Address(RVA = "0x1638CF0", Offset = "0x1637EF0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C5")]
	private void AddEvent(XmlEventType eventType, object o) { }

	[Address(RVA = "0x1638D60", Offset = "0x1637F60", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C4")]
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3, object o) { }

	[Address(RVA = "0x1638C00", Offset = "0x1637E00", Length = "0x93")]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C3")]
	private void AddEvent(XmlEventType eventType, string s1, string s2, string s3) { }

	[Address(RVA = "0x1638E80", Offset = "0x1638080", Length = "0x81")]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteNamespaceDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C2")]
	private void AddEvent(XmlEventType eventType, string s1, string s2) { }

	[Address(RVA = "0x1638E10", Offset = "0x1638010", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C1")]
	private void AddEvent(XmlEventType eventType, string s1) { }

	[Address(RVA = "0x1638CA0", Offset = "0x1637EA0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001C0")]
	private void AddEvent(XmlEventType eventType) { }

	[Address(RVA = "0x1638F10", Offset = "0x1638110", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B5")]
	public virtual void Close() { }

	[Address(RVA = "0x1638F50", Offset = "0x1638150", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlWriter), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001B8")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x1639000", Offset = "0x1638200", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A2")]
	public void EndEvents() { }

	[Address(RVA = "0x1639050", Offset = "0x1638250", Length = "0x17C")]
	[CalledBy(Type = typeof(XmlAutoDetectWriter), Member = "CreateWrappedWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlOutputMethod)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60001A3")]
	public void EventsToWriter(XmlWriter writer) { }

	[Address(RVA = "0x1639A50", Offset = "0x1638C50", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B6")]
	public virtual void Flush() { }

	[Address(RVA = "0x1639A90", Offset = "0x1638C90", Length = "0x184")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringConcat), Member = "GetResult", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringConcat), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001C6")]
	private int NewEvent() { }

	[Address(RVA = "0x1639C20", Offset = "0x1638E20", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001BB")]
	internal virtual void StartElementContent() { }

	[Address(RVA = "0x1639C60", Offset = "0x1638E60", Length = "0xB2")]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteBase64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlEventCache), Member = "WriteBinHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C7")]
	private static Byte[] ToBytes(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1639D20", Offset = "0x1638F20", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "ToBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B3")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1639DA0", Offset = "0x1638FA0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "ToBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B4")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1639E20", Offset = "0x1639020", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A8")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x1639E80", Offset = "0x1639080", Length = "0x77")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B1")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x16334F0", Offset = "0x16326F0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AD")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1639F00", Offset = "0x1639100", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A9")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x1639F60", Offset = "0x1639160", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A4")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x163A010", Offset = "0x1639210", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001A7")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x163A050", Offset = "0x1639250", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001BF")]
	internal virtual void WriteEndBase64() { }

	[Address(RVA = "0x163A090", Offset = "0x1639290", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001BC")]
	internal virtual void WriteEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x163A0C0", Offset = "0x16392C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B0")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x163A120", Offset = "0x1639320", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001BD")]
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x163A150", Offset = "0x1639350", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001BE")]
	internal virtual void WriteNamespaceDeclaration(string prefix, string ns) { }

	[Address(RVA = "0x163A180", Offset = "0x1639380", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001AA")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x163A1B0", Offset = "0x16393B0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001AF")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x1633760", Offset = "0x1632960", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001AE")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x163A210", Offset = "0x1639410", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001A6")]
	public virtual void WriteStartAttribute(string prefix, string localName, string ns) { }

	[Address(RVA = "0x163A240", Offset = "0x1639440", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "AddEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlEventType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001A5")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x163A270", Offset = "0x1639470", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StringConcat), Member = "ConcatNoDelimiter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001AC")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x163A2F0", Offset = "0x16394F0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B2")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x143F620", Offset = "0x143E820", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001B7")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x163A3C0", Offset = "0x16395C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001AB")]
	public virtual void WriteWhitespace(string ws) { }

	[Address(RVA = "0x163A420", Offset = "0x1639620", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001B9")]
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	[Address(RVA = "0x163A4C0", Offset = "0x16396C0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlEventCache), Member = "NewEvent", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001BA")]
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

}

