namespace UnityEngine.Serialization;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = True, Inherited = False)]
[RequiredByNativeCode]
[Token(Token = "0x20001D1")]
public class FormerlySerializedAsAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000669")]
	private string m_oldName; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C79")]
	public FormerlySerializedAsAttribute(string oldName) { }

}

