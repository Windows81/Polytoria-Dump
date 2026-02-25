namespace UnityEngine.Android;

[NativeAsStruct]
[NativeType(Header = "Modules/AndroidJNI/Public/AndroidConfiguration.bindings.h")]
[RequiredByNativeCode]
[Token(Token = "0x2000015")]
public sealed class AndroidConfiguration
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000032")]
	private int <colorMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000033")]
	private int <densityDpi>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000034")]
	private float <fontScale>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000035")]
	private int <fontWeightAdjustment>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000036")]
	private AndroidKeyboard <keyboard>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000037")]
	private AndroidHardwareKeyboardHidden <hardKeyboardHidden>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000038")]
	private AndroidKeyboardHidden <keyboardHidden>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000039")]
	private int <mobileCountryCode>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003A")]
	private int <mobileNetworkCode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400003B")]
	private AndroidNavigation <navigation>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400003C")]
	private AndroidNavigationHidden <navigationHidden>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400003D")]
	private AndroidOrientation <orientation>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400003E")]
	private int <screenHeightDp>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400003F")]
	private int <screenWidthDp>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000040")]
	private int <smallestScreenWidthDp>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000041")]
	private int <screenLayout>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000042")]
	private AndroidTouchScreen <touchScreen>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000043")]
	private int <uiMode>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000044")]
	private string <primaryLocaleCountry>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000045")]
	private string <primaryLocaleLanguage>k__BackingField; //Field offset: 0x60

	[Token(Token = "0x17000005")]
	private int colorMode
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600010D")]
		private get { } //Length: 4
	}

	[Token(Token = "0x1700001A")]
	public AndroidColorModeHdr colorModeHdr
	{
		[Address(RVA = "0x1903150", Offset = "0x1902350", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000122")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700001B")]
	public AndroidColorModeWideColorGamut colorModeWideColorGamut
	{
		[Address(RVA = "0x1903160", Offset = "0x1902360", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000123")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000006")]
	public int densityDpi
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600010E")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000007")]
	public float fontScale
	{
		[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600010F")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000008")]
	public int fontWeightAdjustment
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000110")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000A")]
	public AndroidHardwareKeyboardHidden hardKeyboardHidden
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000112")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public AndroidKeyboard keyboard
	{
		[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000111")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000B")]
	public AndroidKeyboardHidden keyboardHidden
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000113")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000019")]
	public AndroidLocale[] locales
	{
		[Address(RVA = "0x1903170", Offset = "0x1902370", Length = "0x122")]
		[CalledBy(Type = typeof(AndroidConfiguration), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000121")]
		 get { } //Length: 290
	}

	[Token(Token = "0x1700000C")]
	public int mobileCountryCode
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000114")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000D")]
	public int mobileNetworkCode
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000115")]
		 get { } //Length: 174
	}

	[Token(Token = "0x1700000E")]
	public AndroidNavigation navigation
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000116")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700000F")]
	public AndroidNavigationHidden navigationHidden
	{
		[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000117")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000010")]
	public AndroidOrientation orientation
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000118")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000017")]
	private string primaryLocaleCountry
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600011F")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000018")]
	private string primaryLocaleLanguage
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000120")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000011")]
	public int screenHeightDp
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000119")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	private int screenLayout
	{
		[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600011C")]
		private get { } //Length: 4
	}

	[Token(Token = "0x1700001C")]
	public AndroidScreenLayoutDirection screenLayoutDirection
	{
		[Address(RVA = "0x19032A0", Offset = "0x19024A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000124")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700001D")]
	public AndroidScreenLayoutLong screenLayoutLong
	{
		[Address(RVA = "0x19032B0", Offset = "0x19024B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000125")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700001E")]
	public AndroidScreenLayoutRound screenLayoutRound
	{
		[Address(RVA = "0x19032C0", Offset = "0x19024C0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000126")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700001F")]
	public AndroidScreenLayoutSize screenLayoutSize
	{
		[Address(RVA = "0x19032D0", Offset = "0x19024D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000127")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000012")]
	public int screenWidthDp
	{
		[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600011A")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000013")]
	public int smallestScreenWidthDp
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600011B")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000015")]
	public AndroidTouchScreen touchScreen
	{
		[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600011D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000016")]
	private int uiMode
	{
		[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600011E")]
		private get { } //Length: 4
	}

	[Token(Token = "0x17000020")]
	public AndroidUIModeNight uiModeNight
	{
		[Address(RVA = "0x19032E0", Offset = "0x19024E0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000128")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000021")]
	public AndroidUIModeType uiModeType
	{
		[Address(RVA = "0x19032F0", Offset = "0x19024F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000129")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600010D")]
	private int get_colorMode() { }

	[Address(RVA = "0x1903150", Offset = "0x1902350", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000122")]
	public AndroidColorModeHdr get_colorModeHdr() { }

	[Address(RVA = "0x1903160", Offset = "0x1902360", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000123")]
	public AndroidColorModeWideColorGamut get_colorModeWideColorGamut() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600010E")]
	public int get_densityDpi() { }

	[Address(RVA = "0x2BC7F0", Offset = "0x2BB9F0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600010F")]
	public float get_fontScale() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000110")]
	public int get_fontWeightAdjustment() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000112")]
	public AndroidHardwareKeyboardHidden get_hardKeyboardHidden() { }

	[Address(RVA = "0x30FF60", Offset = "0x30F160", Length = "0x4")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000111")]
	public AndroidKeyboard get_keyboard() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000113")]
	public AndroidKeyboardHidden get_keyboardHidden() { }

	[Address(RVA = "0x1903170", Offset = "0x1902370", Length = "0x122")]
	[CalledBy(Type = typeof(AndroidConfiguration), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000121")]
	public AndroidLocale[] get_locales() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000114")]
	public int get_mobileCountryCode() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000115")]
	public int get_mobileNetworkCode() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000116")]
	public AndroidNavigation get_navigation() { }

	[Address(RVA = "0x3212A0", Offset = "0x3204A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000117")]
	public AndroidNavigationHidden get_navigationHidden() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000118")]
	public AndroidOrientation get_orientation() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600011F")]
	private string get_primaryLocaleCountry() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000120")]
	private string get_primaryLocaleLanguage() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000119")]
	public int get_screenHeightDp() { }

	[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600011C")]
	private int get_screenLayout() { }

	[Address(RVA = "0x19032A0", Offset = "0x19024A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000124")]
	public AndroidScreenLayoutDirection get_screenLayoutDirection() { }

	[Address(RVA = "0x19032B0", Offset = "0x19024B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000125")]
	public AndroidScreenLayoutLong get_screenLayoutLong() { }

	[Address(RVA = "0x19032C0", Offset = "0x19024C0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000126")]
	public AndroidScreenLayoutRound get_screenLayoutRound() { }

	[Address(RVA = "0x19032D0", Offset = "0x19024D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000127")]
	public AndroidScreenLayoutSize get_screenLayoutSize() { }

	[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600011A")]
	public int get_screenWidthDp() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600011B")]
	public int get_smallestScreenWidthDp() { }

	[Address(RVA = "0x33C7D0", Offset = "0x33B9D0", Length = "0x4")]
	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600011D")]
	public AndroidTouchScreen get_touchScreen() { }

	[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600011E")]
	private int get_uiMode() { }

	[Address(RVA = "0x19032E0", Offset = "0x19024E0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000128")]
	public AndroidUIModeNight get_uiModeNight() { }

	[Address(RVA = "0x19032F0", Offset = "0x19024F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000129")]
	public AndroidUIModeType get_uiModeType() { }

	[Address(RVA = "0x1902890", Offset = "0x1901A90", Length = "0x8B7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(AndroidConfiguration), Member = "get_locales", ReturnType = typeof(AndroidLocale[]))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Preserve]
	[Token(Token = "0x600012A")]
	public virtual string ToString() { }

}

