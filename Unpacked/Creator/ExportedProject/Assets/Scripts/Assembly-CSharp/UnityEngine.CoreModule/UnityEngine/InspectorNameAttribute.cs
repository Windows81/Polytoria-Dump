namespace UnityEngine;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
[Token(Token = "0x200010D")]
[UsedByNativeCode]
public class InspectorNameAttribute : PropertyAttribute
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004F5")]
	public readonly string displayName; //Field offset: 0x18

	[Address(RVA = "0x1963460", Offset = "0x1962660", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000889")]
	public InspectorNameAttribute(string displayName) { }

}

