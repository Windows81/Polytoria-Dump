namespace System.Xml;

[Token(Token = "0x2000058")]
internal class XmlWellFormedWriter : XmlWriter
{
	[Token(Token = "0x2000061")]
	private class AttributeValueCache
	{
		[Token(Token = "0x2000064")]
		private class BufferChunk
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40002B0")]
			internal Char[] buffer; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40002B1")]
			internal int index; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x40002B2")]
			internal int count; //Field offset: 0x1C

			[Address(RVA = "0x1405D00", Offset = "0x1404F00", Length = "0x52")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000461")]
			internal BufferChunk(Char[] buffer, int index, int count) { }

		}

		[Token(Token = "0x2000063")]
		private class Item
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40002AE")]
			internal ItemType type; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x40002AF")]
			internal object data; //Field offset: 0x18

			[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
			[CallerCount(Count = 2609)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600045F")]
			internal Item() { }

			[Address(RVA = "0x1398BC0", Offset = "0x1397DC0", Length = "0x13")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000460")]
			internal void Set(ItemType type, object data) { }

		}

		[Token(Token = "0x2000062")]
		private enum ItemType
		{
			EntityRef = 0,
			CharEntity = 1,
			SurrogateCharEntity = 2,
			Whitespace = 3,
			String = 4,
			StringChars = 5,
			Raw = 6,
			RawChars = 7,
			ValueString = 8,
		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400029F")]
		private StringBuilder stringValue; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40002A0")]
		private string singleStringValue; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40002A1")]
		private Item[] items; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40002A2")]
		private int firstItem; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x40002A3")]
		private int lastItem; //Field offset: 0x2C

		[Token(Token = "0x170000CB")]
		internal string StringValue
		{
			[Address(RVA = "0x166AC60", Offset = "0x1669E60", Length = "0x3A")]
			[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
			[CallerCount(Count = 4)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x600044F")]
			internal get { } //Length: 58
		}

		[Address(RVA = "0x166ABF0", Offset = "0x1669DF0", Length = "0x6D")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "SetSpecialAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+SpecialAttribute"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600045E")]
		public AttributeValueCache() { }

		[Address(RVA = "0x16698B0", Offset = "0x1668AB0", Length = "0x187")]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "StartComplexValue", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "WriteEntityRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AttributeValueCache), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600045D")]
		private void AddItem(ItemType type, object data) { }

		[Address(RVA = "0x1669A40", Offset = "0x1668C40", Length = "0x47")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600045B")]
		internal void Clear() { }

		[Address(RVA = "0x166AC60", Offset = "0x1669E60", Length = "0x3A")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600044F")]
		internal string get_StringValue() { }

		[Address(RVA = "0x1669A90", Offset = "0x1668C90", Length = "0xB4")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[ContainsInvalidInstructions]
		[Token(Token = "0x6000459")]
		internal void Replay(XmlWriter writer) { }

		[Address(RVA = "0x1669ED0", Offset = "0x16690D0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600045C")]
		private void StartComplexValue() { }

		[Address(RVA = "0x1669F20", Offset = "0x1669120", Length = "0x2C4")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(XmlConvert), Member = "TrimStringStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsInvalidInstructions]
		[Token(Token = "0x600045A")]
		internal void Trim() { }

		[Address(RVA = "0x166A3F0", Offset = "0x16695F0", Length = "0xAA")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000451")]
		internal void WriteCharEntity(char ch) { }

		[Address(RVA = "0x166A4A0", Offset = "0x16696A0", Length = "0x104")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000455")]
		internal void WriteChars(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x166A5B0", Offset = "0x16697B0", Length = "0x1C2")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEntityRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[Token(Token = "0x6000450")]
		internal void WriteEntityRef(string name) { }

		[Address(RVA = "0x166A810", Offset = "0x1669A10", Length = "0x104")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000456")]
		internal void WriteRaw(Char[] buffer, int index, int count) { }

		[Address(RVA = "0x166A780", Offset = "0x1669980", Length = "0x89")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000457")]
		internal void WriteRaw(string data) { }

		[Address(RVA = "0x166A920", Offset = "0x1669B20", Length = "0xA6")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000454")]
		internal void WriteString(string text) { }

		[Address(RVA = "0x166A9D0", Offset = "0x1669BD0", Length = "0xFB")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000452")]
		internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

		[Address(RVA = "0x166AAD0", Offset = "0x1669CD0", Length = "0x89")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000458")]
		internal void WriteValue(string value) { }

		[Address(RVA = "0x166AB60", Offset = "0x1669D60", Length = "0x89")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(AttributeValueCache), Member = "AddItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWellFormedWriter+AttributeValueCache+ItemType", typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000453")]
		internal void WriteWhitespace(string ws) { }

	}

	[Token(Token = "0x200005F")]
	private struct AttrName
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000295")]
		internal string prefix; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000296")]
		internal string namespaceUri; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000297")]
		internal string localName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000298")]
		internal int prev; //Field offset: 0x18

		[Address(RVA = "0x16697D0", Offset = "0x16689D0", Length = "0x80")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Token(Token = "0x600044E")]
		internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }

		[Address(RVA = "0x1669850", Offset = "0x1668A50", Length = "0x57")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600044D")]
		internal void Set(string prefix, string localName, string namespaceUri) { }

	}

	[Token(Token = "0x200005C")]
	private struct ElementScope
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000286")]
		internal int prevNSTop; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000287")]
		internal string prefix; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000288")]
		internal string localName; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000289")]
		internal string namespaceUri; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400028A")]
		internal XmlSpace xmlSpace; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400028B")]
		internal string xmlLang; //Field offset: 0x28

		[Address(RVA = "0x166B4F0", Offset = "0x166A6F0", Length = "0x74")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000448")]
		internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

		[Address(RVA = "0x166B570", Offset = "0x166A770", Length = "0x3E")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndElement", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000449")]
		internal void WriteEndElement(XmlRawWriter rawWriter) { }

		[Address(RVA = "0x166B5B0", Offset = "0x166A7B0", Length = "0x3E")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteFullEndElement", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600044A")]
		internal void WriteFullEndElement(XmlRawWriter rawWriter) { }

	}

	[Token(Token = "0x200005E")]
	private struct Namespace
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000291")]
		internal string prefix; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000292")]
		internal string namespaceUri; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000293")]
		internal NamespaceKind kind; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000294")]
		internal int prevNsIndex; //Field offset: 0x14

		[Address(RVA = "0x166B640", Offset = "0x166A840", Length = "0x4A")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlWriterSettings)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Xml.XmlWellFormedWriter+NamespaceKind"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600044B")]
		internal void Set(string prefix, string namespaceUri, NamespaceKind kind) { }

		[Address(RVA = "0x166B690", Offset = "0x166A890", Length = "0x12D")]
		[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "StartElementContent", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x600044C")]
		internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

	}

	[Token(Token = "0x200005D")]
	private enum NamespaceKind
	{
		Written = 0,
		NeedToWrite = 1,
		Implied = 2,
		Special = 3,
	}

	[Token(Token = "0x200005B")]
	private class NamespaceResolverProxy : IXmlNamespaceResolver
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000285")]
		private XmlWellFormedWriter wfWriter; //Field offset: 0x10

		[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
		[CallerCount(Count = 72)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000445")]
		internal NamespaceResolverProxy(XmlWellFormedWriter wfWriter) { }

		[Address(RVA = "0x166B5F0", Offset = "0x166A7F0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000446")]
		private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

		[Address(RVA = "0x166B610", Offset = "0x166A810", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000447")]
		private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	}

	[Token(Token = "0x2000060")]
	private enum SpecialAttribute
	{
		No = 0,
		DefaultXmlns = 1,
		PrefixedXmlns = 2,
		XmlSpace = 3,
		XmlLang = 4,
	}

	[Token(Token = "0x2000059")]
	private enum State
	{
		Start = 0,
		TopLevel = 1,
		Document = 2,
		Element = 3,
		Content = 4,
		B64Content = 5,
		B64Attribute = 6,
		AfterRootEle = 7,
		Attribute = 8,
		SpecialAttr = 9,
		EndDocument = 10,
		RootLevelAttr = 11,
		RootLevelSpecAttr = 12,
		RootLevelB64Attr = 13,
		AfterRootLevelAttr = 14,
		Closed = 15,
		Error = 16,
		StartContent = 101,
		StartContentEle = 102,
		StartContentB64 = 103,
		StartDoc = 104,
		StartDocEle = 106,
		EndAttrSEle = 107,
		EndAttrEEle = 108,
		EndAttrSCont = 109,
		EndAttrSAttr = 111,
		PostB64Cont = 112,
		PostB64Attr = 113,
		PostB64RootAttr = 114,
		StartFragEle = 115,
		StartFragCont = 116,
		StartFragB64 = 117,
		StartRootLevelAttr = 118,
	}

	[Token(Token = "0x200005A")]
	private enum Token
	{
		StartDocument = 0,
		EndDocument = 1,
		PI = 2,
		Comment = 3,
		Dtd = 4,
		StartElement = 5,
		EndElement = 6,
		StartAttribute = 7,
		EndAttribute = 8,
		Text = 9,
		CData = 10,
		AtomicValue = 11,
		Base64 = 12,
		RawData = 13,
		Whitespace = 14,
	}

	[Token(Token = "0x400024E")]
	internal static readonly String[] stateName; //Field offset: 0x0
	[Token(Token = "0x400024F")]
	internal static readonly String[] tokenName; //Field offset: 0x8
	[Token(Token = "0x4000250")]
	private static WriteState[] state2WriteState; //Field offset: 0x10
	[Token(Token = "0x4000251")]
	private static readonly State[] StateTableDocument; //Field offset: 0x18
	[Token(Token = "0x4000252")]
	private static readonly State[] StateTableAuto; //Field offset: 0x20
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000235")]
	private XmlWriter writer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000236")]
	private XmlRawWriter rawWriter; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000237")]
	private IXmlNamespaceResolver predefinedNamespaces; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000238")]
	private Namespace[] nsStack; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000239")]
	private int nsTop; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400023A")]
	private Dictionary<String, Int32> nsHashtable; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400023B")]
	private bool useNsHashtable; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400023C")]
	private ElementScope[] elemScopeStack; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400023D")]
	private int elemTop; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400023E")]
	private AttrName[] attrStack; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400023F")]
	private int attrCount; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000240")]
	private Dictionary<String, Int32> attrHashTable; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000241")]
	private SpecialAttribute specAttr; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000242")]
	private AttributeValueCache attrValueCache; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000243")]
	private string curDeclPrefix; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000244")]
	private State[] stateTable; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000245")]
	private State currentState; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000246")]
	private bool checkCharacters; //Field offset: 0x94
	[FieldOffset(Offset = "0x95")]
	[Token(Token = "0x4000247")]
	private bool omitDuplNamespaces; //Field offset: 0x95
	[FieldOffset(Offset = "0x96")]
	[Token(Token = "0x4000248")]
	private bool writeEndDocumentOnClose; //Field offset: 0x96
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000249")]
	private ConformanceLevel conformanceLevel; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x400024A")]
	private bool dtdWritten; //Field offset: 0x9C
	[FieldOffset(Offset = "0x9D")]
	[Token(Token = "0x400024B")]
	private bool xmlDeclFollows; //Field offset: 0x9D
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400024C")]
	private XmlCharType xmlCharType; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400024D")]
	private SecureStringHasher hasher; //Field offset: 0xA8

	[Token(Token = "0x170000C9")]
	private bool InBase64
	{
		[Address(RVA = "0x16696F0", Offset = "0x16688F0", Length = "0x20")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600042D")]
		private get { } //Length: 32
	}

	[Token(Token = "0x170000CA")]
	private bool IsClosedOrErrorState
	{
		[Address(RVA = "0x1669710", Offset = "0x1668910", Length = "0xB")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000441")]
		private get { } //Length: 11
	}

	[Token(Token = "0x170000C7")]
	internal XmlRawWriter RawWriter
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600042B")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170000C8")]
	private bool SaveAttrValue
	{
		[Address(RVA = "0x1669720", Offset = "0x1668920", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600042C")]
		private get { } //Length: 8
	}

	[Token(Token = "0x170000C6")]
	public virtual WriteState WriteState
	{
		[Address(RVA = "0x1669730", Offset = "0x1668930", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000410")]
		 get { } //Length: 137
	}

	[Address(RVA = "0x1668A90", Offset = "0x1667C90", Length = "0x759")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000444")]
	private static XmlWellFormedWriter() { }

	[Address(RVA = "0x16691F0", Offset = "0x16683F0", Length = "0x4F0")]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(XmlWriter))]
	[CalledBy(Type = typeof(XmlWriterSettings), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(XmlWriter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ElementScope), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Namespace), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NamespaceKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(SecureStringHasher), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600040F")]
	internal XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings) { }

	[Address(RVA = "0x16637C0", Offset = "0x16629C0", Length = "0x2D4")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "DupAttrException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AttrName), Member = "IsDuplicate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AddToAttrHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(AttrName), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Token(Token = "0x6000442")]
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	[Address(RVA = "0x1663AA0", Offset = "0x1662CA0", Length = "0x18F")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Namespace), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NamespaceKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEqualityComparer`1<TKey>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AddToNamespaceHashtable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000433")]
	private void AddNamespace(string prefix, string ns, NamespaceKind kind) { }

	[Address(RVA = "0x1663C30", Offset = "0x1662E30", Length = "0x148")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000443")]
	private void AddToAttrHashTable(int attributeIndex) { }

	[Address(RVA = "0x1663D80", Offset = "0x1662F80", Length = "0xD2")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NamespaceKind)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000434")]
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	[Address(RVA = "0x1663E60", Offset = "0x1663060", Length = "0x8C")]
	[CallerCount(Count = 25)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000438")]
	private void AdvanceState(Token token) { }

	[Address(RVA = "0x1664290", Offset = "0x1663490", Length = "0x143")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteProcessingInstruction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEntityRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "InvalidCharsException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600043E")]
	private void CheckNCName(string ncname) { }

	[Address(RVA = "0x16643E0", Offset = "0x16635E0", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181656D70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000426")]
	public virtual void Close() { }

	[Address(RVA = "0x1664520", Offset = "0x1663720", Length = "0xFB")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000437")]
	private static XmlException DupAttrException(string prefix, string localName) { }

	[Address(RVA = "0x1664620", Offset = "0x1663820", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000427")]
	public virtual void Flush() { }

	[Address(RVA = "0x1664680", Offset = "0x1663880", Length = "0x135")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x600043D")]
	private string GeneratePrefix() { }

	[Address(RVA = "0x16696F0", Offset = "0x16688F0", Length = "0x20")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600042D")]
	private bool get_InBase64() { }

	[Address(RVA = "0x1669710", Offset = "0x1668910", Length = "0xB")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000441")]
	private bool get_IsClosedOrErrorState() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600042B")]
	internal XmlRawWriter get_RawWriter() { }

	[Address(RVA = "0x1669720", Offset = "0x1668920", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600042C")]
	private bool get_SaveAttrValue() { }

	[Address(RVA = "0x1669730", Offset = "0x1668930", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000410")]
	public virtual WriteState get_WriteState() { }

	[Address(RVA = "0x16647C0", Offset = "0x16639C0", Length = "0x8C")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "ThrowInvalidStateTransition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token), typeof(State)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600043A")]
	private static string GetStateName(State state) { }

	[Address(RVA = "0x1664850", Offset = "0x1663A50", Length = "0x11E")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600043F")]
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	[Address(RVA = "0x1664970", Offset = "0x1663B70", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600043C")]
	private string LookupLocalNamespace(string prefix) { }

	[Address(RVA = "0x1664B20", Offset = "0x1663D20", Length = "0xE4")]
	[CalledBy(Type = typeof(NamespaceResolverProxy), Member = "System.Xml.IXmlNamespaceResolver.LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "GeneratePrefix", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600043B")]
	internal string LookupNamespace(string prefix) { }

	[Address(RVA = "0x1664A30", Offset = "0x1663C30", Length = "0xE7")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000435")]
	private int LookupNamespaceIndex(string prefix) { }

	[Address(RVA = "0x1664C10", Offset = "0x1663E10", Length = "0x1B4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000428")]
	public virtual string LookupPrefix(string ns) { }

	[Address(RVA = "0x1664DD0", Offset = "0x1663FD0", Length = "0xE8")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteFullEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Int32>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000436")]
	private void PopNamespaces(int indexFrom, int indexTo) { }

	[Address(RVA = "0x1664EC0", Offset = "0x16640C0", Length = "0x55F")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteEndAttribute", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "DupAttrException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018E970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NamespaceKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespaceIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x6000432")]
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	[Address(RVA = "0x1665420", Offset = "0x1664620", Length = "0x458")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18018E970")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NamespaceKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespaceIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x6000431")]
	private void PushNamespaceImplicit(string prefix, string ns) { }

	[Address(RVA = "0x1665880", Offset = "0x1664A80", Length = "0x91")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AttributeValueCache), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600042E")]
	private void SetSpecialAttribute(SpecialAttribute special) { }

	[Address(RVA = "0x1665920", Offset = "0x1664B20", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Namespace), Member = "WriteDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlRawWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000439")]
	private void StartElementContent() { }

	[Address(RVA = "0x1665A10", Offset = "0x1664C10", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000430")]
	private void StartFragment() { }

	[Address(RVA = "0x1665A20", Offset = "0x1664C20", Length = "0x213")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "GetStateName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(State)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000440")]
	private void ThrowInvalidStateTransition(Token token, State currentState) { }

	[Address(RVA = "0x1665C40", Offset = "0x1664E40", Length = "0x1DB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000425")]
	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1665E20", Offset = "0x1665020", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWriter), Member = "WriteBinHex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600042A")]
	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	[Address(RVA = "0x1665F10", Offset = "0x1665110", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600041A")]
	public virtual void WriteCData(string text) { }

	[Address(RVA = "0x1665FB0", Offset = "0x16651B0", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeValueCache), Member = "WriteCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600041E")]
	public virtual void WriteCharEntity(char ch) { }

	[Address(RVA = "0x16660D0", Offset = "0x16652D0", Length = "0x20A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(AttributeValueCache), Member = "WriteChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000422")]
	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x16662E0", Offset = "0x16654E0", Length = "0x92")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600041B")]
	public virtual void WriteComment(string text) { }

	[Address(RVA = "0x1666380", Offset = "0x1665580", Length = "0x468")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "VerifyQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ExceptionType)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000414")]
	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	[Address(RVA = "0x16667F0", Offset = "0x16659F0", Length = "0x87F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(AttributeValueCache), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceExplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AttributeValueCache), Member = "Trim", ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeValueCache), Member = "Replay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AttributeValueCache), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 14)]
	[Token(Token = "0x6000419")]
	public virtual void WriteEndAttribute() { }

	[Address(RVA = "0x1667070", Offset = "0x1666270", Length = "0x101")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000413")]
	public virtual void WriteEndDocument() { }

	[Address(RVA = "0x1667180", Offset = "0x1666380", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ElementScope), Member = "WriteEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRawWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "PopNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000416")]
	public virtual void WriteEndElement() { }

	[Address(RVA = "0x1667320", Offset = "0x1666520", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeValueCache), Member = "WriteEntityRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600041D")]
	public virtual void WriteEntityRef(string name) { }

	[Address(RVA = "0x1667430", Offset = "0x1666630", Length = "0x195")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ElementScope), Member = "WriteFullEndElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRawWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "PopNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000417")]
	public virtual void WriteFullEndElement() { }

	[Address(RVA = "0x16675D0", Offset = "0x16667D0", Length = "0x24B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600041C")]
	public virtual void WriteProcessingInstruction(string name, string text) { }

	[Address(RVA = "0x1667820", Offset = "0x1666A20", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeValueCache), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000424")]
	public virtual void WriteRaw(string data) { }

	[Address(RVA = "0x16678D0", Offset = "0x1666AD0", Length = "0x20A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180003A10")]
	[Calls(Type = typeof(AttributeValueCache), Member = "WriteRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000423")]
	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	[Address(RVA = "0x1667AE0", Offset = "0x1666CE0", Length = "0x6B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "GeneratePrefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "SetSpecialAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpecialAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000418")]
	public virtual void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	[Address(RVA = "0x1668360", Offset = "0x1667560", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "WriteStartDocumentImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlStandalone)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000411")]
	public virtual void WriteStartDocument() { }

	[Address(RVA = "0x1668330", Offset = "0x1667530", Length = "0x22")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "WriteStartDocumentImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlStandalone)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000412")]
	public virtual void WriteStartDocument(bool standalone) { }

	[Address(RVA = "0x16681A0", Offset = "0x16673A0", Length = "0x188")]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartDocument", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlWellFormedWriter), Member = "WriteStartDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600042F")]
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	[Address(RVA = "0x1668370", Offset = "0x1667570", Length = "0x363")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "PushNamespaceImplicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ElementScope), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "CheckNCName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000415")]
	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	[Address(RVA = "0x16686E0", Offset = "0x16678E0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeValueCache), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000421")]
	public virtual void WriteString(string text) { }

	[Address(RVA = "0x1668790", Offset = "0x1667990", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsSurrogatePair", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeValueCache), Member = "WriteSurrogateCharEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(XmlConvert), Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600041F")]
	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	[Address(RVA = "0x16688B0", Offset = "0x1667AB0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeValueCache), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000429")]
	public virtual void WriteValue(string value) { }

	[Address(RVA = "0x1668960", Offset = "0x1667B60", Length = "0x12F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsOnlyWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlWellFormedWriter), Member = "AdvanceState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Token)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AttributeValueCache), Member = "WriteWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000420")]
	public virtual void WriteWhitespace(string ws) { }

}

