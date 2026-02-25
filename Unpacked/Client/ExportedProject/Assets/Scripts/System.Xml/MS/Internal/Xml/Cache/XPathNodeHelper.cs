namespace MS.Internal.Xml.Cache;

[Token(Token = "0x200017E")]
internal abstract class XPathNodeHelper
{

	[Address(RVA = "0x16E4C80", Offset = "0x16E3E80", Length = "0x13A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XPathDocument), Member = "GetXmlNamespaceNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XPathDocument), Member = "LookupNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D3B")]
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	[Address(RVA = "0x16E4DC0", Offset = "0x16E3FC0", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(XPathDocument), Member = "LookupNamespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNode[]), typeof(int), typeof(XPathNode[]&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D3A")]
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	[Address(RVA = "0x16E4E50", Offset = "0x16E4050", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D3D")]
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	[Address(RVA = "0x16E4E90", Offset = "0x16E4090", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D3F")]
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }

	[Address(RVA = "0x16E4F90", Offset = "0x16E4190", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D3C")]
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	[Address(RVA = "0x16E5030", Offset = "0x16E4230", Length = "0x1F2")]
	[CalledBy(Type = typeof(XPathDocumentNavigator), Member = "get_Value", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(XPathNavigator), Member = "IsText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D3E")]
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

}

