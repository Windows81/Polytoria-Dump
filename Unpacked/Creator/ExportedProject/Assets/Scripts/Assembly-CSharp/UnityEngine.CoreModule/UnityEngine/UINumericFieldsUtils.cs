namespace UnityEngine;

[Token(Token = "0x2000188")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal static class UINumericFieldsUtils
{
	[Token(Token = "0x40005D5")]
	public static readonly string k_AllowedCharactersForFloat; //Field offset: 0x0
	[Token(Token = "0x40005D6")]
	public static readonly string k_AllowedCharactersForInt; //Field offset: 0x8
	[Token(Token = "0x40005D7")]
	public static readonly string k_DoubleFieldFormatString; //Field offset: 0x10
	[Token(Token = "0x40005D8")]
	public static readonly string k_FloatFieldFormatString; //Field offset: 0x18
	[Token(Token = "0x40005D9")]
	public static readonly string k_IntFieldFormatString; //Field offset: 0x20

	[Address(RVA = "0x1978130", Offset = "0x1977330", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000B0B")]
	private static UINumericFieldsUtils() { }

	[Address(RVA = "0x1977840", Offset = "0x1976A40", Length = "0x18B")]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Double&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Single&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000B02")]
	public static bool TryConvertStringToDouble(string str, out double value, out Expression expr) { }

	[Address(RVA = "0x19779D0", Offset = "0x1976BD0", Length = "0x109")]
	[CalledBy(Type = "UnityEngine.UIElements.DoubleField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B03")]
	public static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value, out Expression expression) { }

	[Address(RVA = "0x1977AE0", Offset = "0x1976CE0", Length = "0x162")]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "ParseStringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mathf), Member = "ClampToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B04")]
	public static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value, out Expression expression) { }

	[Address(RVA = "0x1977C50", Offset = "0x1976E50", Length = "0x9F")]
	[CalledBy(Type = "UnityEngine.UIElements.IntegerField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.SliderInt", Member = "ParseStringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mathf), Member = "ClampToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B09")]
	public static bool TryConvertStringToInt(string str, string initialValueAsString, out int value, out Expression expression) { }

	[Address(RVA = "0x1977E40", Offset = "0x1977040", Length = "0x79")]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B05")]
	public static bool TryConvertStringToLong(string str, out long value, out Expression expr) { }

	[Address(RVA = "0x1977CF0", Offset = "0x1976EF0", Length = "0x14D")]
	[CalledBy(Type = "UnityEngine.UIElements.LongField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt32&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B06")]
	public static bool TryConvertStringToLong(string str, string initialValueAsString, out long value, out Expression expression) { }

	[Address(RVA = "0x1977EC0", Offset = "0x19770C0", Length = "0x9F")]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Int64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mathf), Member = "ClampToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000B0A")]
	public static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value, out Expression expression) { }

	[Address(RVA = "0x1977F60", Offset = "0x1977160", Length = "0x79")]
	[CalledBy(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(UInt64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B07")]
	public static bool TryConvertStringToULong(string str, out ulong value, out Expression expr) { }

	[Address(RVA = "0x1977FE0", Offset = "0x19771E0", Length = "0x14D")]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField", Member = "StringToValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UINumericFieldsUtils), Member = "TryConvertStringToULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt64&), typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ExpressionEvaluator), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&", typeof(Expression&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Expression), Member = "Evaluate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B08")]
	public static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value, out Expression expression) { }

}

