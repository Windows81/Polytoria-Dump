namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x2000602")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct SelectorMatchRecord : IEquatable<SelectorMatchRecord>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001676")]
	public StyleSheet sheet; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001677")]
	public int styleSheetIndexInStack; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001678")]
	public StyleComplexSelector complexSelector; //Field offset: 0x10

	[Address(RVA = "0x1BC0600", Offset = "0x1BBF800", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002A6C")]
	public SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack) { }

	[Address(RVA = "0x1BC02F0", Offset = "0x1BBF4F0", Length = "0x14C")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal+<>c", Member = "<ProcessMatchedRules>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SelectorMatchRecord), typeof(SelectorMatchRecord)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StyleSheet), Member = "get_isDefaultStyleSheet", ReturnType = typeof(bool))]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002A6D")]
	public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b) { }

	[Address(RVA = "0x1BC0440", Offset = "0x1BBF640", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002A6E")]
	public override bool Equals(SelectorMatchRecord other) { }

	[Address(RVA = "0x1BC04B0", Offset = "0x1BBF6B0", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A6F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1BC0580", Offset = "0x1BBF780", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Combine", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[Token(Token = "0x6002A70")]
	public virtual int GetHashCode() { }

}

