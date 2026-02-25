namespace UnityEngine.UIElements;

[Token(Token = "0x200046A")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct StyleVariable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000EAB")]
	public readonly string name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000EAC")]
	public readonly StyleSheet sheet; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000EAD")]
	public readonly StyleValueHandle[] handles; //Field offset: 0x10

	[Address(RVA = "0x89C9E0", Offset = "0x89BBE0", Length = "0x4F")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002100")]
	public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles) { }

	[Address(RVA = "0x1B2F460", Offset = "0x1B2E660", Length = "0x90")]
	[CalledBy(Type = typeof(StyleVariableContext), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleVariable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6002101")]
	public virtual int GetHashCode() { }

}

