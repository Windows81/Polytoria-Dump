namespace HSVPicker;

[Token(Token = "0x2000009")]
public class ColorPicker : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000017")]
	private float _hue; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000018")]
	private float _saturation; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000019")]
	private float _brightness; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x400001A")]
	private Color _color; //Field offset: 0x2C
	[FieldOffset(Offset = "0x40")]
	[Header("Setup")]
	[Token(Token = "0x400001B")]
	public ColorPickerSetup Setup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Header("Event")]
	[Token(Token = "0x400001C")]
	public ColorChangedEvent onValueChanged; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400001D")]
	public HSVChangedEvent onHSVChanged; //Field offset: 0x50

	[Token(Token = "0x17000008")]
	public float A
	{
		[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000020")]
		 get { } //Length: 6
		[Address(RVA = "0x1096580", Offset = "0x1095780", Length = "0x19")]
		[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnColorBtnClick", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnColorDisplayerBtnClick", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMin", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMax", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000021")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000007")]
	public float B
	{
		[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001E")]
		 get { } //Length: 6
		[Address(RVA = "0x10965A0", Offset = "0x10957A0", Length = "0x36")]
		[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnColorBtnClick", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnColorDisplayerBtnClick", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMin", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMax", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600001F")]
		 set { } //Length: 54
	}

	[Token(Token = "0x17000001")]
	public Color CurrentColor
	{
		[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000011")]
		 get { } //Length: 11
		[Address(RVA = "0x1095E10", Offset = "0x1095010", Length = "0x93")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000012")]
		 set { } //Length: 147
	}

	[Token(Token = "0x17000006")]
	public float G
	{
		[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001C")]
		 get { } //Length: 6
		[Address(RVA = "0x10965E0", Offset = "0x10957E0", Length = "0x36")]
		[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnColorBtnClick", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnColorDisplayerBtnClick", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMin", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMax", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600001D")]
		 set { } //Length: 54
	}

	[Token(Token = "0x17000002")]
	public float H
	{
		[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000014")]
		 get { } //Length: 6
		[Address(RVA = "0x1096620", Offset = "0x1095820", Length = "0x70")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000015")]
		 set { } //Length: 112
	}

	[Token(Token = "0x17000005")]
	public float R
	{
		[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600001A")]
		 get { } //Length: 6
		[Address(RVA = "0x1096690", Offset = "0x1095890", Length = "0x36")]
		[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnColorBtnClick", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnColorDisplayerBtnClick", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMin", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMax", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
		[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600001B")]
		 set { } //Length: 54
	}

	[Token(Token = "0x17000003")]
	public float S
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000016")]
		 get { } //Length: 6
		[Address(RVA = "0x10966D0", Offset = "0x10958D0", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000017")]
		 set { } //Length: 115
	}

	[Token(Token = "0x17000004")]
	public float V
	{
		[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000018")]
		 get { } //Length: 6
		[Address(RVA = "0x1096750", Offset = "0x1095950", Length = "0x73")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
		[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000019")]
		 set { } //Length: 115
	}

	[Address(RVA = "0x1096490", Offset = "0x1095690", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600002B")]
	public ColorPicker() { }

	[Address(RVA = "0x1095E10", Offset = "0x1095010", Length = "0x93")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000026")]
	public void AssignColor(Color color) { }

	[Address(RVA = "0x1095C50", Offset = "0x1094E50", Length = "0x1A0")]
	[CalledBy(Type = typeof(ColorSlider), Member = "SliderChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000025")]
	public void AssignColor(ColorValues type, float value) { }

	[Address(RVA = "0x3B4330", Offset = "0x3B3530", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000020")]
	public float get_A() { }

	[Address(RVA = "0x3B43A0", Offset = "0x3B35A0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001E")]
	public float get_B() { }

	[Address(RVA = "0x599140", Offset = "0x598340", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000011")]
	public Color get_CurrentColor() { }

	[Address(RVA = "0x2DD180", Offset = "0x2DC380", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	public float get_G() { }

	[Address(RVA = "0x3B21C0", Offset = "0x3B13C0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	public float get_H() { }

	[Address(RVA = "0x3B2150", Offset = "0x3B1350", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001A")]
	public float get_R() { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000016")]
	public float get_S() { }

	[Address(RVA = "0x3B2140", Offset = "0x3B1340", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000018")]
	public float get_V() { }

	[Address(RVA = "0x1095EB0", Offset = "0x10950B0", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	public float GetValue(ColorValues type) { }

	[Address(RVA = "0x1095FF0", Offset = "0x10951F0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UiElements), Member = "Toggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002A")]
	private void HandleHeaderSetting(ColorHeaderShowing setupShowHeader) { }

	[Address(RVA = "0x1095F90", Offset = "0x1095190", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
	[Token(Token = "0x6000023")]
	private void HSVChanged() { }

	[Address(RVA = "0x1096090", Offset = "0x1095290", Length = "0xA1")]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_CurrentColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_R", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_G", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_B", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "AssignColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorValues), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "AssignColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPresets), Member = "PresetSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HexColorField), Member = "UpdateColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertRgbToHsv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(HsvColor))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000022")]
	private void RGBChanged() { }

	[Address(RVA = "0x1096140", Offset = "0x1095340", Length = "0x88")]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_A", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HexColorField), Member = "UpdateColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPresets), Member = "PresetSelect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Image)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "AssignColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "AssignColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorValues), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_B", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SVBoxSlider), Member = "SliderChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_G", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_V", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_S", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_H", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_CurrentColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorPicker), Member = "set_R", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`1<UnityEngine.Color>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UnityEngine.Events.UnityEvent`3<System.Single, System.Single, System.Single>), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000024")]
	private void SendChangedEvent() { }

	[Address(RVA = "0x1096580", Offset = "0x1095780", Length = "0x19")]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnColorBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnColorDisplayerBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMin", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMax", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000021")]
	public void set_A(float value) { }

	[Address(RVA = "0x10965A0", Offset = "0x10957A0", Length = "0x36")]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnColorBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnColorDisplayerBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMin", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMax", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001F")]
	public void set_B(float value) { }

	[Address(RVA = "0x1095E10", Offset = "0x1095010", Length = "0x93")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public void set_CurrentColor(Color value) { }

	[Address(RVA = "0x10965E0", Offset = "0x10957E0", Length = "0x36")]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnColorBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnColorDisplayerBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMin", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMax", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001D")]
	public void set_G(float value) { }

	[Address(RVA = "0x1096620", Offset = "0x1095820", Length = "0x70")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000015")]
	public void set_H(float value) { }

	[Address(RVA = "0x1096690", Offset = "0x1095890", Length = "0x36")]
	[CalledBy(Type = "namudev.PropertyGridColor", Member = "OnColorBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColor", Member = "OnColorDisplayerBtnClick", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMin", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Creator.PropertyGrid.Items.PropertyGridItemColorRange", Member = "OnColorDisplayerBtnClickMax", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001B")]
	public void set_R(float value) { }

	[Address(RVA = "0x10966D0", Offset = "0x10958D0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000017")]
	public void set_S(float value) { }

	[Address(RVA = "0x1096750", Offset = "0x1095950", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HSVUtil), Member = "ConvertHsvToRgb", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double), typeof(float)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000019")]
	public void set_V(float value) { }

	[Address(RVA = "0x10961D0", Offset = "0x10953D0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UiElements), Member = "Toggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "UpdateColorToggleText", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "RGBChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorPicker), Member = "SendChangedEvent", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000013")]
	private void Start() { }

	[Address(RVA = "0x1096350", Offset = "0x1095550", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UiElements), Member = "Toggle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000028")]
	public void ToggleColorSliders() { }

	[Address(RVA = "0x10963E0", Offset = "0x10955E0", Length = "0xA6")]
	[CalledBy(Type = typeof(ColorPicker), Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000029")]
	private void UpdateColorToggleText() { }

}

