namespace System.Xml.Linq;

[Token(Token = "0x2000016")]
public abstract class XObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000034")]
	internal XContainer parent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000035")]
	internal object annotations; //Field offset: 0x18

	[Token(Token = "0x17000013")]
	public abstract XmlNodeType NodeType
	{
		[Token(Token = "0x6000084")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000083")]
	internal XObject() { }

	[Address(RVA = "0x7D2E50", Offset = "0x7D2050", Length = "0xFD")]
	[CalledBy(Type = typeof(XContainer), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XObject), Member = "NotifyChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XObject), Member = "NotifyChanging", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XObjectChangeEventArgs)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XObject), Member = "SkipNotify", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000086")]
	public T Annotation() { }

	[Address(RVA = "0x16425E0", Offset = "0x16417E0", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000085")]
	private object AnnotationForSealedType(Type type) { }

	[Token(Token = "0x6000084")]
	public abstract XmlNodeType get_NodeType() { }

	[Address(RVA = "0x1642720", Offset = "0x1641920", Length = "0x1D4")]
	[CalledBy(Type = typeof(XDocument), Member = "Save", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XNode), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600008A")]
	internal SaveOptions GetSaveOptionsFromAnnotations() { }

	[Address(RVA = "0x1642900", Offset = "0x1641B00", Length = "0xA7")]
	[CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AppendNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "AppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XText), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000087")]
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	[Address(RVA = "0x16429B0", Offset = "0x1641BB0", Length = "0xA7")]
	[CalledBy(Type = typeof(XContainer), Member = "AddString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XContainer), Member = "AppendNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XNode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XElement), Member = "AppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XText), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000088")]
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	[Address(RVA = "0x1642A60", Offset = "0x1641C60", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(XObject), Member = "Annotation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x6000089")]
	internal bool SkipNotify() { }

}

