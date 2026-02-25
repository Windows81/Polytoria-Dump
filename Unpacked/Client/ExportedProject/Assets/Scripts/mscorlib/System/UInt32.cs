namespace System;

[CLSCompliant(False)]
[IsReadOnly]
[Token(Token = "0x200014A")]
public struct uint : IComparable, IConvertible, IFormattable, IComparable<UInt32>, IEquatable<UInt32>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400049F")]
	private readonly uint m_value; //Field offset: 0x0

	[Address(RVA = "0x14CB990", Offset = "0x14CAB90", Length = "0xAF")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedInt", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000B2A")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x14CBA40", Offset = "0x14CAC40", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B2B")]
	public override int CompareTo(uint value) { }

	[Address(RVA = "0x14CBA60", Offset = "0x14CAC60", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000B2C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x149FBD0", Offset = "0x149EDD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x6000B2D")]
	public override bool Equals(uint obj) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x14CBAC0", Offset = "0x14CACC0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B39")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x14CBAD0", Offset = "0x14CACD0", Length = "0xB5")]
	[CalledBy(Type = "System.Net.WebConnectionTunnel+<ReadHeaders>d__43", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "GetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.BufferOffsetSize", typeof(Int32&), "System.Net.ReadState&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Edgegap.RelayCredentialsFromArgs", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B34")]
	public static uint Parse(string s) { }

	[Address(RVA = "0x14CBB90", Offset = "0x14CAD90", Length = "0xC8")]
	[CalledBy(Type = typeof(Uri), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B35")]
	public static uint Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x14CBC60", Offset = "0x14CAE60", Length = "0xDA")]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "System.ComponentModel.UInt32Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B36")]
	public static uint Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x14CBD40", Offset = "0x14CAF40", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B3A")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x14CBD90", Offset = "0x14CAF90", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(byte))]
	[Token(Token = "0x6000B3D")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x14CBDE0", Offset = "0x14CAFE0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(char))]
	[Token(Token = "0x6000B3B")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x14CBE30", Offset = "0x14CB030", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000B47")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x14CBEC0", Offset = "0x14CB0C0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x6000B46")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x14CBF30", Offset = "0x14CB130", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(double))]
	[Token(Token = "0x6000B45")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x14CBF80", Offset = "0x14CB180", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(short))]
	[Token(Token = "0x6000B3E")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x14CBFD0", Offset = "0x14CB1D0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B40")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14CC020", Offset = "0x14CB220", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B42")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14CC070", Offset = "0x14CB270", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(sbyte))]
	[Token(Token = "0x6000B3C")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x14CC0C0", Offset = "0x14CB2C0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000B44")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x14CC110", Offset = "0x14CB310", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x6000B48")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x14CC1A0", Offset = "0x14CB3A0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x6000B3F")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B41")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14CC1F0", Offset = "0x14CB3F0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B43")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14CC240", Offset = "0x14CB440", Length = "0xC6")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), "System.Xml.ExceptionType"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Unity.Mathematics.uint3", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Mathematics.uint2", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Mathematics.math", Member = "hash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Mathematics.float4x4"}, ReturnType = typeof(uint))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "CreateInvalidHighSurrogateCharException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), "System.Xml.ExceptionType", typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), "System.Xml.ExceptionType", typeof(int), typeof(int)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Unity.Mathematics.uint4", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), "System.Xml.ExceptionType"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlUtf8RawTextWriter", Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlEncodedRawTextWriter", Member = "ValidateContentChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.UInt32Converter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "CreateInvalidSurrogatePairException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000B32")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x14CC3A0", Offset = "0x14CB5A0", Length = "0xB9")]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000B31")]
	public string ToString(string format) { }

	[Address(RVA = "0x14CC460", Offset = "0x14CB660", Length = "0x7E")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderTreeManager", Member = "DrawStats", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.LoadCachedObjectInstruction", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadGltfBinaryBuffer>d__114", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_17", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "OnGUIRelay", ReturnType = typeof(void))]
	[CallerCount(Count = 39)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B2F")]
	public virtual string ToString() { }

	[Address(RVA = "0x14CC310", Offset = "0x14CB510", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B30")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x14CC4E0", Offset = "0x14CB6E0", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000B33")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x14CC580", Offset = "0x14CB780", Length = "0xF0")]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B38")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out uint result) { }

	[Address(RVA = "0x14CC670", Offset = "0x14CB870", Length = "0xD5")]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterUInt32Converters>b__23_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField", Member = "CanTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlUnsignedIntAttributeDescription+<>c", Member = "<GetValueFromBag>b__3_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.UIElements.UxmlUnsignedIntAttributeDescription", Member = "ConvertValueToUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[CLSCompliant(False)]
	[Token(Token = "0x6000B37")]
	public static bool TryParse(string s, out uint result) { }

}

