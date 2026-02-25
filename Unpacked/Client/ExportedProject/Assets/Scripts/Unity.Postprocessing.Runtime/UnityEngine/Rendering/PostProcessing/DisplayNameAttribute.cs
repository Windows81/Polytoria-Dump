namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
[Token(Token = "0x2000004")]
public sealed class DisplayNameAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000006")]
	public readonly string displayName; //Field offset: 0x10

	[Address(RVA = "0x300C90", Offset = "0x2FFE90", Length = "0x31")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public DisplayNameAttribute(string displayName) { }

}

