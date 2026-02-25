namespace UnityEngine.UIElements;

[Token(Token = "0x20004E8")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class UxmlObjectAsset : UxmlAsset
{
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4001024")]
	private bool m_IsField; //Field offset: 0x48

	[Token(Token = "0x1700097F")]
	public bool isField
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002447")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1B521F0", Offset = "0x1B513F0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002448")]
	public UxmlObjectAsset(string fullTypeNameOrFieldName, bool isField, UxmlNamespaceDefinition xmlNamespace = null) { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002447")]
	public bool get_isField() { }

	[Address(RVA = "0x1B520F0", Offset = "0x1B512F0", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002449")]
	public virtual string ToString() { }

}

