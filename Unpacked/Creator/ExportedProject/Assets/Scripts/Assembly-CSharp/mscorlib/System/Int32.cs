namespace System;

[IsReadOnly]
[Token(Token = "0x2000101")]
public struct int : IComparable, IConvertible, IFormattable, IComparable<Int32>, IEquatable<Int32>, ISpanFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000418")]
	private readonly int m_value; //Field offset: 0x0

	[Address(RVA = "0x149FAA0", Offset = "0x149ECA0", Length = "0xAF")]
	[CalledBy(Type = "System.Xml.Schema.Datatype_int", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60007CE")]
	public override int CompareTo(object value) { }

	[Address(RVA = "0x149FB50", Offset = "0x149ED50", Length = "0x12")]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility+<>c", Member = "<SortPanels>b__58_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel", "UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.InputForUI.EventProvider+<>c", Member = "<Subscribe>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputForUI.EventProvider+Registration", "UnityEngine.InputForUI.EventProvider+Registration"}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NullableComparer`1), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<T>", "System.Nullable`1<T>"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseSlider`1", Member = "Clamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType", "TValueType", "TValueType"}, ReturnType = "TValueType")]
	[CalledBy(Type = "UnityEngine.UIElements.BaseSlider`1", Member = "GetClampedValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValueType"}, ReturnType = "TValueType")]
	[CalledBy(Type = "UnityEngine.UIElements.MultiColumnController", Member = "CombinedComparison", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.BaseReorderableDragAndDropController", Member = "CompareId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.TreeViewReorderableDragAndDropController", Member = "CompareId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SoftMasking.MaterialReplacerChain+<>c", Member = "<Initialize>b__7_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SoftMasking.IMaterialReplacer", "SoftMasking.IMaterialReplacer"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "CompareForOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElementAsset", "UnityEngine.UIElements.VisualElementAsset"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.SelectorMatchRecord", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleSheets.SelectorMatchRecord", "UnityEngine.UIElements.StyleSheets.SelectorMatchRecord"}, ReturnType = typeof(int))]
	[CalledBy(Type = "RLD.Priority", Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"RLD.Priority"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EntityId", Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EntityId"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster+<>c", Member = "<Raycast>b__27_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.Graphic", "UnityEngine.UI.Graphic"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult"}, ReturnType = typeof(int))]
	[CallerCount(Count = 21)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007CF")]
	public override int CompareTo(int value) { }

	[Address(RVA = "0x149FB70", Offset = "0x149ED70", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60007D0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x149FBD0", Offset = "0x149EDD0", Length = "0x6")]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	[Token(Token = "0x60007D1")]
	public override bool Equals(int obj) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007D2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x149FBE0", Offset = "0x149EDE0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007DE")]
	public override TypeCode GetTypeCode() { }

	[Address(RVA = "0x149FCC0", Offset = "0x149EEC0", Length = "0xEA")]
	[CalledBy(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.ComponentModel.Int32Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = "MoonSharp.Interpreter.Tree.LexerUtils", Member = "UnescapeLuaString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Tree.Token", typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[Token(Token = "0x60007DB")]
	public static int Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[Address(RVA = "0x149FDB0", Offset = "0x149EFB0", Length = "0xD8")]
	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Tree.LexerUtils", Member = "ParseHexFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Tree.Token"}, ReturnType = typeof(double))]
	[CalledBy(Type = "MoonSharp.Interpreter.Tree.LexerUtils", Member = "UnescapeLuaString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Tree.Token", typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[Token(Token = "0x60007DA")]
	public static int Parse(string s, IFormatProvider provider) { }

	[Address(RVA = "0x149FE90", Offset = "0x149F090", Length = "0xDA")]
	[CalledBy(Type = "System.Net.MonoChunkParser", Member = "GetChunkSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(Int32&), typeof(int)}, ReturnType = "System.Net.MonoChunkParser+State")]
	[CalledBy(Type = "Mirror.BouncyCastle.Math.BigInteger", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleJSON.JSONNode", Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "SimpleJSON.JSONNode")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[Token(Token = "0x60007D9")]
	public static int Parse(string s, NumberStyles style) { }

	[Address(RVA = "0x149FBF0", Offset = "0x149EDF0", Length = "0xC9")]
	[CalledBy(Type = "UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxTokenizer", Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.DerObjectIdentifier", Member = "ParseIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Unity.Properties.TypeUtility", Member = "GetTypeDisplayName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "System.Collections.Generic.IReadOnlyList`1<Type>", typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[Token(Token = "0x60007D8")]
	public static int Parse(string s) { }

	[Address(RVA = "0x149FF70", Offset = "0x149F170", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007DF")]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[Address(RVA = "0x149FFC0", Offset = "0x149F1C0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Token(Token = "0x60007E2")]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[Address(RVA = "0x14A0010", Offset = "0x149F210", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Token(Token = "0x60007E0")]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[Address(RVA = "0x14A0060", Offset = "0x149F260", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007EC")]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[Address(RVA = "0x14A00F0", Offset = "0x149F2F0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
	[Token(Token = "0x60007EB")]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[Address(RVA = "0x14A0160", Offset = "0x149F360", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(double))]
	[Token(Token = "0x60007EA")]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[Address(RVA = "0x14A01B0", Offset = "0x149F3B0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
	[Token(Token = "0x60007E3")]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
	[CallerCount(Count = 129)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007E5")]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14A0200", Offset = "0x149F400", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007E7")]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14A0250", Offset = "0x149F450", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(sbyte))]
	[Token(Token = "0x60007E1")]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[Address(RVA = "0x14A02A0", Offset = "0x149F4A0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Token(Token = "0x60007E9")]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[Address(RVA = "0x14A02F0", Offset = "0x149F4F0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	[Token(Token = "0x60007ED")]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[Address(RVA = "0x14A0380", Offset = "0x149F580", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
	[Token(Token = "0x60007E4")]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[Address(RVA = "0x14A03D0", Offset = "0x149F5D0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(uint))]
	[Token(Token = "0x60007E6")]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[Address(RVA = "0x14A0420", Offset = "0x149F620", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ulong))]
	[Token(Token = "0x60007E8")]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[Address(RVA = "0x14A0640", Offset = "0x149F840", Length = "0xC6")]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x60007D6")]
	public override string ToString(string format, IFormatProvider provider) { }

	[Address(RVA = "0x14A04F0", Offset = "0x149F6F0", Length = "0x8A")]
	[CallerCount(Count = 45)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D5")]
	public override string ToString(IFormatProvider provider) { }

	[Address(RVA = "0x14A0580", Offset = "0x149F780", Length = "0xB9")]
	[CalledBy(Type = typeof(RemotingServices), Member = "NewUri", ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ValueToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "UpdateInstanceCount", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.AsnEncodedData", Member = "NetscapeCertType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Net.DigestSession", Member = "Response", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), "System.Net.HttpWebRequest"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1StreamParser", Member = "ParseImplicitConstructedDL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Mirror.BouncyCastle.Asn1.IAsn1Convertible")]
	[CalledBy(Type = "Mirror.BouncyCastle.Asn1.Asn1StreamParser", Member = "ParseImplicitConstructedIL", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "Mirror.BouncyCastle.Asn1.IAsn1Convertible")]
	[CalledBy(Type = "System.Net.Http.Headers.WarningHeaderValue", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Token(Token = "0x60007D4")]
	public string ToString(string format) { }

	[Address(RVA = "0x14A0470", Offset = "0x149F670", Length = "0x7E")]
	[CallerCount(Count = 301)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007D3")]
	public virtual string ToString() { }

	[Address(RVA = "0x14A0710", Offset = "0x149F910", Length = "0xA0")]
	[CalledBy(Type = typeof(Version), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IPv6AddressHelper", Member = "ParseCanonicalName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Boolean&), typeof(String&)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Numerics.BigNumber", Member = "FormatBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Numerics.BigInteger", typeof(string), "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo), "System.Span`1<Char>", typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60007D7")]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[Address(RVA = "0x14A08A0", Offset = "0x149FAA0", Length = "0x169")]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Number), Member = "TryParseInt32IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60007DC")]
	public static bool TryParse(string s, out int result) { }

	[Address(RVA = "0x14A07B0", Offset = "0x149F9B0", Length = "0xF0")]
	[CalledBy(Type = "System.Net.Http.Headers.Parser+TimeSpanSeconds", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TimeSpan&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TimeZoneInfo), Member = "TryGetLocalizedNameByMuiNativeResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.ExpressionEvaluator", Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Net.Http.Headers.Lexer", Member = "TryGetNumericValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.Headers.Token", typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Http.Headers.Lexer", Member = "TryGetTimeSpanValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.Headers.Token"}, ReturnType = "System.Nullable`1<TimeSpan>")]
	[CalledBy(Type = "System.Net.Http.Headers.Parser+Int", Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.Http.Headers.WarningHeaderValue", Member = "TryParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.Headers.Lexer", "System.Net.Http.Headers.WarningHeaderValue&", "System.Net.Http.Headers.Token&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007DD")]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out int result) { }

}

