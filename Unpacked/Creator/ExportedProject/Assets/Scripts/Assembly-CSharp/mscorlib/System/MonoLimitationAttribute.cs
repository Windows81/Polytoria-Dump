namespace System;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = True)]
[Token(Token = "0x2000173")]
internal class MonoLimitationAttribute : MonoTODOAttribute
{

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D14")]
	public MonoLimitationAttribute(string comment) { }

}

