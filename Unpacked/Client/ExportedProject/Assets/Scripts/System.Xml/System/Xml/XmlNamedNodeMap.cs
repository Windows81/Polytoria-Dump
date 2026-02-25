namespace System.Xml;

[Token(Token = "0x2000081")]
public class XmlNamedNodeMap : IEnumerable
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000082")]
	public struct SmallXmlNodeList
	{
		[Token(Token = "0x2000083")]
		private class SingleObjectEnumerator : IEnumerator
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000347")]
			private object loneValue; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000348")]
			private int position; //Field offset: 0x18

			[Token(Token = "0x17000179")]
			public override object Current
			{
				[Address(RVA = "0x166B820", Offset = "0x166AA20", Length = "0x55")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
				[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
				[Token(Token = "0x600062C")]
				 get { } //Length: 85
			}

			[Address(RVA = "0x166B7E0", Offset = "0x166A9E0", Length = "0x38")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600062B")]
			public SingleObjectEnumerator(object value) { }

			[Address(RVA = "0x166B820", Offset = "0x166AA20", Length = "0x55")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x600062C")]
			public override object get_Current() { }

			[Address(RVA = "0x166B7C0", Offset = "0x166A9C0", Length = "0x1A")]
			[CallerCount(Count = 0)]
			[Token(Token = "0x600062D")]
			public override bool MoveNext() { }

			[Address(RVA = "0x14CF520", Offset = "0x14CE720", Length = "0x8")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600062E")]
			public override void Reset() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000346")]
		private object field; //Field offset: 0x0

		[Token(Token = "0x17000177")]
		public int Count
		{
			[Address(RVA = "0x166BE10", Offset = "0x166B010", Length = "0x83")]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.get_Count", ReturnType = typeof(int))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Detach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlElement), Member = "GetAttributeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "get_Count", ReturnType = typeof(int))]
			[CallerCount(Count = 9)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000625")]
			 get { } //Length: 131
		}

		[Token(Token = "0x17000178")]
		public object Item
		{
			[Address(RVA = "0x166BEA0", Offset = "0x166B0A0", Length = "0x120")]
			[CalledBy(Type = typeof(XmlElement), Member = "GetAttributeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "GetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlNode))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Detach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
			[CallerCount(Count = 14)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000626")]
			 get { } //Length: 288
		}

		[Address(RVA = "0x166B880", Offset = "0x166AA80", Length = "0x143")]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(SmallXmlNodeList), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "AddNodeForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000627")]
		public void Add(object value) { }

		[Address(RVA = "0x166BE10", Offset = "0x166B010", Length = "0x83")]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.get_Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Detach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlElement), Member = "GetAttributeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000625")]
		public int get_Count() { }

		[Address(RVA = "0x166BEA0", Offset = "0x166B0A0", Length = "0x120")]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "GetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlElement), Member = "GetAttributeNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Detach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000626")]
		public object get_Item(int index) { }

		[Address(RVA = "0x166B9D0", Offset = "0x166ABD0", Length = "0x101")]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600062A")]
		public IEnumerator GetEnumerator() { }

		[Address(RVA = "0x166BAE0", Offset = "0x166ACE0", Length = "0x1FD")]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "InsertNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SmallXmlNodeList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x6000629")]
		public void Insert(int index, object value) { }

		[Address(RVA = "0x166BCE0", Offset = "0x166AEE0", Length = "0x12D")]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000628")]
		public void RemoveAt(int index) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000344")]
	internal XmlNode parent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000345")]
	internal SmallXmlNodeList nodes; //Field offset: 0x18

	[Token(Token = "0x17000176")]
	public override int Count
	{
		[Address(RVA = "0x166D290", Offset = "0x166C490", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x600061C")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000619")]
	internal XmlNamedNodeMap(XmlNode parent) { }

	[Address(RVA = "0x167D1E0", Offset = "0x167C3E0", Length = "0x19E")]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000620")]
	internal override XmlNode AddNode(XmlNode node) { }

	[Address(RVA = "0x167D110", Offset = "0x167C310", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000621")]
	internal override XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	[Address(RVA = "0x167D380", Offset = "0x167C580", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600061E")]
	internal int FindNodeOffset(string name) { }

	[Address(RVA = "0x167D480", Offset = "0x167C680", Length = "0x132")]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "SetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "SetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600061F")]
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	[Address(RVA = "0x166D290", Offset = "0x166C490", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x600061C")]
	public override int get_Count() { }

	[Address(RVA = "0x167D5C0", Offset = "0x167C7C0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Token(Token = "0x600061D")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x167D5D0", Offset = "0x167C7D0", Length = "0x175")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600061A")]
	public override XmlNode GetNamedItem(string name) { }

	[Address(RVA = "0x167D750", Offset = "0x167C950", Length = "0x1AC")]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 7)]
	[Token(Token = "0x6000624")]
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	[Address(RVA = "0x167D900", Offset = "0x167CB00", Length = "0x171")]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "SetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000622")]
	internal override XmlNode RemoveNodeAt(int i) { }

	[Address(RVA = "0x167DA80", Offset = "0x167CC80", Length = "0x68")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000623")]
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	[Address(RVA = "0x167DAF0", Offset = "0x167CCF0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600061B")]
	public override XmlNode SetNamedItem(XmlNode node) { }

}

