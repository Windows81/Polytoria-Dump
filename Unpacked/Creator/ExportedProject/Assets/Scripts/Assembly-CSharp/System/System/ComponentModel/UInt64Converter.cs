namespace System.ComponentModel;

[Token(Token = "0x2000180")]
public class UInt64Converter : BaseNumberConverter
{

	[Token(Token = "0x170001BC")]
	internal virtual Type TargetType
	{
		[Address(RVA = "0x17B0020", Offset = "0x17AF220", Length = "0x32")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x600093E")]
		internal get { } //Length: 50
	}

	[Address(RVA = "0x17AFF20", Offset = "0x17AF120", Length = "0x6F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x600093F")]
	internal virtual object FromString(string value, int radix) { }

	[Address(RVA = "0x17AFEF0", Offset = "0x17AF0F0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ulong), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x6000940")]
	internal virtual object FromString(string value, NumberFormatInfo formatInfo) { }

	[Address(RVA = "0x17B0020", Offset = "0x17AF220", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x600093E")]
	internal virtual Type get_TargetType() { }

	[Address(RVA = "0x17AFF90", Offset = "0x17AF190", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000941")]
	internal virtual string ToString(object value, NumberFormatInfo formatInfo) { }

}

