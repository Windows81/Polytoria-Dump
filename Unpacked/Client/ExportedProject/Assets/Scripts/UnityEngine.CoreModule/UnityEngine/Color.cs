namespace UnityEngine;

[DefaultMember("Item")]
[NativeClass("ColorRGBAf")]
[NativeHeader("Runtime/Math/Color.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x20000F3")]
public struct Color : IEquatable<Color>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000481")]
	public float r; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000482")]
	public float g; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000483")]
	public float b; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000484")]
	public float a; //Field offset: 0xC

	[Token(Token = "0x17000131")]
	public static Color black
	{
		[Address(RVA = "0x40E070", Offset = "0x40D270", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006F1")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000132")]
	public static Color blue
	{
		[Address(RVA = "0x1943510", Offset = "0x1942710", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006F2")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000133")]
	public static Color clear
	{
		[Address(RVA = "0x40E930", Offset = "0x40DB30", Length = "0xD")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006F3")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000134")]
	public static Color cyan
	{
		[Address(RVA = "0x1943530", Offset = "0x1942730", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006F4")]
		 get { } //Length: 31
	}

	[Token(Token = "0x1700012F")]
	public Color gamma
	{
		[Address(RVA = "0x1943550", Offset = "0x1942750", Length = "0xEA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60006EB")]
		 get { } //Length: 234
	}

	[Token(Token = "0x17000135")]
	public static Color gray
	{
		[Address(RVA = "0x1943660", Offset = "0x1942860", Length = "0xF")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006F5")]
		 get { } //Length: 15
	}

	[Token(Token = "0x17000137")]
	public static Color gray5
	{
		[Address(RVA = "0x1943640", Offset = "0x1942840", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006F7")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000138")]
	public static Color green
	{
		[Address(RVA = "0x1943670", Offset = "0x1942870", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006F8")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000136")]
	public static Color grey
	{
		[Address(RVA = "0x1943660", Offset = "0x1942860", Length = "0xF")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006F6")]
		 get { } //Length: 15
	}

	[Token(Token = "0x1700012E")]
	public Color linear
	{
		[Address(RVA = "0x1943690", Offset = "0x1942890", Length = "0xEA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60006EA")]
		 get { } //Length: 234
	}

	[Token(Token = "0x17000139")]
	public static Color magenta
	{
		[Address(RVA = "0x1943780", Offset = "0x1942980", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006F9")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000130")]
	public float maxColorComponent
	{
		[Address(RVA = "0x19437A0", Offset = "0x19429A0", Length = "0x11")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006EC")]
		 get { } //Length: 17
	}

	[Token(Token = "0x1700013A")]
	public static Color red
	{
		[Address(RVA = "0x19437C0", Offset = "0x19429C0", Length = "0x17")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006FA")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700013B")]
	public static Color white
	{
		[Address(RVA = "0x19437E0", Offset = "0x19429E0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006FB")]
		 get { } //Length: 31
	}

	[Token(Token = "0x1700013C")]
	public static Color yellow
	{
		[Address(RVA = "0x1943800", Offset = "0x1942A00", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60006FC")]
		 get { } //Length: 31
	}

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006DA")]
	public Color(float r, float g, float b, float a) { }

	[Address(RVA = "0x19434F0", Offset = "0x19426F0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006DB")]
	public Color(float r, float g, float b) { }

	[Address(RVA = "0x1942C90", Offset = "0x1941E90", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60006DF")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x1942D90", Offset = "0x1941F90", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E0")]
	public override bool Equals(Color other) { }

	[Address(RVA = "0x40E070", Offset = "0x40D270", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F1")]
	public static Color get_black() { }

	[Address(RVA = "0x1943510", Offset = "0x1942710", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006F2")]
	public static Color get_blue() { }

	[Address(RVA = "0x40E930", Offset = "0x40DB30", Length = "0xD")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F3")]
	public static Color get_clear() { }

	[Address(RVA = "0x1943530", Offset = "0x1942730", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006F4")]
	public static Color get_cyan() { }

	[Address(RVA = "0x1943550", Offset = "0x1942750", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60006EB")]
	public Color get_gamma() { }

	[Address(RVA = "0x1943660", Offset = "0x1942860", Length = "0xF")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F5")]
	public static Color get_gray() { }

	[Address(RVA = "0x1943640", Offset = "0x1942840", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006F7")]
	public static Color get_gray5() { }

	[Address(RVA = "0x1943670", Offset = "0x1942870", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006F8")]
	public static Color get_green() { }

	[Address(RVA = "0x1943660", Offset = "0x1942860", Length = "0xF")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006F6")]
	public static Color get_grey() { }

	[Address(RVA = "0x1943690", Offset = "0x1942890", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60006EA")]
	public Color get_linear() { }

	[Address(RVA = "0x1943780", Offset = "0x1942980", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006F9")]
	public static Color get_magenta() { }

	[Address(RVA = "0x19437A0", Offset = "0x19429A0", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006EC")]
	public float get_maxColorComponent() { }

	[Address(RVA = "0x19437C0", Offset = "0x19429C0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006FA")]
	public static Color get_red() { }

	[Address(RVA = "0x19437E0", Offset = "0x19429E0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006FB")]
	public static Color get_white() { }

	[Address(RVA = "0x1943800", Offset = "0x1942A00", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006FC")]
	public static Color get_yellow() { }

	[Address(RVA = "0x698260", Offset = "0x697460", Length = "0x120")]
	[CalledBy(Type = "UnityEngine.UIElements.InheritedData", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.RareData", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.VisualData", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.StyleColor", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.TextCoreSettings", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006DE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1942E40", Offset = "0x1942040", Length = "0x28C")]
	[CalledBy(Type = "Polytoria.Controllers.UIController", Member = "SetHealthFilled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Color), Member = "HSVToRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(Color))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006F0")]
	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }

	[Address(RVA = "0x1942E10", Offset = "0x1942010", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "HSVToRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(Color))]
	[Token(Token = "0x60006EF")]
	public static Color HSVToRGB(float H, float S, float V) { }

	[Address(RVA = "0x1943170", Offset = "0x1942370", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006E7")]
	public static Color Lerp(Color a, Color b, float t) { }

	[Address(RVA = "0x19430F0", Offset = "0x19422F0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006E8")]
	public static Color LerpUnclamped(Color a, Color b, float t) { }

	[Address(RVA = "0x1943820", Offset = "0x1942A20", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E4")]
	public static Color op_Division(Color a, float b) { }

	[Address(RVA = "0x1943840", Offset = "0x1942A40", Length = "0x68")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006E5")]
	public static bool op_Equality(Color lhs, Color rhs) { }

	[Address(RVA = "0x19438B0", Offset = "0x1942AB0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006EE")]
	public static Color op_Implicit(Vector4 v) { }

	[Address(RVA = "0x19438B0", Offset = "0x1942AB0", Length = "0x16")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006ED")]
	public static Vector4 op_Implicit(Color c) { }

	[Address(RVA = "0x19438D0", Offset = "0x1942AD0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60006E6")]
	public static bool op_Inequality(Color lhs, Color rhs) { }

	[Address(RVA = "0x1943990", Offset = "0x1942B90", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006E2")]
	public static Color op_Multiply(Color a, Color b) { }

	[Address(RVA = "0x1943940", Offset = "0x1942B40", Length = "0x47")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006E3")]
	public static Color op_Multiply(Color a, float b) { }

	[Address(RVA = "0x19439F0", Offset = "0x1942BF0", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006E1")]
	public static Color op_Subtraction(Color a, Color b) { }

	[Address(RVA = "0x1943210", Offset = "0x1942410", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60006E9")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Color RGBMultiplied(float multiplier) { }

	[Address(RVA = "0x1943270", Offset = "0x1942470", Length = "0x279")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006DD")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x1943260", Offset = "0x1942460", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180E29EF0")]
	[Token(Token = "0x60006DC")]
	public virtual string ToString() { }

}

