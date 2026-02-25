namespace System.ComponentModel;

[Token(Token = "0x2000177")]
public class SingleConverter : BaseNumberConverter
{

	[Token(Token = "0x170001B6")]
	internal virtual bool AllowHex
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000914")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x170001B7")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x17A9530", Offset = "0x17A8730", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x6000915")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0x80BFB0", Offset = "0x80B1B0", Length = "0x7")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000919")]
	public SingleConverter() { }

	[Address(RVA = "0x17A9400", Offset = "0x17A8600", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x6000916")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x17A93D0", Offset = "0x17A85D0", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x6000917")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000914")]
	internal virtual bool get_AllowHex() { }

	[Address(RVA = "0x17A9530", Offset = "0x17A8730", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x6000915")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x17A94A0", Offset = "0x17A86A0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000918")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

