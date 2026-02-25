namespace UnityEngine.Scripting.APIUpdating;

[AttributeUsage(5148)]
[Token(Token = "0x20001E0")]
public class MovedFromAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000681")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal MovedFromAttributeData data; //Field offset: 0x10

	[Address(RVA = "0x1985610", Offset = "0x1984810", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MovedFromAttributeData), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000C8C")]
	public MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null) { }

	[Address(RVA = "0x1985670", Offset = "0x1984870", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000C8D")]
	public MovedFromAttribute(string sourceNamespace) { }

}

