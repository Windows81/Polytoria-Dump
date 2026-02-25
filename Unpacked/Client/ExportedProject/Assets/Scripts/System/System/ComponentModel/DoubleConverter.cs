namespace System.ComponentModel;

[Token(Token = "0x200015F")]
public class DoubleConverter : BaseNumberConverter
{

	[Token(Token = "0x17000192")]
	internal virtual bool AllowHex
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600087A")]
		internal get { } //Length: 3
	}

	[Token(Token = "0x17000193")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x179C840", Offset = "0x179BA40", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x600087B")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0x80BFB0", Offset = "0x80B1B0", Length = "0x7")]
	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600087F")]
	public DoubleConverter() { }

	[Address(RVA = "0x179C6E0", Offset = "0x179B8E0", Length = "0x99")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x600087C")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x179C780", Offset = "0x179B980", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(double), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x600087D")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600087A")]
	internal virtual bool get_AllowHex() { }

	[Address(RVA = "0x179C840", Offset = "0x179BA40", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x600087B")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x179C7B0", Offset = "0x179B9B0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(double), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600087E")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

