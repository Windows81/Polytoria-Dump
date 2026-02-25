namespace UnityEngine;

[AttributeUsage(AttributeTargets::All (32767), Inherited = True, AllowMultiple = False)]
[Token(Token = "0x200010E")]
public class TooltipAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F6")]
	public readonly string tooltip; //Field offset: 0x18

	[Address(RVA = "0x19719A0", Offset = "0x1970BA0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600088A")]
	public TooltipAttribute(string tooltip) { }

}

