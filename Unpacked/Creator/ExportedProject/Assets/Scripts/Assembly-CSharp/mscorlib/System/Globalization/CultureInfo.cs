namespace System.Globalization;

[ComVisible(True)]
[Token(Token = "0x200056C")]
public class CultureInfo : ICloneable, IFormatProvider
{
	[Token(Token = "0x200056D")]
	private struct Data
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001738")]
		public int ansi; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4001739")]
		public int ebcdic; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400173A")]
		public int mac; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400173B")]
		public int oem; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400173C")]
		public bool right_to_left; //Field offset: 0x10
		[FieldOffset(Offset = "0x11")]
		[Token(Token = "0x400173D")]
		public byte list_sep; //Field offset: 0x11

	}

	[Token(Token = "0x200056E")]
	private sealed class OnCultureInfoChangedDelegate : MulticastDelegate
	{

		[Address(RVA = "0x38E330", Offset = "0x38D530", Length = "0xB4")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x60027FA")]
		public OnCultureInfoChangedDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027FB")]
		public override void Invoke(string language) { }

	}

	[Token(Token = "0x4001710")]
	private static CultureInfo invariant_culture_info; //Field offset: 0x0
	[Token(Token = "0x4001731")]
	private const string MSG_READONLY = "This instance is read only"; //Field offset: 0x0
	[Token(Token = "0x4001730")]
	internal const int LOCALE_INVARIANT = 127; //Field offset: 0x0
	[Token(Token = "0x400172F")]
	private const int CalendarTypeBits = 8; //Field offset: 0x0
	[Token(Token = "0x400172E")]
	internal const int InvariantCultureId = 127; //Field offset: 0x0
	[Token(Token = "0x4001711")]
	private static object shared_table_lock; //Field offset: 0x8
	[Token(Token = "0x4001712")]
	private static CultureInfo default_current_culture; //Field offset: 0x10
	[Token(Token = "0x4001732")]
	private static CultureInfo s_DefaultThreadCurrentUICulture; //Field offset: 0x18
	[Token(Token = "0x4001733")]
	private static CultureInfo s_DefaultThreadCurrentCulture; //Field offset: 0x20
	[Token(Token = "0x4001734")]
	private static Dictionary<Int32, CultureInfo> shared_by_number; //Field offset: 0x28
	[Token(Token = "0x4001735")]
	private static Dictionary<String, CultureInfo> shared_by_name; //Field offset: 0x30
	[Token(Token = "0x4001736")]
	private static CultureInfo s_UserPreferredCultureInfoInAppX; //Field offset: 0x38
	[Token(Token = "0x4001737")]
	internal static readonly bool IsTaiwanSku; //Field offset: 0x40
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001713")]
	private bool m_isReadOnly; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001714")]
	private int cultureID; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001715")]
	private int parent_lcid; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001716")]
	private int datetime_index; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001717")]
	private int number_index; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001718")]
	private int default_calendar_type; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001719")]
	private bool m_useUserOverride; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400171A")]
	internal NumberFormatInfo numInfo; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400171B")]
	internal DateTimeFormatInfo dateTimeInfo; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400171C")]
	private TextInfo textInfo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400171D")]
	internal string m_name; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400171E")]
	private string englishname; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400171F")]
	private string nativename; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001720")]
	private string iso3lang; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001721")]
	private string iso2lang; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001722")]
	private string win3lang; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001723")]
	private string territory; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001724")]
	private String[] native_calendar_names; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001725")]
	private CompareInfo compareInfo; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001726")]
	private readonly Void* textinfo_data; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001727")]
	private int m_dataItem; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001728")]
	private Calendar calendar; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001729")]
	private CultureInfo parent_culture; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400172A")]
	private bool constructed; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400172B")]
	internal Byte[] cached_serialized_form; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400172C")]
	internal CultureData m_cultureData; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400172D")]
	internal bool m_isInherited; //Field offset: 0xC8

	[Token(Token = "0x170005E9")]
	internal CultureData _cultureData
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027BC")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170005EA")]
	internal bool _isInherited
	{
		[Address(RVA = "0x142D2A0", Offset = "0x142C4A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60027BD")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170005EF")]
	internal string _name
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027C4")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005F2")]
	public override Calendar Calendar
	{
		[Address(RVA = "0x142C7A0", Offset = "0x142B9A0", Length = "0x98")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "CreateCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Calendar))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60027C7")]
		 get { } //Length: 152
	}

	[Token(Token = "0x170005FA")]
	internal int CalendarType
	{
		[Address(RVA = "0x142C700", Offset = "0x142B900", Length = "0x98")]
		[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
		[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60027EE")]
		internal get { } //Length: 152
	}

	[Token(Token = "0x170005F5")]
	public override CompareInfo CompareInfo
	{
		[Address(RVA = "0x142C840", Offset = "0x142BA40", Length = "0x13F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CompareInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x60027D0")]
		 get { } //Length: 319
	}

	[Token(Token = "0x170005EC")]
	public static CultureInfo CurrentCulture
	{
		[Address(RVA = "0x142C980", Offset = "0x142BB80", Length = "0x23")]
		[CallerCount(Count = 134)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027BF")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170005ED")]
	public static CultureInfo CurrentUICulture
	{
		[Address(RVA = "0x142C9B0", Offset = "0x142BBB0", Length = "0x23")]
		[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "CheckConsistency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(Thread), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027C0")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170005F8")]
	public override DateTimeFormatInfo DateTimeFormat
	{
		[Address(RVA = "0x142C9E0", Offset = "0x142BBE0", Length = "0x187")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(Calendar)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60027D5")]
		 get { } //Length: 391
		[Address(RVA = "0x142D4A0", Offset = "0x142C6A0", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x60027D6")]
		 set { } //Length: 227
	}

	[Token(Token = "0x170005FB")]
	public static CultureInfo DefaultThreadCurrentCulture
	{
		[Address(RVA = "0x142CB70", Offset = "0x142BD70", Length = "0x5A")]
		[CalledBy(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x60027F1")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170005FC")]
	public static CultureInfo DefaultThreadCurrentUICulture
	{
		[Address(RVA = "0x142CBD0", Offset = "0x142BDD0", Length = "0x5A")]
		[CalledBy(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x60027F2")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170005F9")]
	public override string EnglishName
	{
		[Address(RVA = "0x142CC30", Offset = "0x142BE30", Length = "0x35")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
		[Token(Token = "0x60027D7")]
		 get { } //Length: 53
	}

	[Token(Token = "0x170005EB")]
	public static CultureInfo InvariantCulture
	{
		[Address(RVA = "0x142CC70", Offset = "0x142BE70", Length = "0x59")]
		[CallerCount(Count = 378)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x60027BE")]
		 get { } //Length: 89
	}

	[Token(Token = "0x170005F6")]
	public override bool IsNeutralCulture
	{
		[Address(RVA = "0x142CCD0", Offset = "0x142BED0", Length = "0x3D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60027D1")]
		 get { } //Length: 61
	}

	[Token(Token = "0x170005F0")]
	public override int LCID
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027C5")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170005F1")]
	public override string Name
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027C6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170005F7")]
	public override NumberFormatInfo NumberFormat
	{
		[Address(RVA = "0x142CD10", Offset = "0x142BF10", Length = "0xA5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027D3")]
		 get { } //Length: 165
		[Address(RVA = "0x142D590", Offset = "0x142C790", Length = "0xE3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Token(Token = "0x60027D4")]
		 set { } //Length: 227
	}

	[Token(Token = "0x170005F3")]
	public override CultureInfo Parent
	{
		[Address(RVA = "0x142CDC0", Offset = "0x142BFC0", Length = "0x2CA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[Token(Token = "0x60027C8")]
		 get { } //Length: 714
	}

	[Token(Token = "0x170005FD")]
	internal string SortName
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027F3")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005EE")]
	internal string Territory
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60027C3")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170005F4")]
	public override TextInfo TextInfo
	{
		[Address(RVA = "0x142D090", Offset = "0x142C290", Length = "0x14B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
		[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027C9")]
		 get { } //Length: 331
	}

	[Token(Token = "0x170005FF")]
	internal static CultureInfo UserDefaultCulture
	{
		[Address(RVA = "0x142D1E0", Offset = "0x142C3E0", Length = "0x40")]
		[CalledBy(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
		[Token(Token = "0x60027F5")]
		internal get { } //Length: 64
	}

	[Token(Token = "0x170005FE")]
	internal static CultureInfo UserDefaultUICulture
	{
		[Address(RVA = "0x142D220", Offset = "0x142C420", Length = "0x71")]
		[CalledBy(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
		[Token(Token = "0x60027F4")]
		internal get { } //Length: 113
	}

	[Address(RVA = "0x142BC50", Offset = "0x142AE50", Length = "0x3E3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027F9")]
	private static CultureInfo() { }

	[Address(RVA = "0x142C330", Offset = "0x142B530", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027E6")]
	private CultureInfo() { }

	[Address(RVA = "0x142C040", Offset = "0x142B240", Length = "0x2CA")]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureData))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_Parent", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "OnCultureInfoChangedInAppX", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "CreateNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructLocaleFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027E5")]
	private CultureInfo(string name, bool useUserOverride, bool read_only) { }

	[Address(RVA = "0x142C6A0", Offset = "0x142B8A0", Length = "0x1A")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetJapaneseCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "GetTaiwanCalendarDTFI", ReturnType = typeof(DateTimeFormatInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027E4")]
	public CultureInfo(string name, bool useUserOverride) { }

	[Address(RVA = "0x142C310", Offset = "0x142B510", Length = "0x1D")]
	[CalledBy(Type = typeof(JapaneseCalendar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaiwanCalendar), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "ConvertFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027E3")]
	public CultureInfo(string name) { }

	[Address(RVA = "0x142C370", Offset = "0x142B570", Length = "0x325")]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_Parent", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCultureFromNeutral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027E2")]
	private CultureInfo(int culture, bool useUserOverride, bool read_only) { }

	[Address(RVA = "0x142C350", Offset = "0x142B550", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027E1")]
	public CultureInfo(int culture, bool useUserOverride) { }

	[Address(RVA = "0x142C6C0", Offset = "0x142B8C0", Length = "0x1D")]
	[CalledBy(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027E0")]
	public CultureInfo(int culture) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027D2")]
	private void CheckNeutral() { }

	[Address(RVA = "0x14280C0", Offset = "0x14272C0", Length = "0x1CC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60027CA")]
	public override object Clone() { }

	[Address(RVA = "0x1428740", Offset = "0x1427940", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Token(Token = "0x60027D9")]
	private void Construct() { }

	[Address(RVA = "0x142C6E0", Offset = "0x142B8E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Token(Token = "0x60027DA")]
	private bool construct_internal_locale_from_lcid(int lcid) { }

	[Address(RVA = "0x142C6F0", Offset = "0x142B8F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210CF0")]
	[Token(Token = "0x60027DB")]
	private bool construct_internal_locale_from_name(string name) { }

	[Address(RVA = "0x1428290", Offset = "0x1427490", Length = "0x1E4")]
	[CalledBy(Type = typeof(CultureInfo), Member = "ConstructCurrentUICulture", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_UserDefaultUICulture", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_UserDefaultCulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211CB0")]
	[Calls(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60027C1")]
	internal static CultureInfo ConstructCurrentCulture() { }

	[Address(RVA = "0x1428480", Offset = "0x1427680", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
	[Token(Token = "0x60027C2")]
	internal static CultureInfo ConstructCurrentUICulture() { }

	[Address(RVA = "0x14284C0", Offset = "0x14276C0", Length = "0x1D8")]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "Clone", ReturnType = typeof(object))]
	[Calls(Type = typeof(TextInfo), Member = "get_Invariant", ReturnType = typeof(TextInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60027DE")]
	private void ConstructInvariant(bool read_only) { }

	[Address(RVA = "0x14286A0", Offset = "0x14278A0", Length = "0x92")]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210CF0")]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027EC")]
	private bool ConstructLocaleFromName(string name) { }

	[Address(RVA = "0x1428760", Offset = "0x1427960", Length = "0x1F6")]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_Calendar", ReturnType = typeof(Calendar))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE760")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(GregorianCalendar), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GregorianCalendarTypes)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027EF")]
	private static Calendar CreateCalendar(int calendarType) { }

	[Address(RVA = "0x1428960", Offset = "0x1427B60", Length = "0x81")]
	[CalledBy(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027EA")]
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	[Address(RVA = "0x14289F0", Offset = "0x1427BF0", Length = "0x9B")]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureNotFoundException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027F0")]
	private static Exception CreateNotFoundException(string name) { }

	[Address(RVA = "0x142AC70", Offset = "0x1429E70", Length = "0x312")]
	[CalledBy(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CalendarType", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructLocaleFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CultureInfo), Member = "CreateSpecificCultureFromNeutral", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "CreateNotFoundException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027EB")]
	public static CultureInfo CreateSpecificCulture(string name) { }

	[Address(RVA = "0x1428A90", Offset = "0x1427C90", Length = "0x21D0")]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 133)]
	[Token(Token = "0x60027ED")]
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	[Address(RVA = "0x142AF90", Offset = "0x142A190", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027DF")]
	private TextInfo CreateTextInfo(bool readOnly) { }

	[Address(RVA = "0x142B010", Offset = "0x142A210", Length = "0x8B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027CB")]
	public virtual bool Equals(object value) { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027BC")]
	internal CultureData get__cultureData() { }

	[Address(RVA = "0x142D2A0", Offset = "0x142C4A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60027BD")]
	internal bool get__isInherited() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027C4")]
	internal string get__name() { }

	[Address(RVA = "0x142C7A0", Offset = "0x142B9A0", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "CreateCalendar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Calendar))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60027C7")]
	public override Calendar get_Calendar() { }

	[Address(RVA = "0x142C700", Offset = "0x142B900", Length = "0x98")]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateSpecificCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60027EE")]
	internal int get_CalendarType() { }

	[Address(RVA = "0x142C840", Offset = "0x142BA40", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CompareInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60027D0")]
	public override CompareInfo get_CompareInfo() { }

	[Address(RVA = "0x142D2B0", Offset = "0x142C4B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211CB0")]
	[Token(Token = "0x60027DC")]
	private static string get_current_locale_name() { }

	[Address(RVA = "0x142C980", Offset = "0x142BB80", Length = "0x23")]
	[CallerCount(Count = 134)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027BF")]
	public static CultureInfo get_CurrentCulture() { }

	[Address(RVA = "0x142C9B0", Offset = "0x142BBB0", Length = "0x23")]
	[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "CheckConsistency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C0")]
	public static CultureInfo get_CurrentUICulture() { }

	[Address(RVA = "0x142C9E0", Offset = "0x142BBE0", Length = "0x187")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData), typeof(Calendar)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60027D5")]
	public override DateTimeFormatInfo get_DateTimeFormat() { }

	[Address(RVA = "0x142CB70", Offset = "0x142BD70", Length = "0x5A")]
	[CalledBy(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60027F1")]
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	[Address(RVA = "0x142CBD0", Offset = "0x142BDD0", Length = "0x5A")]
	[CalledBy(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60027F2")]
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	[Address(RVA = "0x142CC30", Offset = "0x142BE30", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Token(Token = "0x60027D7")]
	public override string get_EnglishName() { }

	[Address(RVA = "0x142CC70", Offset = "0x142BE70", Length = "0x59")]
	[CallerCount(Count = 378)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60027BE")]
	public static CultureInfo get_InvariantCulture() { }

	[Address(RVA = "0x142CCD0", Offset = "0x142BED0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027D1")]
	public override bool get_IsNeutralCulture() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027C5")]
	public override int get_LCID() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027C6")]
	public override string get_Name() { }

	[Address(RVA = "0x142CD10", Offset = "0x142BF10", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027D3")]
	public override NumberFormatInfo get_NumberFormat() { }

	[Address(RVA = "0x142CDC0", Offset = "0x142BFC0", Length = "0x2CA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60027C8")]
	public override CultureInfo get_Parent() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027F3")]
	internal string get_SortName() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027C3")]
	internal string get_Territory() { }

	[Address(RVA = "0x142D090", Offset = "0x142C290", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027C9")]
	public override TextInfo get_TextInfo() { }

	[Address(RVA = "0x142D1E0", Offset = "0x142C3E0", Length = "0x40")]
	[CalledBy(Type = typeof(Thread), Member = "GetCurrentCultureNoAppX", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
	[Token(Token = "0x60027F5")]
	internal static CultureInfo get_UserDefaultCulture() { }

	[Address(RVA = "0x142D220", Offset = "0x142C420", Length = "0x71")]
	[CalledBy(Type = typeof(Thread), Member = "GetCurrentUICultureNoAppX", ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "ConstructCurrentCulture", ReturnType = typeof(CultureInfo))]
	[Token(Token = "0x60027F4")]
	internal static CultureInfo get_UserDefaultUICulture() { }

	[Address(RVA = "0x142B190", Offset = "0x142A390", Length = "0x25F")]
	[CalledBy(Type = typeof(CompareInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CultureInfo), Member = "insert_into_shared_tables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x60027E8")]
	public static CultureInfo GetCultureInfo(int culture) { }

	[Address(RVA = "0x142B3F0", Offset = "0x142A5F0", Length = "0x250")]
	[CalledBy(Type = typeof(RegionInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "OnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CalendarData), Member = "GetCalendarData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CalendarData))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_CompareInfo", ReturnType = typeof(CompareInfo))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_Culture", ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(Calendar), Member = "get_CurrentEraValue", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(CompareInfo), Member = "OnSerializing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "GetCompareInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CompareInfo))]
	[CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(UltimateResourceFallbackLocation&)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CultureInfo), Member = "insert_into_shared_tables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027E9")]
	public static CultureInfo GetCultureInfo(string name) { }

	[Address(RVA = "0x142B0A0", Offset = "0x142A2A0", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027F8")]
	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX() { }

	[Address(RVA = "0x142B650", Offset = "0x142A850", Length = "0x3C9")]
	[CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "GetStandardValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext"}, ReturnType = "System.ComponentModel.TypeConverter+StandardValuesCollection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CultureData), Member = "GetCultureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(int), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(string)}, ReturnType = typeof(CultureData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211EE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60027CC")]
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	[Address(RVA = "0x142BA20", Offset = "0x142AC20", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60027D8")]
	public override object GetFormat(Type formatType) { }

	[Address(RVA = "0x142BB20", Offset = "0x142AD20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60027CE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x142BB30", Offset = "0x142AD30", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60027CD")]
	private Data GetTextInfoData() { }

	[Address(RVA = "0x142BB50", Offset = "0x142AD50", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE8B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[Token(Token = "0x60027F6")]
	private static void InitializeUserPreferredCultureInfoInAppX(OnCultureInfoChangedDelegate onCultureInfoChangedInAppX) { }

	[Address(RVA = "0x142D2C0", Offset = "0x142C4C0", Length = "0x1C5")]
	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CultureInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027E7")]
	private static void insert_into_shared_tables(CultureInfo c) { }

	[Address(RVA = "0x142D490", Offset = "0x142C690", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180211EE0")]
	[Token(Token = "0x60027DD")]
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	[Address(RVA = "0x142BB70", Offset = "0x142AD70", Length = "0xD1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[MonoPInvokeCallback(typeof(OnCultureInfoChangedDelegate))]
	[Token(Token = "0x60027F7")]
	private static void OnCultureInfoChangedInAppX(string language) { }

	[Address(RVA = "0x142D4A0", Offset = "0x142C6A0", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027D6")]
	public override void set_DateTimeFormat(DateTimeFormatInfo value) { }

	[Address(RVA = "0x142D590", Offset = "0x142C790", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180210C90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60027D4")]
	public override void set_NumberFormat(NumberFormatInfo value) { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60027CF")]
	public virtual string ToString() { }

}

