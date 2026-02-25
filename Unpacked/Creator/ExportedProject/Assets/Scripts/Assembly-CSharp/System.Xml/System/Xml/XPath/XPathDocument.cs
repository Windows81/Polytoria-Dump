namespace System.Xml.XPath;

[Token(Token = "0x20000BF")]
public class XPathDocument
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000445")]
	private XPathNode[] pageXmlNmsp; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000446")]
	private int idxXmlNmsp; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000447")]
	private XmlNameTable nameTable; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000448")]
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; //Field offset: 0x28

	[Token(Token = "0x170001D7")]
	internal XmlNameTable NameTable
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600083A")]
		internal get { } //Length: 5
	}

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600083A")]
	internal XmlNameTable get_NameTable() { }

	[Address(RVA = "0x16B5A00", Offset = "0x16B4C00", Length = "0x24")]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetInScopeNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600083B")]
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	[Address(RVA = "0x16B5A30", Offset = "0x16B4C30", Length = "0x106")]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "MoveToFirstNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNamespaceScope)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetLocalNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XPathNodeHelper), Member = "GetInScopeNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<MS.Internal.Xml.Cache.XPathNodeRef, MS.Internal.Xml.Cache.XPathNodeRef>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeRef)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<MS.Internal.Xml.Cache.XPathNodeRef, MS.Internal.Xml.Cache.XPathNodeRef>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeRef)}, ReturnType = typeof(XPathNodeRef))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600083C")]
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

}

