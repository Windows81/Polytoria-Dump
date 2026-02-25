namespace HSVPicker;

[Token(Token = "0x200000A")]
public class ColorPickerSetup
{
	[Token(Token = "0x200000B")]
	internal enum ColorHeaderShowing
	{
		Hide = 0,
		ShowColor = 1,
		ShowColorCode = 2,
		ShowAll = 3,
	}

	[Token(Token = "0x200000C")]
	internal class UiElements
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000034")]
		public RectTransform[] Elements; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		public UiElements() { }

		[Address(RVA = "0x1099F00", Offset = "0x1099100", Length = "0x9C")]
		[CalledBy(Type = typeof(ColorPicker), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorPicker), Member = "ToggleColorSliders", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ColorPicker), Member = "HandleHeaderSetting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorHeaderShowing)}, ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600002D")]
		public void Toggle(bool active) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001E")]
	public bool ShowRgb; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400001F")]
	public bool ShowHsv; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000020")]
	public bool ShowAlpha; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x4000021")]
	public bool ShowColorBox; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000022")]
	public bool ShowColorSliderToggle; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000023")]
	public ColorHeaderShowing ShowHeader; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000024")]
	public UiElements RgbSliders; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000025")]
	public UiElements HsvSliders; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000026")]
	public UiElements ColorToggleElement; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000027")]
	public UiElements AlphaSlidiers; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000028")]
	public UiElements ColorHeader; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000029")]
	public UiElements ColorCode; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400002A")]
	public UiElements ColorPreview; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400002B")]
	public UiElements ColorBox; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400002C")]
	public TMP_Text SliderToggleButtonText; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400002D")]
	public string PresetColorsId; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400002E")]
	public Color[] DefaultPresetColors; //Field offset: 0x70

	[Address(RVA = "0x1095BE0", Offset = "0x1094DE0", Length = "0x64")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	public ColorPickerSetup() { }

}

