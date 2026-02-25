namespace UnityEngine.UIElements;

[IsReadOnly]
[Token(Token = "0x200003D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct PropertyPathInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013A")]
	public readonly PropertyPath propertyPath; //Field offset: 0x0
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400013B")]
	public readonly Type type; //Field offset: 0x90

	[Address(RVA = "0x1AB5CF0", Offset = "0x1AB4EF0", Length = "0xA9")]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(IProperty)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitedPropertyScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.Internal.AutoCompletePathVisitor+VisitContext", typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001F2")]
	internal PropertyPathInfo(in PropertyPath propertyPath, Type type) { }

}

