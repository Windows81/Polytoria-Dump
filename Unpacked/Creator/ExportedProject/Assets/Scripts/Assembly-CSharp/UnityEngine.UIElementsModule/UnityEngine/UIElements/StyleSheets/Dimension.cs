namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005FA")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct Dimension : IEquatable<Dimension>
{
	[Token(Token = "0x20005FB")]
	internal enum Unit
	{
		Unitless = 0,
		Pixel = 1,
		Percent = 2,
		Second = 3,
		Millisecond = 4,
		Degree = 5,
		Gradian = 6,
		Radian = 7,
		Turn = 8,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001652")]
	public Unit unit; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001653")]
	public float value; //Field offset: 0x4

	[Address(RVA = "0x1BBE2E0", Offset = "0x1BBD4E0", Length = "0x9")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Dimension))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Dimension&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleSheet), Member = "WriteLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(Length)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "WriteAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(Angle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheet), Member = "WriteTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle&), typeof(TimeValue)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StyleSheetUtility), Member = "ToDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Length)}, ReturnType = typeof(Dimension))]
	[CalledBy(Type = typeof(StyleSheetUtility), Member = "ToDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Angle)}, ReturnType = typeof(Dimension))]
	[CalledBy(Type = typeof(StyleSheetUtility), Member = "ToDimension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeValue)}, ReturnType = typeof(Dimension))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6002A1F")]
	public Dimension(float value, Unit unit) { }

	[Address(RVA = "0x1BBDF80", Offset = "0x1BBD180", Length = "0x25")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A24")]
	public override bool Equals(Dimension other) { }

	[Address(RVA = "0x1BBDEC0", Offset = "0x1BBD0C0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A25")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1BBDFB0", Offset = "0x1BBD1B0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002A26")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1BBDFF0", Offset = "0x1BBD1F0", Length = "0x19")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Angle))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Angle&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A2A")]
	public bool IsAngle() { }

	[Address(RVA = "0x1BBE010", Offset = "0x1BBD210", Length = "0x11")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Length&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A28")]
	public bool IsLength() { }

	[Address(RVA = "0x1BBE030", Offset = "0x1BBD230", Length = "0x14")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(TimeValue))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(TimeValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A29")]
	public bool IsTimeValue() { }

	[Address(RVA = "0x1BBE2F0", Offset = "0x1BBD4F0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A23")]
	public static bool op_Equality(Dimension lhs, Dimension rhs) { }

	[Address(RVA = "0x1BBE050", Offset = "0x1BBD250", Length = "0x8A")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Angle))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Angle&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002A22")]
	public Angle ToAngle() { }

	[Address(RVA = "0x1BBE0E0", Offset = "0x1BBD2E0", Length = "0x2F")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(Length))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(Length&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(BackgroundPosition&), typeof(BackgroundPosition&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A20")]
	public Length ToLength() { }

	[Address(RVA = "0x1BBE110", Offset = "0x1BBD310", Length = "0x170")]
	[CalledBy(Type = typeof(StyleSheetExtensions), Member = "ReadAsString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleSheet), typeof(StyleValueHandle)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6002A27")]
	public virtual string ToString() { }

	[Address(RVA = "0x1BBE2B0", Offset = "0x1BBD4B0", Length = "0x2F")]
	[CalledBy(Type = typeof(StyleSheet), Member = "ReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle)}, ReturnType = typeof(TimeValue))]
	[CalledBy(Type = typeof(StyleSheet), Member = "TryReadTimeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleValueHandle), typeof(TimeValue&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002A21")]
	public TimeValue ToTime() { }

}

