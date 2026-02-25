namespace System;

[IsReadOnly]
[Token(Token = "0x20000D1")]
public struct double : IComparable, IConvertible, IFormattable, IComparable<Double>, IEquatable<Double>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400031E")]
	private readonly double m_value; //Field offset: 0x0

	[Address(RVA = "0x1498D10", Offset = "0x1497F10", Length = "0xF7")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_double", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067A")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x1498E10", Offset = "0x1498010", Length = "0x53")]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.TableModule", Member = "SortComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.DynValue", "MoonSharp.Interpreter.DynValue", "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067B")]
	public override int CompareTo(double value) { }

	[Address(RVA = "0x1498E70", Offset = "0x1498070", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1498F00", Offset = "0x1498100", Length = "0x3C")]
	[CalledBy(Type = "HSVPicker.HSVUtil", Member = "ConvertRgbToHsv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = "HSVPicker.HsvColor")]
	[CalledBy(Type = "HSVPicker.HSVUtil", Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = "UnityEngine.Color")]
	[CallerCount(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600067D")]
	public override bool Equals(double obj) { }

	[Address(RVA = "0x1498F40", Offset = "0x1498140", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600067E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1498F70", Offset = "0x1498170", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600068A")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x1498F80", Offset = "0x1498180", Length = "0x23")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000674")]
	public static bool IsFinite(double d) { }

	[Address(RVA = "0x1498FB0", Offset = "0x14981B0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000675")]
	public static bool IsInfinity(double d) { }

	[Address(RVA = "0x1498FE0", Offset = "0x14981E0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000676")]
	public static bool IsNaN(double d) { }

	[Address(RVA = "0x1499030", Offset = "0x1498230", Length = "0xE")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000677")]
	public static bool IsNegative(double d) { }

	[Address(RVA = "0x1499010", Offset = "0x1498210", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000678")]
	public static bool IsNegativeInfinity(double d) { }

	[Address(RVA = "0x1499040", Offset = "0x1498240", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000679")]
	public static bool IsPositiveInfinity(double d) { }

	[Address(RVA = "0x1499060", Offset = "0x1498260", Length = "0xD8")]
	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(double))]
	[Token(Token = "0x6000685")]
	public static double Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x1499230", Offset = "0x1498430", Length = "0xC9")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(double))]
	[Token(Token = "0x6000684")]
	public static double Parse(string s) { }

	[Address(RVA = "0x1499140", Offset = "0x1498340", Length = "0xEA")]
	[CalledBy(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CalledBy(Type = "System.ComponentModel.DoubleConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(double))]
	[Token(Token = "0x6000686")]
	public static double Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x1499300", Offset = "0x1498500", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600068B")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x1499360", Offset = "0x1498560", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(byte))]
	[Token(Token = "0x600068E")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x14993C0", Offset = "0x14985C0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600068C")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x1499450", Offset = "0x1498650", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000698")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x14994E0", Offset = "0x14986E0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x6000697")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0xCE36A0", Offset = "0xCE28A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000696")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x1499560", Offset = "0x1498760", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(short))]
	[Token(Token = "0x600068F")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x14995C0", Offset = "0x14987C0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000691")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1499620", Offset = "0x1498820", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(long))]
	[Token(Token = "0x6000693")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x1499680", Offset = "0x1498880", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(sbyte))]
	[Token(Token = "0x600068D")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x14996E0", Offset = "0x14988E0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000695")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x1499740", Offset = "0x1498940", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000699")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x14997D0", Offset = "0x14989D0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000690")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x1499830", Offset = "0x1498A30", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(uint))]
	[Token(Token = "0x6000692")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x1499890", Offset = "0x1498A90", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x6000694")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14999F0", Offset = "0x1498BF0", Length = "0x67")]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups", Member = "TryConvert", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TDestination"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TSource&", "TDestination&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.TextInputBaseField`1+TextInputBase", Member = "GetDefaultValueType", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CalledBy(Type = "SimpleJSON.JSONNode", Member = "set_AsDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleJSON.JSONNumber", Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.IntegerTime.DiscreteTime", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Token(Token = "0x600067F")]
	public virtual string ToString() { }

	[Address(RVA = "0x1499970", Offset = "0x1498B70", Length = "0x74")]
	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CalledBy(Type = "HSVPicker.HsvColor", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000680")]
	public string ToString(string format) { }

	[Address(RVA = "0x14998F0", Offset = "0x1498AF0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "EvaluateDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.String[]", typeof(Double&), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterDoubleConverters>b__26_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.DynValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.DynValue", Member = "CastToString", ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.DynValue", Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.DataType", typeof(int), "MoonSharp.Interpreter.TypeValidationFlags"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.Converters.ScriptToClrConversions", Member = "DynValueToObjectOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue", typeof(Type), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.BasicModule", Member = "tonumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "UnityEngine.RefreshRate", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_23", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.Headers.CacheControlHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.Headers.RetryConditionHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000681")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x1499A60", Offset = "0x1498C60", Length = "0x84")]
	[CalledBy(Type = "UnityEngine.UIElements.DoubleField", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DoubleConverter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "MoonSharp.Interpreter.Serialization.SerializationExtensions", Member = "SerializeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.DynValue", typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.IntegerTime.DiscreteTime", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.Http.Headers.StringWithQualityHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000682")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x1499AF0", Offset = "0x1498CF0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryFormatDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000683")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x1499D10", Offset = "0x1498F10", Length = "0x237")]
	[CalledBy(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryExtensions), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000689")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out double result) { }

	[Address(RVA = "0x1499BB0", Offset = "0x1498DB0", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlDoubleAttributeDescription+<>c", Member = "<GetValueFromBag>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlDoubleAttributeDescription", Member = "ConvertValueToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(double)}, ReturnType = typeof(double))]
	[CalledBy(Type = "MoonSharp.Interpreter.DynValue", Member = "CastToNumber", ReturnType = "System.Nullable`1<Double>")]
	[CalledBy(Type = "MoonSharp.Interpreter.DynValue", Member = "CheckType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.DataType", typeof(int), "MoonSharp.Interpreter.TypeValidationFlags"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "MoonSharp.Interpreter.Tree.LexerUtils", Member = "ParseNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Tree.Token"}, ReturnType = typeof(double))]
	[CalledBy(Type = "MoonSharp.Interpreter.Tree.Token", Member = "GetNumberValue", ReturnType = typeof(double))]
	[CalledBy(Type = "MoonSharp.Interpreter.CoreLib.BasicModule", Member = "tonumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.ScriptExecutionContext", "MoonSharp.Interpreter.CallbackArguments"}, ReturnType = "MoonSharp.Interpreter.DynValue")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Double&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.Http.Headers.Lexer", Member = "TryGetDoubleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.Headers.Token", typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Http.Headers.StringWithQualityHeaderValue", Member = "TryParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.Headers.Lexer", "System.Net.Http.Headers.StringWithQualityHeaderValue&", "System.Net.Http.Headers.Token&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000688")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out double result) { }

	[Address(RVA = "0x1499C70", Offset = "0x1498E70", Length = "0x9E")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Double&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000687")]
	public static bool TryParse(string s, out double result) { }

}

