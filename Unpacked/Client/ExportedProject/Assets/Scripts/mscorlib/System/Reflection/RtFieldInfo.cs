namespace System.Reflection;

[Token(Token = "0x200050B")]
internal abstract class RtFieldInfo : FieldInfo
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60023B4")]
	protected RtFieldInfo() { }

	[Token(Token = "0x60023B3")]
	internal abstract void CheckConsistency(object target) { }

	[Token(Token = "0x60023B1")]
	internal abstract object UnsafeGetValue(object obj) { }

	[Token(Token = "0x60023B2")]
	internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

