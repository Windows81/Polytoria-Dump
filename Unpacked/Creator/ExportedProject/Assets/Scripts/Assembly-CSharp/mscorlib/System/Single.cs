namespace System;

[IsReadOnly]
[Token(Token = "0x200012E")]
public struct float : IComparable, IConvertible, IFormattable, IComparable<Single>, IEquatable<Single>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000461")]
	private readonly float m_value; //Field offset: 0x0

	[Address(RVA = "0x14BF6A0", Offset = "0x14BE8A0", Length = "0xE0")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_float", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000998")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x14BF660", Offset = "0x14BE860", Length = "0x40")]
	[CallerCount(Count = 24)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000999")]
	public override int CompareTo(float value) { }

	[Address(RVA = "0x14BF7C0", Offset = "0x14BE9C0", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600099A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x14BF790", Offset = "0x14BE990", Length = "0x2B")]
	[CallerCount(Count = 68)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600099B")]
	public override bool Equals(float obj) { }

	[Address(RVA = "0x14BF840", Offset = "0x14BEA40", Length = "0x17")]
	[CallerCount(Count = 169)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600099C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x14BF860", Offset = "0x14BEA60", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009A8")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x14BF870", Offset = "0x14BEA70", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000994")]
	public static bool IsInfinity(float f) { }

	[Address(RVA = "0x14BF890", Offset = "0x14BEA90", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000995")]
	public static bool IsNaN(float f) { }

	[Address(RVA = "0x14BF8B0", Offset = "0x14BEAB0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000996")]
	public static bool IsNegativeInfinity(float f) { }

	[Address(RVA = "0x14BF8D0", Offset = "0x14BEAD0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[NonVersionable]
	[Token(Token = "0x6000997")]
	public static bool IsPositiveInfinity(float f) { }

	[Address(RVA = "0x14BF8F0", Offset = "0x14BEAF0", Length = "0xDA")]
	[CalledBy(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CalledBy(Type = "System.ComponentModel.SingleConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009A4")]
	public static float Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x14BFA90", Offset = "0x14BEC90", Length = "0xC8")]
	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009A3")]
	public static float Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x14BF9D0", Offset = "0x14BEBD0", Length = "0xB5")]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SetMoveSnapSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "SetRotateSnapSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Token(Token = "0x60009A2")]
	public static float Parse(string s) { }

	[Address(RVA = "0x14BFB60", Offset = "0x14BED60", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60009A9")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x14BFBC0", Offset = "0x14BEDC0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(byte))]
	[Token(Token = "0x60009AC")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x14BFC20", Offset = "0x14BEE20", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60009AA")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x14BFCB0", Offset = "0x14BEEB0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60009B6")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x14BFD40", Offset = "0x14BEF40", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x60009B5")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x14BFDC0", Offset = "0x14BEFC0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(double))]
	[Token(Token = "0x60009B4")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x14BFE20", Offset = "0x14BF020", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(short))]
	[Token(Token = "0x60009AD")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x14BFE80", Offset = "0x14BF080", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
	[Token(Token = "0x60009AF")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14BFEE0", Offset = "0x14BF0E0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(long))]
	[Token(Token = "0x60009B1")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14BFF40", Offset = "0x14BF140", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(sbyte))]
	[Token(Token = "0x60009AB")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x553AC0", Offset = "0x552CC0", Length = "0x5")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009B3")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x14BFFA0", Offset = "0x14BF1A0", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x60009B7")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x14C0030", Offset = "0x14BF230", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x60009AE")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x14C0090", Offset = "0x14BF290", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(uint))]
	[Token(Token = "0x60009B0")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14C00F0", Offset = "0x14BF2F0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x60009B2")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14C02C0", Offset = "0x14BF4C0", Length = "0x84")]
	[CallerCount(Count = 128)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Token(Token = "0x60009A0")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x14C0150", Offset = "0x14BF350", Length = "0x74")]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.Extents", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.Mesh_Extents", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.SpriteAssetUtilities.TexturePacker_JsonArray+SpriteFrame", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "TMPro.SpriteAssetUtilities.TexturePacker_JsonArray+SpriteSize", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.Extents", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "HSVPicker.ColorLabel", Member = "UpdateValue", ReturnType = typeof(void))]
	[CalledBy(Type = "HSVPicker.ColorLabel", Member = "ConvertToDisplayString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Token(Token = "0x600099F")]
	public string ToString(string format) { }

	[Address(RVA = "0x14C01D0", Offset = "0x14BF3D0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.Translate", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterFloatConverters>b__25_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.Angle", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.FilterParameter", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.Length", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.TimeValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.TransformOrigin", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Dimension", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.StyleSheetExtensions", Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheet", "UnityEngine.UIElements.StyleValueHandle"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_21", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600099E")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x14C0250", Offset = "0x14BF450", Length = "0x67")]
	[CallerCount(Count = 69)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[Token(Token = "0x600099D")]
	public virtual string ToString() { }

	[Address(RVA = "0x14C0350", Offset = "0x14BF550", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryFormatSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60009A1")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x14C06E0", Offset = "0x14BF8E0", Length = "0xB8")]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlFloatAttributeDescription+<>c", Member = "<GetValueFromBag>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlFloatAttributeDescription", Member = "ConvertValueToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60009A6")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out float result) { }

	[Address(RVA = "0x14C0410", Offset = "0x14BF610", Length = "0x228")]
	[CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryExtensions), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60009A7")]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out float result) { }

	[Address(RVA = "0x14C0640", Offset = "0x14BF840", Length = "0x9D")]
	[CallerCount(Count = 42)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Single&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60009A5")]
	public static bool TryParse(string s, out float result) { }

}

