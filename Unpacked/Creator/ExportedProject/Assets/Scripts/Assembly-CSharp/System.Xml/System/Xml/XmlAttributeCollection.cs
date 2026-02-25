namespace System.Xml;

[DefaultMember("ItemOf")]
[Token(Token = "0x200006D")]
public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable
{

	[Token(Token = "0x170000F7")]
	public XmlAttribute ItemOf
	{
		[Address(RVA = "0x166D2A0", Offset = "0x166C4A0", Length = "0xEB")]
		[CalledBy(Type = typeof(XmlDocument), Member = "ImportAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlElement), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60004D4")]
		 get { } //Length: 235
	}

	[Token(Token = "0x170000F8")]
	public XmlAttribute ItemOf
	{
		[Address(RVA = "0x166D390", Offset = "0x166C590", Length = "0x161")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
		[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004D5")]
		 get { } //Length: 353
	}

	[Token(Token = "0x170000FA")]
	private override int System.Collections.ICollection.Count
	{
		[Address(RVA = "0x166D290", Offset = "0x166C490", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DD")]
		private get { } //Length: 11
	}

	[Token(Token = "0x170000F9")]
	private override object System.Collections.ICollection.SyncRoot
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DC")]
		private get { } //Length: 4
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D3")]
	internal XmlAttributeCollection(XmlNode parent) { }

	[Address(RVA = "0x166BFD0", Offset = "0x166B1D0", Length = "0x1E8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004DE")]
	internal virtual XmlNode AddNode(XmlNode node) { }

	[Address(RVA = "0x166C1C0", Offset = "0x166B3C0", Length = "0x243")]
	[CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveColorRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "Polytoria.Types.ColorRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "UnityEngine.Color"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "UnityEngine.Vector2"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveVector3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "UnityEngine.Vector3"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveNumberRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), "Polytoria.Types.NumberRange"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveHandleChild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), "Polytoria.Datamodel.Instance", typeof(XmlElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.GameIO", Member = "SaveBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocument), typeof(XmlElement), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x60004D7")]
	public XmlAttribute Append(XmlAttribute node) { }

	[Address(RVA = "0x166C410", Offset = "0x166B610", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004E1")]
	internal void Detach(XmlAttribute attr) { }

	[Address(RVA = "0x166D2A0", Offset = "0x166C4A0", Length = "0xEB")]
	[CalledBy(Type = typeof(XmlDocument), Member = "ImportAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlElement), Member = "WriteStartElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "RemoveDuplicateNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(XmlNamespaceManager), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004D4")]
	public XmlAttribute get_ItemOf(int i) { }

	[Address(RVA = "0x166D390", Offset = "0x166C590", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004D5")]
	public XmlAttribute get_ItemOf(string name) { }

	[Address(RVA = "0x166C4F0", Offset = "0x166B6F0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "InsertNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60004DF")]
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }

	[Address(RVA = "0x166C590", Offset = "0x166B790", Length = "0x183")]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(XmlDocument), Member = "AddElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60004E2")]
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	[Address(RVA = "0x166C720", Offset = "0x166B920", Length = "0xB1")]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "SetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlElement), Member = "CloneNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlElement), Member = "SetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60004E7")]
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }

	[Address(RVA = "0x166C7E0", Offset = "0x166B9E0", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004E5")]
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	[Address(RVA = "0x166CEE0", Offset = "0x166C0E0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004D8")]
	public XmlAttribute Remove(XmlAttribute node) { }

	[Address(RVA = "0x166C8E0", Offset = "0x166BAE0", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004DA")]
	public void RemoveAll() { }

	[Address(RVA = "0x166C9C0", Offset = "0x166BBC0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004D9")]
	public XmlAttribute RemoveAt(int i) { }

	[Address(RVA = "0x166CA70", Offset = "0x166BC70", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004E4")]
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	[Address(RVA = "0x166CB70", Offset = "0x166BD70", Length = "0x1D0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "GetDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60004E0")]
	internal virtual XmlNode RemoveNodeAt(int i) { }

	[Address(RVA = "0x166CD50", Offset = "0x166BF50", Length = "0x183")]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlName)}, ReturnType = typeof(XmlName))]
	[Calls(Type = typeof(XmlDocument), Member = "RemoveElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60004E3")]
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	[Address(RVA = "0x166CF80", Offset = "0x166C180", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlDocument), Member = "RemoveElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlDocument), Member = "AddElementWithId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlElement)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004E6")]
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	[Address(RVA = "0x166D060", Offset = "0x166C260", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[Calls(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004D6")]
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	[Address(RVA = "0x166D200", Offset = "0x166C400", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004DB")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x166D290", Offset = "0x166C490", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DD")]
	private override int System.Collections.ICollection.get_Count() { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DC")]
	private override object System.Collections.ICollection.get_SyncRoot() { }

}

