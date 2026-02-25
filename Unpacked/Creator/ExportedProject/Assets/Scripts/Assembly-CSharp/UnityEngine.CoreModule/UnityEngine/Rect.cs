namespace UnityEngine;

[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
[NativeHeader("Runtime/Math/Rect.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x2000097")]
public struct Rect : IEquatable<Rect>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[NativeName("x")]
	[Token(Token = "0x40001C5")]
	private float m_XMin; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[NativeName("y")]
	[Token(Token = "0x40001C6")]
	private float m_YMin; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[NativeName("width")]
	[Token(Token = "0x40001C7")]
	private float m_Width; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[NativeName("height")]
	[Token(Token = "0x40001C8")]
	private float m_Height; //Field offset: 0xC

	[Token(Token = "0x17000075")]
	public Vector2 center
	{
		[Address(RVA = "0x193C2B0", Offset = "0x193B4B0", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002D6")]
		 get { } //Length: 46
		[Address(RVA = "0x193C410", Offset = "0x193B610", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002D7")]
		 set { } //Length: 61
	}

	[Token(Token = "0x17000079")]
	public float height
	{
		[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
		[CallerCount(Count = 25)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DE")]
		 get { } //Length: 8
		[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DF")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000077")]
	public Vector2 max
	{
		[Address(RVA = "0x193C2E0", Offset = "0x193B4E0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002DA")]
		 get { } //Length: 30
		[Address(RVA = "0x193C450", Offset = "0x193B650", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002DB")]
		 set { } //Length: 37
	}

	[Token(Token = "0x17000076")]
	public Vector2 min
	{
		[Address(RVA = "0x193C300", Offset = "0x193B500", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002D8")]
		 get { } //Length: 20
		[Address(RVA = "0x193C480", Offset = "0x193B680", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002D9")]
		 set { } //Length: 64
	}

	[Token(Token = "0x17000074")]
	public Vector2 position
	{
		[Address(RVA = "0x193C320", Offset = "0x193B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D4")]
		 get { } //Length: 18
		[Address(RVA = "0x193C4C0", Offset = "0x193B6C0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002D5")]
		 set { } //Length: 27
	}

	[Token(Token = "0x1700007A")]
	public Vector2 size
	{
		[Address(RVA = "0x193C340", Offset = "0x193B540", Length = "0x13")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E0")]
		 get { } //Length: 19
		[Address(RVA = "0x193C4E0", Offset = "0x193B6E0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E1")]
		 set { } //Length: 28
	}

	[Token(Token = "0x17000078")]
	public float width
	{
		[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DC")]
		 get { } //Length: 8
		[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002DD")]
		 set { } //Length: 6
	}

	[Token(Token = "0x17000072")]
	public float x
	{
		[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D0")]
		 get { } //Length: 7
		[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D1")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700007D")]
	public float xMax
	{
		[Address(RVA = "0x193C360", Offset = "0x193B560", Length = "0xC")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E6")]
		 get { } //Length: 12
		[Address(RVA = "0x193C500", Offset = "0x193B700", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E7")]
		 set { } //Length: 10
	}

	[Token(Token = "0x1700007B")]
	public float xMin
	{
		[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
		[CallerCount(Count = 55)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E2")]
		 get { } //Length: 7
		[Address(RVA = "0x193C510", Offset = "0x193B710", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E3")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000073")]
	public float y
	{
		[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D2")]
		 get { } //Length: 8
		[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
		[CallerCount(Count = 13)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002D3")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700007E")]
	public float yMax
	{
		[Address(RVA = "0x193C370", Offset = "0x193B570", Length = "0xD")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E8")]
		 get { } //Length: 13
		[Address(RVA = "0x193C530", Offset = "0x193B730", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E9")]
		 set { } //Length: 11
	}

	[Token(Token = "0x1700007C")]
	public float yMin
	{
		[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002E4")]
		 get { } //Length: 8
		[Address(RVA = "0x193C540", Offset = "0x193B740", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60002E5")]
		 set { } //Length: 27
	}

	[Token(Token = "0x17000071")]
	public static Rect zero
	{
		[Address(RVA = "0x40E930", Offset = "0x40DB30", Length = "0xD")]
		[CallerCount(Count = 44)]
		[DeduplicatedMethod]
		[Token(Token = "0x60002CE")]
		 get { } //Length: 13
	}

	[Address(RVA = "0x1825900", Offset = "0x1824B00", Length = "0x1A")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CB")]
	public Rect(float x, float y, float width, float height) { }

	[Address(RVA = "0x193C270", Offset = "0x193B470", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002CC")]
	public Rect(Vector2 position, Vector2 size) { }

	[Address(RVA = "0x18A2D30", Offset = "0x18A1F30", Length = "0x17")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CD")]
	public Rect(Rect source) { }

	[Address(RVA = "0x193BAE0", Offset = "0x193ACE0", Length = "0x116")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002EC")]
	public bool Contains(Vector3 point, bool allowInverse) { }

	[Address(RVA = "0x193BC00", Offset = "0x193AE00", Length = "0x39")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002EB")]
	public bool Contains(Vector3 point) { }

	[Address(RVA = "0x3AFA10", Offset = "0x3AEC10", Length = "0x3E")]
	[CalledBy(Type = "UnityEngine.GUI", Member = "DoRepeatButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), "UnityEngine.GUIContent", "UnityEngine.GUIStyle", "UnityEngine.FocusType"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.GUI", Member = "HandleTextFieldEventForDesktop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int), "UnityEngine.GUIContent", typeof(bool), typeof(int), "UnityEngine.GUIStyle", "UnityEngine.TextEditor"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002EA")]
	public bool Contains(Vector2 point) { }

	[Address(RVA = "0x193BD70", Offset = "0x193AF70", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60002F4")]
	public override bool Equals(Rect other) { }

	[Address(RVA = "0x193BC40", Offset = "0x193AE40", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60002F3")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x193C2B0", Offset = "0x193B4B0", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002D6")]
	public Vector2 get_center() { }

	[Address(RVA = "0x2BC170", Offset = "0x2BB370", Length = "0x8")]
	[CallerCount(Count = 25)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DE")]
	public float get_height() { }

	[Address(RVA = "0x193C2E0", Offset = "0x193B4E0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002DA")]
	public Vector2 get_max() { }

	[Address(RVA = "0x193C300", Offset = "0x193B500", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002D8")]
	public Vector2 get_min() { }

	[Address(RVA = "0x193C320", Offset = "0x193B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D4")]
	public Vector2 get_position() { }

	[Address(RVA = "0x193C340", Offset = "0x193B540", Length = "0x13")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E0")]
	public Vector2 get_size() { }

	[Address(RVA = "0x2BC180", Offset = "0x2BB380", Length = "0x8")]
	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DC")]
	public float get_width() { }

	[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D0")]
	public float get_x() { }

	[Address(RVA = "0x193C360", Offset = "0x193B560", Length = "0xC")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E6")]
	public float get_xMax() { }

	[Address(RVA = "0x2BC190", Offset = "0x2BB390", Length = "0x7")]
	[CallerCount(Count = 55)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E2")]
	public float get_xMin() { }

	[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D2")]
	public float get_y() { }

	[Address(RVA = "0x193C370", Offset = "0x193B570", Length = "0xD")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E8")]
	public float get_yMax() { }

	[Address(RVA = "0x2BC1A0", Offset = "0x2BB3A0", Length = "0x8")]
	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002E4")]
	public float get_yMin() { }

	[Address(RVA = "0x40E930", Offset = "0x40DB30", Length = "0xD")]
	[CallerCount(Count = 44)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002CE")]
	public static Rect get_zero() { }

	[Address(RVA = "0x193BE20", Offset = "0x193B020", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x60002F2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x193BEC0", Offset = "0x193B0C0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002CF")]
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	[Address(RVA = "0x193C380", Offset = "0x193B580", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002F1")]
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	[Address(RVA = "0x193C3C0", Offset = "0x193B5C0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002F0")]
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	[Address(RVA = "0x193BF00", Offset = "0x193B100", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002ED")]
	private static Rect OrderMinMax(Rect rect) { }

	[Address(RVA = "0x3E5760", Offset = "0x3E4960", Length = "0x160")]
	[CalledBy(Type = "RLD.MultiSelectShape", Member = "GetOverlappedObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<GameObject>", typeof(Camera), "RLD.ObjectBounds+QueryConfig", "RLD.MultiSelectOverlapMode", "System.Collections.Generic.List`1<GameObject>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.MultiSelectShape", Member = "OverlapsObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), "RLD.ObjectBounds+QueryConfig", "RLD.MultiSelectOverlapMode"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.RTObjectSelection+<>c__DisplayClass144_0", Member = "<PerformMultiSelect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "Cull", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "UpdateCulling", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002EF")]
	public bool Overlaps(Rect other, bool allowInverse) { }

	[Address(RVA = "0x193BF70", Offset = "0x193B170", Length = "0x43")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60002EE")]
	public bool Overlaps(Rect other) { }

	[Address(RVA = "0x193C410", Offset = "0x193B610", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002D7")]
	public void set_center(Vector2 value) { }

	[Address(RVA = "0x1889050", Offset = "0x1888250", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DF")]
	public void set_height(float value) { }

	[Address(RVA = "0x193C450", Offset = "0x193B650", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002DB")]
	public void set_max(Vector2 value) { }

	[Address(RVA = "0x193C480", Offset = "0x193B680", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002D9")]
	public void set_min(Vector2 value) { }

	[Address(RVA = "0x193C4C0", Offset = "0x193B6C0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002D5")]
	public void set_position(Vector2 value) { }

	[Address(RVA = "0x193C4E0", Offset = "0x193B6E0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E1")]
	public void set_size(Vector2 value) { }

	[Address(RVA = "0x1889040", Offset = "0x1888240", Length = "0x6")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002DD")]
	public void set_width(float value) { }

	[Address(RVA = "0x18732B0", Offset = "0x18724B0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D1")]
	public void set_x(float value) { }

	[Address(RVA = "0x193C500", Offset = "0x193B700", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E7")]
	public void set_xMax(float value) { }

	[Address(RVA = "0x193C510", Offset = "0x193B710", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E3")]
	public void set_xMin(float value) { }

	[Address(RVA = "0x18732C0", Offset = "0x18724C0", Length = "0x6")]
	[CallerCount(Count = 13)]
	[DeduplicatedMethod]
	[Token(Token = "0x60002D3")]
	public void set_y(float value) { }

	[Address(RVA = "0x193C530", Offset = "0x193B730", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E9")]
	public void set_yMax(float value) { }

	[Address(RVA = "0x193C540", Offset = "0x193B740", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60002E5")]
	public void set_yMin(float value) { }

	[Address(RVA = "0x193BFC0", Offset = "0x193B1C0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60002F5")]
	public virtual string ToString() { }

	[Address(RVA = "0x193BFD0", Offset = "0x193B1D0", Length = "0x29B")]
	[CalledBy(Type = "UnityEngine.UIElements.VisualElement", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60002F6")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

